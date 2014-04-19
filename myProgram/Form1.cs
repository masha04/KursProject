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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void bntBranch_Click(object sender, EventArgs e)
        {
            BranchForm form = new BranchForm();
            form.Show();
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            ManagerForm form = new ManagerForm();
            form.Show();
        }

        private void btnProvisioner_Click(object sender, EventArgs e)
        {
            ProvisionerForm form = new ProvisionerForm();
            form.Show();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            CategoryForm form = new CategoryForm();
            form.Show();
        }

        private void btnMerch_Click(object sender, EventArgs e)
        {
            MerchandiseForm form = new MerchandiseForm();
            form.Show();
        }

        public string s;
        public DataSet ds;
        public DataTable dtBranch;
        public DataTable dtCategory;
        public DataTable dtManager;
        public DataTable dtMerch;
        public DataTable dtProv;
        public DataTable dtSale;
        public DataTable dtStorage;

        private void mainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDataBaseDataSet.Storage". При необходимости она может быть перемещена или удалена.
            this.storageTableAdapter.Fill(this.myDataBaseDataSet.Storage);

            s = @"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\MyDataBase.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            ds = new DataSet();
            SqlDataAdapter daBranch = new SqlDataAdapter("Select * from Branch", s);
            SqlDataAdapter daCategory = new SqlDataAdapter("Select * from Category", s);
            SqlDataAdapter daManager = new SqlDataAdapter("Select * from Manager", s);
            SqlDataAdapter daMerch = new SqlDataAdapter("Select * from Merchandise", s);
            SqlDataAdapter daProv = new SqlDataAdapter("Select * from Provisioner", s);
            SqlDataAdapter daSale = new SqlDataAdapter("Select * from Sale", s);
            SqlDataAdapter daStorage = new SqlDataAdapter("Select * from Storage", s);
            daBranch.Fill(ds, "Branch");
            daCategory.Fill(ds, "Category");
            daManager.Fill(ds, "Manager");
            daMerch.Fill(ds, "Merchandise");
            daProv.Fill(ds, "Provisioner");
            daSale.Fill(ds, "Sale");
            daStorage.Fill(ds, "Storage");
            dtBranch = ds.Tables["Branch"];
            dtCategory = ds.Tables["Category"];
            dtManager = ds.Tables["Manager"];
            dtMerch = ds.Tables["Merchandise"];
            dtProv = ds.Tables["Provisioner"];
            dtSale = ds.Tables["Sale"];
            dtStorage = ds.Tables["Storage"];
        }

    }
}
