namespace ProjectManagement
{
    partial class User_List
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
            this.userListGrid = new System.Windows.Forms.DataGridView();
            this.projectManagementDBDataSet = new ProjectManagement.ProjectManagementDBDataSet();
            this.eXPERTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eXPERTSTableAdapter = new ProjectManagement.ProjectManagementDBDataSetTableAdapters.EXPERTSTableAdapter();
            this.tableAdapterManager = new ProjectManagement.ProjectManagementDBDataSetTableAdapters.TableAdapterManager();
            this.eXPRETIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXPERTTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXPERTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXPERTSURNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXPERTLASTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.userListGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPERTSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // userListGrid
            // 
            this.userListGrid.AutoGenerateColumns = false;
            this.userListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userListGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eXPRETIDDataGridViewTextBoxColumn,
            this.eXPERTTYPEDataGridViewTextBoxColumn,
            this.eXPERTNAMEDataGridViewTextBoxColumn,
            this.eXPERTSURNAMEDataGridViewTextBoxColumn,
            this.eXPERTLASTNAMEDataGridViewTextBoxColumn});
            this.userListGrid.DataSource = this.eXPERTSBindingSource;
            this.userListGrid.Location = new System.Drawing.Point(-1, -3);
            this.userListGrid.Name = "userListGrid";
            this.userListGrid.Size = new System.Drawing.Size(804, 458);
            this.userListGrid.TabIndex = 0;
            // 
            // projectManagementDBDataSet
            // 
            this.projectManagementDBDataSet.DataSetName = "ProjectManagementDBDataSet";
            this.projectManagementDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eXPERTSBindingSource
            // 
            this.eXPERTSBindingSource.DataMember = "EXPERTS";
            this.eXPERTSBindingSource.DataSource = this.projectManagementDBDataSet;
            // 
            // eXPERTSTableAdapter
            // 
            this.eXPERTSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EXPERTSTableAdapter = this.eXPERTSTableAdapter;
            this.tableAdapterManager.PROJECT_STATUSTableAdapter = null;
            this.tableAdapterManager.PROJECT_TASKSTableAdapter = null;
            this.tableAdapterManager.PROJECTSTableAdapter = null;
            this.tableAdapterManager.TASK_STATUSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjectManagement.ProjectManagementDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // eXPRETIDDataGridViewTextBoxColumn
            // 
            this.eXPRETIDDataGridViewTextBoxColumn.DataPropertyName = "EXPRET_ID";
            this.eXPRETIDDataGridViewTextBoxColumn.HeaderText = "EXPRET_ID";
            this.eXPRETIDDataGridViewTextBoxColumn.Name = "eXPRETIDDataGridViewTextBoxColumn";
            // 
            // eXPERTTYPEDataGridViewTextBoxColumn
            // 
            this.eXPERTTYPEDataGridViewTextBoxColumn.DataPropertyName = "EXPERT_TYPE";
            this.eXPERTTYPEDataGridViewTextBoxColumn.HeaderText = "EXPERT_TYPE";
            this.eXPERTTYPEDataGridViewTextBoxColumn.Name = "eXPERTTYPEDataGridViewTextBoxColumn";
            // 
            // eXPERTNAMEDataGridViewTextBoxColumn
            // 
            this.eXPERTNAMEDataGridViewTextBoxColumn.DataPropertyName = "EXPERT_NAME";
            this.eXPERTNAMEDataGridViewTextBoxColumn.HeaderText = "EXPERT_NAME";
            this.eXPERTNAMEDataGridViewTextBoxColumn.Name = "eXPERTNAMEDataGridViewTextBoxColumn";
            // 
            // eXPERTSURNAMEDataGridViewTextBoxColumn
            // 
            this.eXPERTSURNAMEDataGridViewTextBoxColumn.DataPropertyName = "EXPERT_SURNAME";
            this.eXPERTSURNAMEDataGridViewTextBoxColumn.HeaderText = "EXPERT_SURNAME";
            this.eXPERTSURNAMEDataGridViewTextBoxColumn.Name = "eXPERTSURNAMEDataGridViewTextBoxColumn";
            // 
            // eXPERTLASTNAMEDataGridViewTextBoxColumn
            // 
            this.eXPERTLASTNAMEDataGridViewTextBoxColumn.DataPropertyName = "EXPERT_LASTNAME";
            this.eXPERTLASTNAMEDataGridViewTextBoxColumn.HeaderText = "EXPERT_LASTNAME";
            this.eXPERTLASTNAMEDataGridViewTextBoxColumn.Name = "eXPERTLASTNAMEDataGridViewTextBoxColumn";
            // 
            // User_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userListGrid);
            this.Name = "User_List";
            this.Text = "User_List";
            this.Load += new System.EventHandler(this.User_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userListGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPERTSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView userListGrid;
        private ProjectManagementDBDataSet projectManagementDBDataSet;
        private System.Windows.Forms.BindingSource eXPERTSBindingSource;
        private ProjectManagementDBDataSetTableAdapters.EXPERTSTableAdapter eXPERTSTableAdapter;
        private ProjectManagementDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXPRETIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXPERTTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXPERTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXPERTSURNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXPERTLASTNAMEDataGridViewTextBoxColumn;
    }
}