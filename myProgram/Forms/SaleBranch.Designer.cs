namespace myProgram
{
    partial class SaleForms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvSale = new System.Windows.Forms.DataGridView();
            this.btnGetSale = new System.Windows.Forms.Button();
            this.myDataBaseDataSet = new myProgram.MyDataBaseDataSet();
            this.saleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saleTableAdapter = new myProgram.MyDataBaseDataSetTableAdapters.SaleTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.merchIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateSaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSale
            // 
            this.dgvSale.AllowUserToAddRows = false;
            this.dgvSale.AllowUserToDeleteRows = false;
            this.dgvSale.AutoGenerateColumns = false;
            this.dgvSale.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.branchIdDataGridViewTextBoxColumn,
            this.merchIdDataGridViewTextBoxColumn,
            this.managerIdDataGridViewTextBoxColumn,
            this.dateSaleDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dgvSale.DataSource = this.saleBindingSource;
            this.dgvSale.Location = new System.Drawing.Point(12, 41);
            this.dgvSale.Name = "dgvSale";
            this.dgvSale.ReadOnly = true;
            this.dgvSale.Size = new System.Drawing.Size(849, 423);
            this.dgvSale.TabIndex = 0;
            // 
            // btnGetSale
            // 
            this.btnGetSale.Location = new System.Drawing.Point(12, 12);
            this.btnGetSale.Name = "btnGetSale";
            this.btnGetSale.Size = new System.Drawing.Size(166, 23);
            this.btnGetSale.TabIndex = 1;
            this.btnGetSale.Text = "Получить список продаж";
            this.btnGetSale.UseVisualStyleBackColor = true;
            this.btnGetSale.Click += new System.EventHandler(this.button1_Click);
            // 
            // myDataBaseDataSet
            // 
            this.myDataBaseDataSet.DataSetName = "MyDataBaseDataSet";
            this.myDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // saleBindingSource
            // 
            this.saleBindingSource.DataMember = "Sale";
            this.saleBindingSource.DataSource = this.myDataBaseDataSet;
            // 
            // saleTableAdapter
            // 
            this.saleTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // branchIdDataGridViewTextBoxColumn
            // 
            this.branchIdDataGridViewTextBoxColumn.DataPropertyName = "BranchId";
            this.branchIdDataGridViewTextBoxColumn.HeaderText = "BranchId";
            this.branchIdDataGridViewTextBoxColumn.Name = "branchIdDataGridViewTextBoxColumn";
            this.branchIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // merchIdDataGridViewTextBoxColumn
            // 
            this.merchIdDataGridViewTextBoxColumn.DataPropertyName = "merchId";
            this.merchIdDataGridViewTextBoxColumn.HeaderText = "merchId";
            this.merchIdDataGridViewTextBoxColumn.Name = "merchIdDataGridViewTextBoxColumn";
            this.merchIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // managerIdDataGridViewTextBoxColumn
            // 
            this.managerIdDataGridViewTextBoxColumn.DataPropertyName = "managerId";
            this.managerIdDataGridViewTextBoxColumn.HeaderText = "managerId";
            this.managerIdDataGridViewTextBoxColumn.Name = "managerIdDataGridViewTextBoxColumn";
            this.managerIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateSaleDataGridViewTextBoxColumn
            // 
            this.dateSaleDataGridViewTextBoxColumn.DataPropertyName = "dateSale";
            this.dateSaleDataGridViewTextBoxColumn.HeaderText = "dateSale";
            this.dateSaleDataGridViewTextBoxColumn.Name = "dateSaleDataGridViewTextBoxColumn";
            this.dateSaleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "count";
            this.countDataGridViewTextBoxColumn.HeaderText = "count";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "state";
            this.stateDataGridViewTextBoxColumn.HeaderText = "state";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            this.stateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SaleForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 476);
            this.Controls.Add(this.btnGetSale);
            this.Controls.Add(this.dgvSale);
            this.Name = "SaleForms";
            this.Text = "Список продаж";
            this.Load += new System.EventHandler(this.SaleBranch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvSale;
        private System.Windows.Forms.Button btnGetSale;
        private MyDataBaseDataSet myDataBaseDataSet;
        private System.Windows.Forms.BindingSource saleBindingSource;
        private MyDataBaseDataSetTableAdapters.SaleTableAdapter saleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn merchIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateSaleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}