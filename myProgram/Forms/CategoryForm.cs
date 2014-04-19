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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDataBaseDataSet.Category". При необходимости она может быть перемещена или удалена.
            this.categoryTableAdapter.Fill(this.myDataBaseDataSet.Category);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCategoryForm addForm = new AddCategoryForm();
            categoryBindingSource.AddNew();

            addForm.categoryBindingSource.DataSource = categoryBindingSource;
            addForm.categoryBindingSource.Position = categoryBindingSource.Position;

            if (addForm.ShowDialog() == DialogResult.OK)
            {
                categoryTableAdapter.Update(myDataBaseDataSet.Category);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            AddCategoryForm upForm = new AddCategoryForm();
            
            upForm.categoryBindingSource.DataSource = categoryBindingSource;
            upForm.categoryBindingSource.Position = categoryBindingSource.Position;

            if (upForm.ShowDialog() == DialogResult.OK)
            {
                categoryTableAdapter.Update(myDataBaseDataSet.Category);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string s = @"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\MyDataBase.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Merchandise", s);
            da.Fill(ds, "Merchandise");

            DataTable dt = ds.Tables["Merchandise"];

            MyDataBaseDataSet.CategoryRow row = (MyDataBaseDataSet.CategoryRow)((DataRowView)categoryBindingSource.Current).Row;

            var c = dt.AsEnumerable()
                .Where(t => t.Field<int>("categoryId") == row.id)
                .Select(t => t);
            if (c.Count() == 0)
            {
                categoryBindingSource.RemoveCurrent();
                categoryBindingSource.EndEdit();
                categoryTableAdapter.Update(myDataBaseDataSet.Category);
            }
            else
            {
                MessageBox.Show("Запись испольуется другими объектами! Удаление невозможно!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
