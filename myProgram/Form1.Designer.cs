namespace myProgram
{
    partial class mainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gBImage = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxEmblem = new System.Windows.Forms.PictureBox();
            this.gBmanag = new System.Windows.Forms.GroupBox();
            this.btnMerch = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnProvisioner = new System.Windows.Forms.Button();
            this.btnManager = new System.Windows.Forms.Button();
            this.bntBranch = new System.Windows.Forms.Button();
            this.gBReport = new System.Windows.Forms.GroupBox();
            this.btnReportMan = new System.Windows.Forms.Button();
            this.btnReportSale = new System.Windows.Forms.Button();
            this.btnReportProv = new System.Windows.Forms.Button();
            this.btnReportMerch = new System.Windows.Forms.Button();
            this.gBStorage = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnZakMerch = new System.Windows.Forms.Button();
            this.btnPerMerch = new System.Windows.Forms.Button();
            this.cbChooseBranch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.storageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDataBaseDataSet = new myProgram.MyDataBaseDataSet();
            this.storageTableAdapter = new myProgram.MyDataBaseDataSetTableAdapters.StorageTableAdapter();
            this.btnPereraspMerch = new System.Windows.Forms.Button();
            this.btnSale = new System.Windows.Forms.Button();
            this.gBImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmblem)).BeginInit();
            this.gBmanag.SuspendLayout();
            this.gBReport.SuspendLayout();
            this.gBStorage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataBaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // gBImage
            // 
            this.gBImage.Controls.Add(this.label1);
            this.gBImage.Controls.Add(this.pictureBoxEmblem);
            this.gBImage.Location = new System.Drawing.Point(12, 2);
            this.gBImage.Name = "gBImage";
            this.gBImage.Size = new System.Drawing.Size(205, 206);
            this.gBImage.TabIndex = 0;
            this.gBImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сеть торговых точек \"Магазин\"";
            // 
            // pictureBoxEmblem
            // 
            this.pictureBoxEmblem.Location = new System.Drawing.Point(6, 10);
            this.pictureBoxEmblem.Name = "pictureBoxEmblem";
            this.pictureBoxEmblem.Size = new System.Drawing.Size(193, 170);
            this.pictureBoxEmblem.TabIndex = 1;
            this.pictureBoxEmblem.TabStop = false;
            // 
            // gBmanag
            // 
            this.gBmanag.Controls.Add(this.btnSale);
            this.gBmanag.Controls.Add(this.btnMerch);
            this.gBmanag.Controls.Add(this.btnCategory);
            this.gBmanag.Controls.Add(this.btnProvisioner);
            this.gBmanag.Controls.Add(this.btnManager);
            this.gBmanag.Controls.Add(this.bntBranch);
            this.gBmanag.Location = new System.Drawing.Point(12, 214);
            this.gBmanag.Name = "gBmanag";
            this.gBmanag.Size = new System.Drawing.Size(205, 199);
            this.gBmanag.TabIndex = 1;
            this.gBmanag.TabStop = false;
            // 
            // btnMerch
            // 
            this.btnMerch.Location = new System.Drawing.Point(7, 140);
            this.btnMerch.Name = "btnMerch";
            this.btnMerch.Size = new System.Drawing.Size(188, 23);
            this.btnMerch.TabIndex = 4;
            this.btnMerch.Text = "Список товаров сети";
            this.btnMerch.UseVisualStyleBackColor = true;
            this.btnMerch.Click += new System.EventHandler(this.btnMerch_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.Location = new System.Drawing.Point(7, 110);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(188, 23);
            this.btnCategory.TabIndex = 3;
            this.btnCategory.Text = "Просмотр категорий товара";
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnProvisioner
            // 
            this.btnProvisioner.Location = new System.Drawing.Point(7, 80);
            this.btnProvisioner.Name = "btnProvisioner";
            this.btnProvisioner.Size = new System.Drawing.Size(188, 23);
            this.btnProvisioner.TabIndex = 2;
            this.btnProvisioner.Text = "Просмотр поставщиков";
            this.btnProvisioner.UseVisualStyleBackColor = true;
            this.btnProvisioner.Click += new System.EventHandler(this.btnProvisioner_Click);
            // 
            // btnManager
            // 
            this.btnManager.Location = new System.Drawing.Point(7, 50);
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(188, 23);
            this.btnManager.TabIndex = 1;
            this.btnManager.Text = "Просмотр менеджеров";
            this.btnManager.UseVisualStyleBackColor = true;
            this.btnManager.Click += new System.EventHandler(this.btnManager_Click);
            // 
            // bntBranch
            // 
            this.bntBranch.Location = new System.Drawing.Point(7, 20);
            this.bntBranch.Name = "bntBranch";
            this.bntBranch.Size = new System.Drawing.Size(188, 23);
            this.bntBranch.TabIndex = 0;
            this.bntBranch.Text = "Просмотр филиалов";
            this.bntBranch.UseVisualStyleBackColor = true;
            this.bntBranch.Click += new System.EventHandler(this.bntBranch_Click);
            // 
            // gBReport
            // 
            this.gBReport.Controls.Add(this.btnReportMan);
            this.gBReport.Controls.Add(this.btnReportSale);
            this.gBReport.Controls.Add(this.btnReportProv);
            this.gBReport.Controls.Add(this.btnReportMerch);
            this.gBReport.Location = new System.Drawing.Point(12, 419);
            this.gBReport.Name = "gBReport";
            this.gBReport.Size = new System.Drawing.Size(205, 140);
            this.gBReport.TabIndex = 2;
            this.gBReport.TabStop = false;
            // 
            // btnReportMan
            // 
            this.btnReportMan.Location = new System.Drawing.Point(7, 108);
            this.btnReportMan.Name = "btnReportMan";
            this.btnReportMan.Size = new System.Drawing.Size(188, 23);
            this.btnReportMan.TabIndex = 3;
            this.btnReportMan.Text = "Результативность менеджеров";
            this.btnReportMan.UseVisualStyleBackColor = true;
            // 
            // btnReportSale
            // 
            this.btnReportSale.Location = new System.Drawing.Point(7, 79);
            this.btnReportSale.Name = "btnReportSale";
            this.btnReportSale.Size = new System.Drawing.Size(188, 23);
            this.btnReportSale.TabIndex = 2;
            this.btnReportSale.Text = "Продаваемость по филиалам";
            this.btnReportSale.UseVisualStyleBackColor = true;
            // 
            // btnReportProv
            // 
            this.btnReportProv.Location = new System.Drawing.Point(7, 49);
            this.btnReportProv.Name = "btnReportProv";
            this.btnReportProv.Size = new System.Drawing.Size(188, 23);
            this.btnReportProv.TabIndex = 1;
            this.btnReportProv.Text = "Популярность поставщиков";
            this.btnReportProv.UseVisualStyleBackColor = true;
            // 
            // btnReportMerch
            // 
            this.btnReportMerch.Location = new System.Drawing.Point(7, 19);
            this.btnReportMerch.Name = "btnReportMerch";
            this.btnReportMerch.Size = new System.Drawing.Size(188, 23);
            this.btnReportMerch.TabIndex = 0;
            this.btnReportMerch.Text = "Продаваемость товара";
            this.btnReportMerch.UseVisualStyleBackColor = true;
            // 
            // gBStorage
            // 
            this.gBStorage.Controls.Add(this.btnPereraspMerch);
            this.gBStorage.Controls.Add(this.dataGridView1);
            this.gBStorage.Controls.Add(this.btnZakMerch);
            this.gBStorage.Controls.Add(this.btnPerMerch);
            this.gBStorage.Controls.Add(this.cbChooseBranch);
            this.gBStorage.Controls.Add(this.label2);
            this.gBStorage.Location = new System.Drawing.Point(223, 2);
            this.gBStorage.Name = "gBStorage";
            this.gBStorage.Size = new System.Drawing.Size(668, 557);
            this.gBStorage.TabIndex = 3;
            this.gBStorage.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(656, 473);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnZakMerch
            // 
            this.btnZakMerch.Location = new System.Drawing.Point(499, 525);
            this.btnZakMerch.Name = "btnZakMerch";
            this.btnZakMerch.Size = new System.Drawing.Size(163, 23);
            this.btnZakMerch.TabIndex = 3;
            this.btnZakMerch.Text = "Заказать товар";
            this.btnZakMerch.UseVisualStyleBackColor = true;
            // 
            // btnPerMerch
            // 
            this.btnPerMerch.Location = new System.Drawing.Point(0, 0);
            this.btnPerMerch.Name = "btnPerMerch";
            this.btnPerMerch.Size = new System.Drawing.Size(75, 23);
            this.btnPerMerch.TabIndex = 5;
            // 
            // cbChooseBranch
            // 
            this.cbChooseBranch.FormattingEnabled = true;
            this.cbChooseBranch.Location = new System.Drawing.Point(197, 19);
            this.cbChooseBranch.Name = "cbChooseBranch";
            this.cbChooseBranch.Size = new System.Drawing.Size(166, 21);
            this.cbChooseBranch.TabIndex = 1;
            this.cbChooseBranch.Text = "Выберите филиал";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Наличие товара на складе";
            // 
            // storageBindingSource
            // 
            this.storageBindingSource.DataMember = "Storage";
            this.storageBindingSource.DataSource = this.myDataBaseDataSet;
            // 
            // myDataBaseDataSet
            // 
            this.myDataBaseDataSet.DataSetName = "MyDataBaseDataSet";
            this.myDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // storageTableAdapter
            // 
            this.storageTableAdapter.ClearBeforeFill = true;
            // 
            // btnPereraspMerch
            // 
            this.btnPereraspMerch.Location = new System.Drawing.Point(330, 525);
            this.btnPereraspMerch.Name = "btnPereraspMerch";
            this.btnPereraspMerch.Size = new System.Drawing.Size(163, 23);
            this.btnPereraspMerch.TabIndex = 6;
            this.btnPereraspMerch.Text = "Перераспределить товар";
            this.btnPereraspMerch.UseVisualStyleBackColor = true;
            // 
            // btnSale
            // 
            this.btnSale.Location = new System.Drawing.Point(7, 167);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(188, 23);
            this.btnSale.TabIndex = 5;
            this.btnSale.Text = "Список продаж";
            this.btnSale.UseVisualStyleBackColor = true;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 571);
            this.Controls.Add(this.gBStorage);
            this.Controls.Add(this.gBReport);
            this.Controls.Add(this.gBmanag);
            this.Controls.Add(this.gBImage);
            this.Name = "mainForm";
            this.Text = "Сеть торговых точек \"Магазин\"";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.gBImage.ResumeLayout(false);
            this.gBImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmblem)).EndInit();
            this.gBmanag.ResumeLayout(false);
            this.gBReport.ResumeLayout(false);
            this.gBStorage.ResumeLayout(false);
            this.gBStorage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataBaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxEmblem;
        private System.Windows.Forms.GroupBox gBmanag;
        private System.Windows.Forms.Button btnManager;
        private System.Windows.Forms.Button bntBranch;
        private System.Windows.Forms.Button btnMerch;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnProvisioner;
        private System.Windows.Forms.GroupBox gBReport;
        private System.Windows.Forms.Button btnReportMan;
        private System.Windows.Forms.Button btnReportSale;
        private System.Windows.Forms.Button btnReportProv;
        private System.Windows.Forms.Button btnReportMerch;
        private System.Windows.Forms.GroupBox gBStorage;
        private System.Windows.Forms.Button btnZakMerch;
        private System.Windows.Forms.Button btnPerMerch;
        private System.Windows.Forms.ComboBox cbChooseBranch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        public MyDataBaseDataSet myDataBaseDataSet;
        public System.Windows.Forms.BindingSource storageBindingSource;
        public MyDataBaseDataSetTableAdapters.StorageTableAdapter storageTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn menchIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Button btnPereraspMerch;
    }
}

