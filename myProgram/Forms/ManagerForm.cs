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
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDataBaseDataSet.ManagerDGV". При необходимости она может быть перемещена или удалена.
            this.managerDGVTableAdapter.Fill(this.myDataBaseDataSet.ManagerDGV);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddManagerForm addForm = new AddManagerForm();
            managerDGVBindingSource.AddNew();

            addForm.managerBindingSource.DataSource = managerDGVBindingSource;
            addForm.managerBindingSource.Position = managerDGVBindingSource.Position;

            if (addForm.ShowDialog() == DialogResult.OK)
            {
                managerDGVTableAdapter.Update(myDataBaseDataSet.ManagerDGV);
                this.managerDGVTableAdapter.Fill(this.myDataBaseDataSet.ManagerDGV);
                dataGridView1.CurrentCell = dataGridView1.Rows[managerDGVBindingSource.Count - 1].Cells[2];
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            AddManagerForm upForm = new AddManagerForm();

            upForm.managerBindingSource.DataSource = managerDGVBindingSource;
            upForm.managerBindingSource.Position = managerDGVBindingSource.Position;

            if (upForm.ShowDialog() == DialogResult.OK)
            {
                managerDGVTableAdapter.Update(myDataBaseDataSet.ManagerDGV);
                int index = dataGridView1.CurrentRow.Index;
                this.managerDGVTableAdapter.Fill(this.myDataBaseDataSet.ManagerDGV);
                dataGridView1.CurrentCell = dataGridView1.Rows[index].Cells[2];
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            managerDGVBindingSource.RemoveCurrent();
            managerDGVBindingSource.EndEdit();
            managerDGVTableAdapter.Update(myDataBaseDataSet.ManagerDGV);
        }
    }
}
