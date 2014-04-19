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

        private void mainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDataBaseDataSet.Storage". При необходимости она может быть перемещена или удалена.
            this.storageTableAdapter.Fill(this.myDataBaseDataSet.Storage);

        }

    }
}
