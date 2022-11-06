namespace ProjectManagement
{
    partial class Task_List
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
            this.taskListGrid = new System.Windows.Forms.DataGridView();
            this.projectManagementDBDataSet = new ProjectManagement.ProjectManagementDBDataSet();
            this.pROJECT_TASKSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROJECT_TASKSTableAdapter = new ProjectManagement.ProjectManagementDBDataSetTableAdapters.PROJECT_TASKSTableAdapter();
            this.tableAdapterManager = new ProjectManagement.ProjectManagementDBDataSetTableAdapters.TableAdapterManager();
            this.tASKIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXPRETIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tASKNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tASKDESCRIPTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tASDELIVERABLESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tASKBEGINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tASKENDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tASKPRIORITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tASKSTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tASKREADYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tASKHOURSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.taskListGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECT_TASKSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // taskListGrid
            // 
            this.taskListGrid.AutoGenerateColumns = false;
            this.taskListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taskListGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tASKIDDataGridViewTextBoxColumn,
            this.pROJECTIDDataGridViewTextBoxColumn,
            this.eXPRETIDDataGridViewTextBoxColumn,
            this.tASKNAMEDataGridViewTextBoxColumn,
            this.tASKDESCRIPTIONDataGridViewTextBoxColumn,
            this.tASDELIVERABLESDataGridViewTextBoxColumn,
            this.tASKBEGINDataGridViewTextBoxColumn,
            this.tASKENDDataGridViewTextBoxColumn,
            this.tASKPRIORITYDataGridViewTextBoxColumn,
            this.tASKSTATUSDataGridViewTextBoxColumn,
            this.tASKREADYDataGridViewTextBoxColumn,
            this.tASKHOURSDataGridViewTextBoxColumn});
            this.taskListGrid.DataSource = this.pROJECT_TASKSBindingSource;
            this.taskListGrid.Location = new System.Drawing.Point(1, 0);
            this.taskListGrid.Name = "taskListGrid";
            this.taskListGrid.Size = new System.Drawing.Size(800, 452);
            this.taskListGrid.TabIndex = 0;
            // 
            // projectManagementDBDataSet
            // 
            this.projectManagementDBDataSet.DataSetName = "ProjectManagementDBDataSet";
            this.projectManagementDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pROJECT_TASKSBindingSource
            // 
            this.pROJECT_TASKSBindingSource.DataMember = "PROJECT_TASKS";
            this.pROJECT_TASKSBindingSource.DataSource = this.projectManagementDBDataSet;
            // 
            // pROJECT_TASKSTableAdapter
            // 
            this.pROJECT_TASKSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EXPERTSTableAdapter = null;
            this.tableAdapterManager.PROJECT_STATUSTableAdapter = null;
            this.tableAdapterManager.PROJECT_TASKSTableAdapter = this.pROJECT_TASKSTableAdapter;
            this.tableAdapterManager.PROJECTSTableAdapter = null;
            this.tableAdapterManager.TASK_STATUSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjectManagement.ProjectManagementDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tASKIDDataGridViewTextBoxColumn
            // 
            this.tASKIDDataGridViewTextBoxColumn.DataPropertyName = "TASK_ID";
            this.tASKIDDataGridViewTextBoxColumn.HeaderText = "TASK_ID";
            this.tASKIDDataGridViewTextBoxColumn.Name = "tASKIDDataGridViewTextBoxColumn";
            // 
            // pROJECTIDDataGridViewTextBoxColumn
            // 
            this.pROJECTIDDataGridViewTextBoxColumn.DataPropertyName = "PROJECT_ID";
            this.pROJECTIDDataGridViewTextBoxColumn.HeaderText = "PROJECT_ID";
            this.pROJECTIDDataGridViewTextBoxColumn.Name = "pROJECTIDDataGridViewTextBoxColumn";
            // 
            // eXPRETIDDataGridViewTextBoxColumn
            // 
            this.eXPRETIDDataGridViewTextBoxColumn.DataPropertyName = "EXPRET_ID";
            this.eXPRETIDDataGridViewTextBoxColumn.HeaderText = "EXPRET_ID";
            this.eXPRETIDDataGridViewTextBoxColumn.Name = "eXPRETIDDataGridViewTextBoxColumn";
            // 
            // tASKNAMEDataGridViewTextBoxColumn
            // 
            this.tASKNAMEDataGridViewTextBoxColumn.DataPropertyName = "TASK_NAME";
            this.tASKNAMEDataGridViewTextBoxColumn.HeaderText = "TASK_NAME";
            this.tASKNAMEDataGridViewTextBoxColumn.Name = "tASKNAMEDataGridViewTextBoxColumn";
            // 
            // tASKDESCRIPTIONDataGridViewTextBoxColumn
            // 
            this.tASKDESCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "TASK_DESCRIPTION";
            this.tASKDESCRIPTIONDataGridViewTextBoxColumn.HeaderText = "TASK_DESCRIPTION";
            this.tASKDESCRIPTIONDataGridViewTextBoxColumn.Name = "tASKDESCRIPTIONDataGridViewTextBoxColumn";
            // 
            // tASDELIVERABLESDataGridViewTextBoxColumn
            // 
            this.tASDELIVERABLESDataGridViewTextBoxColumn.DataPropertyName = "TAS_DELIVERABLES";
            this.tASDELIVERABLESDataGridViewTextBoxColumn.HeaderText = "TAS_DELIVERABLES";
            this.tASDELIVERABLESDataGridViewTextBoxColumn.Name = "tASDELIVERABLESDataGridViewTextBoxColumn";
            // 
            // tASKBEGINDataGridViewTextBoxColumn
            // 
            this.tASKBEGINDataGridViewTextBoxColumn.DataPropertyName = "TASK_BEGIN";
            this.tASKBEGINDataGridViewTextBoxColumn.HeaderText = "TASK_BEGIN";
            this.tASKBEGINDataGridViewTextBoxColumn.Name = "tASKBEGINDataGridViewTextBoxColumn";
            // 
            // tASKENDDataGridViewTextBoxColumn
            // 
            this.tASKENDDataGridViewTextBoxColumn.DataPropertyName = "TASK_END";
            this.tASKENDDataGridViewTextBoxColumn.HeaderText = "TASK_END";
            this.tASKENDDataGridViewTextBoxColumn.Name = "tASKENDDataGridViewTextBoxColumn";
            // 
            // tASKPRIORITYDataGridViewTextBoxColumn
            // 
            this.tASKPRIORITYDataGridViewTextBoxColumn.DataPropertyName = "TASK_PRIORITY";
            this.tASKPRIORITYDataGridViewTextBoxColumn.HeaderText = "TASK_PRIORITY";
            this.tASKPRIORITYDataGridViewTextBoxColumn.Name = "tASKPRIORITYDataGridViewTextBoxColumn";
            // 
            // tASKSTATUSDataGridViewTextBoxColumn
            // 
            this.tASKSTATUSDataGridViewTextBoxColumn.DataPropertyName = "TASK_STATUS";
            this.tASKSTATUSDataGridViewTextBoxColumn.HeaderText = "TASK_STATUS";
            this.tASKSTATUSDataGridViewTextBoxColumn.Name = "tASKSTATUSDataGridViewTextBoxColumn";
            // 
            // tASKREADYDataGridViewTextBoxColumn
            // 
            this.tASKREADYDataGridViewTextBoxColumn.DataPropertyName = "TASK_READY";
            this.tASKREADYDataGridViewTextBoxColumn.HeaderText = "TASK_READY";
            this.tASKREADYDataGridViewTextBoxColumn.Name = "tASKREADYDataGridViewTextBoxColumn";
            // 
            // tASKHOURSDataGridViewTextBoxColumn
            // 
            this.tASKHOURSDataGridViewTextBoxColumn.DataPropertyName = "TASK_HOURS";
            this.tASKHOURSDataGridViewTextBoxColumn.HeaderText = "TASK_HOURS";
            this.tASKHOURSDataGridViewTextBoxColumn.Name = "tASKHOURSDataGridViewTextBoxColumn";
            // 
            // Task_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.taskListGrid);
            this.Name = "Task_List";
            this.Text = "Task_List";
            this.Load += new System.EventHandler(this.Task_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.taskListGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECT_TASKSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView taskListGrid;
        private ProjectManagementDBDataSet projectManagementDBDataSet;
        private System.Windows.Forms.BindingSource pROJECT_TASKSBindingSource;
        private ProjectManagementDBDataSetTableAdapters.PROJECT_TASKSTableAdapter pROJECT_TASKSTableAdapter;
        private ProjectManagementDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn tASKIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXPRETIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tASKNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tASKDESCRIPTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tASDELIVERABLESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tASKBEGINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tASKENDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tASKPRIORITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tASKSTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tASKREADYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tASKHOURSDataGridViewTextBoxColumn;
    }
}