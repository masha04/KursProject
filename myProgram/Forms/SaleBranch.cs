using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace myProgram
{
    public partial class SaleForms : Form
    {
        public SaleForms()
        {
            InitializeComponent();
        }

        private void SaleBranch_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDataBaseDataSet.Sale". При необходимости она может быть перемещена или удалена.
            this.saleTableAdapter.Fill(this.myDataBaseDataSet.Sale);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = @"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\MyDataBase.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            DataSet ds = new DataSet();
            SqlDataAdapter daBranch = new SqlDataAdapter("Select * from Branch", s);
            SqlDataAdapter daMerch = new SqlDataAdapter("Select * from Merchandise", s);
            SqlDataAdapter daManager = new SqlDataAdapter("Select * from Manager", s);
            daBranch.Fill(ds, "Branch");
            daMerch.Fill(ds, "Merchandise");
            daManager.Fill(ds, "Manager");
            DataTable dtBranch = ds.Tables["Branch"];
            DataTable dtMerch = ds.Tables["Merchandise"];
            DataTable dtManager = ds.Tables["Manager"];

            Mail mail = new Mail();
            string[,] listExcel = mail.WorkExcel();

            int countRowDgv = saleBindingSource.Count;

            if (countRowDgv == 0)
            {
                for (int i = 1; i < listExcel.GetLength(0); i++)
                {
                    saleBindingSource.AddNew();
                    for (int j = 0; j < listExcel.GetLength(1); j++)
                    {
                        if (j == 0)
                            dgvSale.Rows[i - 1].Cells[j + 1].Value = mail.GetId(dtBranch, "name", listExcel[i, j]);
                        else
                        {
                            if (j == 1)
                                dgvSale.Rows[i - 1].Cells[j + 1].Value = mail.GetId(dtMerch, "name", listExcel[i, j]);
                            else
                            {
                                if (j == 2)
                                    dgvSale.Rows[i - 1].Cells[j + 1].Value = mail.GetId(dtManager, "fio", listExcel[i, j]);
                                else
                                    dgvSale.Rows[i - 1].Cells[j + 1].Value = listExcel[i, j];
                            }
                        }
                    }
                    saleBindingSource.EndEdit();
                    saleTableAdapter.Update(myDataBaseDataSet.Sale);
                }
            }
            else
            {
                for (int i = 1; i < listExcel.GetLength(0); i++)
                {
                    if (i + countRowDgv == listExcel.GetLength(0) + countRowDgv)
                        break;

                    saleBindingSource.AddNew();
                    for (int j = 0; j < listExcel.GetLength(1); j++)
                    {
                        if (j == 0)
                            dgvSale.Rows[i - 1 + countRowDgv].Cells[j + 1].Value = mail.GetId(dtBranch, "name", listExcel[i, j]);
                        else
                        {
                            if (j == 1)
                                dgvSale.Rows[i - 1 + countRowDgv].Cells[j + 1].Value = mail.GetId(dtMerch, "name", listExcel[i, j]);
                            else
                            {
                                if (j == 2)
                                    dgvSale.Rows[i - 1 + countRowDgv].Cells[j + 1].Value = mail.GetId(dtManager, "fio", listExcel[i, j]);
                                else
                                    dgvSale.Rows[i - 1 + countRowDgv].Cells[j + 1].Value = listExcel[i, j];
                            }
                        }
                    }
                    saleBindingSource.EndEdit();
                    saleTableAdapter.Update(myDataBaseDataSet.Sale);
                }
            }
        }
    }
}
