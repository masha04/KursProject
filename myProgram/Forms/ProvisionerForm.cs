using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Linq;

namespace myProgram
{
    public partial class ProvisionerForm : Form
    {
        public ProvisionerForm()
        {
            InitializeComponent();
        }

        private void ProvisionerForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDataBaseDataSet.Provisioner". При необходимости она может быть перемещена или удалена.
            this.provisionerTableAdapter1.Fill(this.myDataBaseDataSet.Provisioner);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDataBaseDataSet.Provisioner". При необходимости она может быть перемещена или удалена.
            this.provisionerTableAdapter.Fill(this.myDataBaseDataSet.Provisioner);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddProvisForm addForm = new AddProvisForm();
            provisionerBindingSource.AddNew();

            addForm.provisionerBindingSource.DataSource = provisionerBindingSource;
            addForm.provisionerBindingSource.Position = provisionerBindingSource.Position;

            if (addForm.ShowDialog() == DialogResult.OK)
            {
                provisionerTableAdapter1.Update(myDataBaseDataSet.Provisioner);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            AddProvisForm upForm = new AddProvisForm();

            upForm.provisionerBindingSource.DataSource = provisionerBindingSource;
            upForm.provisionerBindingSource.Position = provisionerBindingSource.Position;

            if (upForm.ShowDialog() == DialogResult.OK)
            {
                provisionerTableAdapter1.Update(myDataBaseDataSet.Provisioner);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string s = @"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\MyDataBase.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Merchandise", s);
            da.Fill(ds, "Merchandise");

            DataTable dt = ds.Tables["Merchandise"];

            MyDataBaseDataSet.ProvisionerRow row = (MyDataBaseDataSet.ProvisionerRow)((DataRowView)provisionerBindingSource.Current).Row;

            var c = dt.AsEnumerable()
                .Where(t => t.Field<int>("SupplierId") == row.id)
                .Select(t => t);

            if (c.Count() == 0)
            {
                provisionerBindingSource.RemoveCurrent();
                provisionerBindingSource.EndEdit();
                provisionerTableAdapter1.Update(myDataBaseDataSet.Provisioner);
            }
            else
            {
                MessageBox.Show("Запись испольуется другими объектами! Удаление невозможно!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
