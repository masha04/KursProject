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
    public partial class BranchForm : Form
    {
        public BranchForm()
        {
            InitializeComponent();
        }

        private void BranchForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDataBaseDataSet.Branch". При необходимости она может быть перемещена или удалена.
            this.branchTableAdapter.Fill(this.myDataBaseDataSet.Branch);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddBranchForm addForm = new AddBranchForm();
            branchBindingSource.AddNew();

            addForm.branchBindingSource.DataSource = branchBindingSource;
            addForm.branchBindingSource.Position = branchBindingSource.Position;

            if (addForm.ShowDialog() == DialogResult.OK)
            {
                branchTableAdapter.Update(this.myDataBaseDataSet.Branch);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            AddBranchForm upForm = new AddBranchForm();

            upForm.branchBindingSource.DataSource = branchBindingSource;
            upForm.branchBindingSource.Position = branchBindingSource.Position;

            if (upForm.ShowDialog() == DialogResult.OK)
            {
                branchTableAdapter.Update(this.myDataBaseDataSet.Branch);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string s = @"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\MyDataBase.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Manager", s);
            da.Fill(ds, "Manager");

            DataTable dt = ds.Tables["Manager"];

            MyDataBaseDataSet.BranchRow row = (MyDataBaseDataSet.BranchRow)((DataRowView)branchBindingSource.Current).Row;

            var c = dt.AsEnumerable()
                .Where(t=>t.Field<int>("BranchId")==row.id)
                .Select(t=>t);

            if (c.Count() == 0)
            {
                branchBindingSource.RemoveCurrent();
                branchBindingSource.EndEdit();
                branchTableAdapter.Update(this.myDataBaseDataSet.Branch);
            }
            else
            {
                MessageBox.Show("Запись испольуется другими объектами! Удаление невозможно!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
