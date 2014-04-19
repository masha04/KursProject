namespace myProgram
{
    partial class AddManagerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tBoxFio = new System.Windows.Forms.TextBox();
            this.managerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDataBaseDataSet = new myProgram.MyDataBaseDataSet();
            this.tBoxState = new System.Windows.Forms.TextBox();
            this.cmbBoxBranch = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.managerTableAdapter = new myProgram.MyDataBaseDataSetTableAdapters.ManagerTableAdapter();
            this.branchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.branchTableAdapter = new myProgram.MyDataBaseDataSetTableAdapters.BranchTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите филиал";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ФИО";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Состояние";
            // 
            // tBoxFio
            // 
            this.tBoxFio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.managerBindingSource, "fio", true));
            this.tBoxFio.Location = new System.Drawing.Point(116, 32);
            this.tBoxFio.Name = "tBoxFio";
            this.tBoxFio.Size = new System.Drawing.Size(286, 20);
            this.tBoxFio.TabIndex = 3;
            // 
            // managerBindingSource
            // 
            this.managerBindingSource.DataMember = "Manager";
            this.managerBindingSource.DataSource = this.myDataBaseDataSet;
            // 
            // myDataBaseDataSet
            // 
            this.myDataBaseDataSet.DataSetName = "MyDataBaseDataSet";
            this.myDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBoxState
            // 
            this.tBoxState.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.managerBindingSource, "state", true));
            this.tBoxState.Location = new System.Drawing.Point(116, 57);
            this.tBoxState.Name = "tBoxState";
            this.tBoxState.Size = new System.Drawing.Size(286, 20);
            this.tBoxState.TabIndex = 4;
            // 
            // cmbBoxBranch
            // 
            this.cmbBoxBranch.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.managerBindingSource, "BranchId", true));
            this.cmbBoxBranch.DataSource = this.branchBindingSource;
            this.cmbBoxBranch.DisplayMember = "name";
            this.cmbBoxBranch.FormattingEnabled = true;
            this.cmbBoxBranch.Location = new System.Drawing.Point(116, 6);
            this.cmbBoxBranch.Name = "cmbBoxBranch";
            this.cmbBoxBranch.Size = new System.Drawing.Size(286, 21);
            this.cmbBoxBranch.TabIndex = 5;
            this.cmbBoxBranch.ValueMember = "id";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(246, 83);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(327, 83);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // managerTableAdapter
            // 
            this.managerTableAdapter.ClearBeforeFill = true;
            // 
            // branchBindingSource
            // 
            this.branchBindingSource.DataMember = "Branch";
            this.branchBindingSource.DataSource = this.myDataBaseDataSet;
            // 
            // branchTableAdapter
            // 
            this.branchTableAdapter.ClearBeforeFill = true;
            // 
            // AddManagerForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(414, 114);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cmbBoxBranch);
            this.Controls.Add(this.tBoxState);
            this.Controls.Add(this.tBoxFio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddManagerForm";
            this.Text = "Новый менеджер";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddManagerForm_FormClosing);
            this.Load += new System.EventHandler(this.AddManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBoxFio;
        private System.Windows.Forms.TextBox tBoxState;
        private System.Windows.Forms.ComboBox cmbBoxBranch;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        public MyDataBaseDataSet myDataBaseDataSet;
        public System.Windows.Forms.BindingSource managerBindingSource;
        public MyDataBaseDataSetTableAdapters.ManagerTableAdapter managerTableAdapter;
        private System.Windows.Forms.BindingSource branchBindingSource;
        private MyDataBaseDataSetTableAdapters.BranchTableAdapter branchTableAdapter;
    }
}