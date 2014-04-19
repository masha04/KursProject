using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace myProgram
{
    public partial class MerchandiseForm : Form
    {
        public MerchandiseForm()
        {
            InitializeComponent();
        }

        private void MerchandiseForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDataBaseDataSet.MerchandiseDGV". При необходимости она может быть перемещена или удалена.
            this.merchandiseDGVTableAdapter.Fill(this.myDataBaseDataSet.MerchandiseDGV);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddMerchandiseForm addForm = new AddMerchandiseForm();
            merchandiseDGVBindingSource.AddNew();

            addForm.merchandiseBindingSource.DataSource = merchandiseDGVBindingSource;
            addForm.merchandiseBindingSource.Position = merchandiseDGVBindingSource.Position;

            if (addForm.ShowDialog() == DialogResult.OK)
            {
                merchandiseDGVTableAdapter.Update(myDataBaseDataSet.MerchandiseDGV);
                this.merchandiseDGVTableAdapter.Fill(this.myDataBaseDataSet.MerchandiseDGV);
                dataGridView1.CurrentCell = dataGridView1.Rows[merchandiseDGVBindingSource.Count - 1].Cells[2];
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            AddMerchandiseForm upForm = new AddMerchandiseForm();

            upForm.merchandiseBindingSource.DataSource = merchandiseDGVBindingSource;
            upForm.merchandiseBindingSource.Position = merchandiseDGVBindingSource.Position;

            if (upForm.ShowDialog() == DialogResult.OK)
            {
                merchandiseDGVTableAdapter.Update(myDataBaseDataSet.MerchandiseDGV);
                int index = dataGridView1.CurrentRow.Index;
                this.merchandiseDGVTableAdapter.Fill(this.myDataBaseDataSet.MerchandiseDGV);
                dataGridView1.CurrentCell = dataGridView1.Rows[index].Cells[2];
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            merchandiseDGVBindingSource.RemoveCurrent();
            merchandiseDGVBindingSource.EndEdit();
            merchandiseDGVTableAdapter.Update(myDataBaseDataSet.MerchandiseDGV);
        }        
    }
}
