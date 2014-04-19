namespace myProgram
{
    partial class AddMerchandiseForm
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
            this.textBoxArt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.cmbBoxCategory = new System.Windows.Forms.ComboBox();
            this.cmbBoxProvis = new System.Windows.Forms.ComboBox();
            this.txtBoxState = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.myDataBaseDataSet = new myProgram.MyDataBaseDataSet();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter = new myProgram.MyDataBaseDataSetTableAdapters.CategoryTableAdapter();
            this.merchandiseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.merchandiseTableAdapter = new myProgram.MyDataBaseDataSetTableAdapters.MerchandiseTableAdapter();
            this.provisionerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.provisionerTableAdapter = new myProgram.MyDataBaseDataSetTableAdapters.ProvisionerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.myDataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.merchandiseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provisionerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxArt
            // 
            this.textBoxArt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.merchandiseBindingSource, "artno", true));
            this.textBoxArt.Location = new System.Drawing.Point(132, 12);
            this.textBoxArt.Name = "textBoxArt";
            this.textBoxArt.Size = new System.Drawing.Size(315, 20);
            this.textBoxArt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Артикул";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Выберите категорию";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Выберите поставщика";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Состояние";
            // 
            // txtBoxName
            // 
            this.txtBoxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.merchandiseBindingSource, "name", true));
            this.txtBoxName.Location = new System.Drawing.Point(132, 38);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(315, 20);
            this.txtBoxName.TabIndex = 8;
            // 
            // cmbBoxCategory
            // 
            this.cmbBoxCategory.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.merchandiseBindingSource, "categoryId", true));
            this.cmbBoxCategory.DataSource = this.categoryBindingSource;
            this.cmbBoxCategory.DisplayMember = "name";
            this.cmbBoxCategory.FormattingEnabled = true;
            this.cmbBoxCategory.Location = new System.Drawing.Point(132, 64);
            this.cmbBoxCategory.Name = "cmbBoxCategory";
            this.cmbBoxCategory.Size = new System.Drawing.Size(315, 21);
            this.cmbBoxCategory.TabIndex = 9;
            this.cmbBoxCategory.ValueMember = "id";
            // 
            // cmbBoxProvis
            // 
            this.cmbBoxProvis.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.merchandiseBindingSource, "supplierId", true));
            this.cmbBoxProvis.DataSource = this.provisionerBindingSource;
            this.cmbBoxProvis.DisplayMember = "name";
            this.cmbBoxProvis.FormattingEnabled = true;
            this.cmbBoxProvis.Location = new System.Drawing.Point(132, 92);
            this.cmbBoxProvis.Name = "cmbBoxProvis";
            this.cmbBoxProvis.Size = new System.Drawing.Size(315, 21);
            this.cmbBoxProvis.TabIndex = 10;
            this.cmbBoxProvis.ValueMember = "id";
            // 
            // txtBoxState
            // 
            this.txtBoxState.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.merchandiseBindingSource, "state", true));
            this.txtBoxState.Location = new System.Drawing.Point(132, 120);
            this.txtBoxState.Name = "txtBoxState";
            this.txtBoxState.Size = new System.Drawing.Size(315, 20);
            this.txtBoxState.TabIndex = 11;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(291, 146);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(372, 146);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // myDataBaseDataSet
            // 
            this.myDataBaseDataSet.DataSetName = "MyDataBaseDataSet";
            this.myDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.myDataBaseDataSet;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // merchandiseBindingSource
            // 
            this.merchandiseBindingSource.DataMember = "Merchandise";
            this.merchandiseBindingSource.DataSource = this.myDataBaseDataSet;
            // 
            // merchandiseTableAdapter
            // 
            this.merchandiseTableAdapter.ClearBeforeFill = true;
            // 
            // provisionerBindingSource
            // 
            this.provisionerBindingSource.DataMember = "Provisioner";
            this.provisionerBindingSource.DataSource = this.myDataBaseDataSet;
            // 
            // provisionerTableAdapter
            // 
            this.provisionerTableAdapter.ClearBeforeFill = true;
            // 
            // AddMerchandiseForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(455, 177);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtBoxState);
            this.Controls.Add(this.cmbBoxProvis);
            this.Controls.Add(this.cmbBoxCategory);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxArt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddMerchandiseForm";
            this.Text = "Новый товар";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddMerchandiseForm_FormClosing);
            this.Load += new System.EventHandler(this.AddMerchandiseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.merchandiseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provisionerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxArt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.ComboBox cmbBoxCategory;
        private System.Windows.Forms.ComboBox cmbBoxProvis;
        private System.Windows.Forms.TextBox txtBoxState;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private MyDataBaseDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        public MyDataBaseDataSet myDataBaseDataSet;
        public System.Windows.Forms.BindingSource merchandiseBindingSource;
        public MyDataBaseDataSetTableAdapters.MerchandiseTableAdapter merchandiseTableAdapter;
        private System.Windows.Forms.BindingSource provisionerBindingSource;
        private MyDataBaseDataSetTableAdapters.ProvisionerTableAdapter provisionerTableAdapter;
    }
}