namespace ProjectManagement
{
    partial class Project_List
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
            this.projectListGrid = new System.Windows.Forms.DataGridView();
            this.projectManagementDBDataSet = new ProjectManagement.ProjectManagementDBDataSet();
            this.pROJECTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROJECTSTableAdapter = new ProjectManagement.ProjectManagementDBDataSetTableAdapters.PROJECTSTableAdapter();
            this.tableAdapterManager = new ProjectManagement.ProjectManagementDBDataSetTableAdapters.TableAdapterManager();
            this.pROJECTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECTDESCRIPTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECTCLIENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECTBEGINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECTENDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECTSTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECTPAYPERHOURDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.projectListGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // projectListGrid
            // 
            this.projectListGrid.AutoGenerateColumns = false;
            this.projectListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectListGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pROJECTIDDataGridViewTextBoxColumn,
            this.pROJECTNAMEDataGridViewTextBoxColumn,
            this.pROJECTDESCRIPTIONDataGridViewTextBoxColumn,
            this.pROJECTCLIENTDataGridViewTextBoxColumn,
            this.pROJECTBEGINDataGridViewTextBoxColumn,
            this.pROJECTENDDataGridViewTextBoxColumn,
            this.pROJECTSTATUSDataGridViewTextBoxColumn,
            this.pROJECTPAYPERHOURDataGridViewTextBoxColumn});
            this.projectListGrid.DataSource = this.pROJECTSBindingSource;
            this.projectListGrid.Location = new System.Drawing.Point(0, -1);
            this.projectListGrid.Name = "projectListGrid";
            this.projectListGrid.Size = new System.Drawing.Size(852, 457);
            this.projectListGrid.TabIndex = 0;
            // 
            // projectManagementDBDataSet
            // 
            this.projectManagementDBDataSet.DataSetName = "ProjectManagementDBDataSet";
            this.projectManagementDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pROJECTSBindingSource
            // 
            this.pROJECTSBindingSource.DataMember = "PROJECTS";
            this.pROJECTSBindingSource.DataSource = this.projectManagementDBDataSet;
            // 
            // pROJECTSTableAdapter
            // 
            this.pROJECTSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EXPERTSTableAdapter = null;
            this.tableAdapterManager.PROJECT_STATUSTableAdapter = null;
            this.tableAdapterManager.PROJECT_TASKSTableAdapter = null;
            this.tableAdapterManager.PROJECTSTableAdapter = this.pROJECTSTableAdapter;
            this.tableAdapterManager.TASK_STATUSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjectManagement.ProjectManagementDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pROJECTIDDataGridViewTextBoxColumn
            // 
            this.pROJECTIDDataGridViewTextBoxColumn.DataPropertyName = "PROJECT_ID";
            this.pROJECTIDDataGridViewTextBoxColumn.HeaderText = "PROJECT_ID";
            this.pROJECTIDDataGridViewTextBoxColumn.Name = "pROJECTIDDataGridViewTextBoxColumn";
            // 
            // pROJECTNAMEDataGridViewTextBoxColumn
            // 
            this.pROJECTNAMEDataGridViewTextBoxColumn.DataPropertyName = "PROJECT_NAME";
            this.pROJECTNAMEDataGridViewTextBoxColumn.HeaderText = "PROJECT_NAME";
            this.pROJECTNAMEDataGridViewTextBoxColumn.Name = "pROJECTNAMEDataGridViewTextBoxColumn";
            // 
            // pROJECTDESCRIPTIONDataGridViewTextBoxColumn
            // 
            this.pROJECTDESCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "PROJECT_DESCRIPTION";
            this.pROJECTDESCRIPTIONDataGridViewTextBoxColumn.HeaderText = "PROJECT_DESCRIPTION";
            this.pROJECTDESCRIPTIONDataGridViewTextBoxColumn.Name = "pROJECTDESCRIPTIONDataGridViewTextBoxColumn";
            // 
            // pROJECTCLIENTDataGridViewTextBoxColumn
            // 
            this.pROJECTCLIENTDataGridViewTextBoxColumn.DataPropertyName = "PROJECT_CLIENT";
            this.pROJECTCLIENTDataGridViewTextBoxColumn.HeaderText = "PROJECT_CLIENT";
            this.pROJECTCLIENTDataGridViewTextBoxColumn.Name = "pROJECTCLIENTDataGridViewTextBoxColumn";
            // 
            // pROJECTBEGINDataGridViewTextBoxColumn
            // 
            this.pROJECTBEGINDataGridViewTextBoxColumn.DataPropertyName = "PROJECT_BEGIN";
            this.pROJECTBEGINDataGridViewTextBoxColumn.HeaderText = "PROJECT_BEGIN";
            this.pROJECTBEGINDataGridViewTextBoxColumn.Name = "pROJECTBEGINDataGridViewTextBoxColumn";
            // 
            // pROJECTENDDataGridViewTextBoxColumn
            // 
            this.pROJECTENDDataGridViewTextBoxColumn.DataPropertyName = "PROJECT_END";
            this.pROJECTENDDataGridViewTextBoxColumn.HeaderText = "PROJECT_END";
            this.pROJECTENDDataGridViewTextBoxColumn.Name = "pROJECTENDDataGridViewTextBoxColumn";
            // 
            // pROJECTSTATUSDataGridViewTextBoxColumn
            // 
            this.pROJECTSTATUSDataGridViewTextBoxColumn.DataPropertyName = "PROJECT_STATUS";
            this.pROJECTSTATUSDataGridViewTextBoxColumn.HeaderText = "PROJECT_STATUS";
            this.pROJECTSTATUSDataGridViewTextBoxColumn.Name = "pROJECTSTATUSDataGridViewTextBoxColumn";
            // 
            // pROJECTPAYPERHOURDataGridViewTextBoxColumn
            // 
            this.pROJECTPAYPERHOURDataGridViewTextBoxColumn.DataPropertyName = "PROJECT_PAY_PER_HOUR";
            this.pROJECTPAYPERHOURDataGridViewTextBoxColumn.HeaderText = "PROJECT_PAY_PER_HOUR";
            this.pROJECTPAYPERHOURDataGridViewTextBoxColumn.Name = "pROJECTPAYPERHOURDataGridViewTextBoxColumn";
            // 
            // Project_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 450);
            this.Controls.Add(this.projectListGrid);
            this.Name = "Project_List";
            this.Text = "Project_List";
            this.Load += new System.EventHandler(this.Project_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectListGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView projectListGrid;
        private ProjectManagementDBDataSet projectManagementDBDataSet;
        private System.Windows.Forms.BindingSource pROJECTSBindingSource;
        private ProjectManagementDBDataSetTableAdapters.PROJECTSTableAdapter pROJECTSTableAdapter;
        private ProjectManagementDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTDESCRIPTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTCLIENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTBEGINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTENDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTSTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTPAYPERHOURDataGridViewTextBoxColumn;
    }
}