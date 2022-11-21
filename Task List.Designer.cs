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
            this.pROJECT_TASKSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectManagementDBDataSet = new ProjectManagement.ProjectManagementDBDataSet();
            this.pROJECT_TASKSTableAdapter = new ProjectManagement.ProjectManagementDBDataSetTableAdapters.PROJECT_TASKSTableAdapter();
            this.tableAdapterManager = new ProjectManagement.ProjectManagementDBDataSetTableAdapters.TableAdapterManager();
            this.taskCommentrt = new System.Windows.Forms.RichTextBox();
            this.taskCommentl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.taskListGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECT_TASKSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementDBDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.taskListGrid.Location = new System.Drawing.Point(31, 19);
            this.taskListGrid.Name = "taskListGrid";
            this.taskListGrid.Size = new System.Drawing.Size(943, 326);
            this.taskListGrid.TabIndex = 0;
            // 
            // tASKIDDataGridViewTextBoxColumn
            // 
            this.tASKIDDataGridViewTextBoxColumn.DataPropertyName = "TASK_ID";
            this.tASKIDDataGridViewTextBoxColumn.HeaderText = "TASK_ID";
            this.tASKIDDataGridViewTextBoxColumn.Name = "tASKIDDataGridViewTextBoxColumn";
            this.tASKIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // pROJECTIDDataGridViewTextBoxColumn
            // 
            this.pROJECTIDDataGridViewTextBoxColumn.DataPropertyName = "PROJECT_ID";
            this.pROJECTIDDataGridViewTextBoxColumn.HeaderText = "PROJECT_ID";
            this.pROJECTIDDataGridViewTextBoxColumn.Name = "pROJECTIDDataGridViewTextBoxColumn";
            this.pROJECTIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // eXPRETIDDataGridViewTextBoxColumn
            // 
            this.eXPRETIDDataGridViewTextBoxColumn.DataPropertyName = "EXPRET_ID";
            this.eXPRETIDDataGridViewTextBoxColumn.HeaderText = "EXPRET_ID";
            this.eXPRETIDDataGridViewTextBoxColumn.Name = "eXPRETIDDataGridViewTextBoxColumn";
            this.eXPRETIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // tASKNAMEDataGridViewTextBoxColumn
            // 
            this.tASKNAMEDataGridViewTextBoxColumn.DataPropertyName = "TASK_NAME";
            this.tASKNAMEDataGridViewTextBoxColumn.HeaderText = "Task Name";
            this.tASKNAMEDataGridViewTextBoxColumn.Name = "tASKNAMEDataGridViewTextBoxColumn";
            // 
            // tASKDESCRIPTIONDataGridViewTextBoxColumn
            // 
            this.tASKDESCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "TASK_DESCRIPTION";
            this.tASKDESCRIPTIONDataGridViewTextBoxColumn.HeaderText = "Task Description";
            this.tASKDESCRIPTIONDataGridViewTextBoxColumn.Name = "tASKDESCRIPTIONDataGridViewTextBoxColumn";
            // 
            // tASDELIVERABLESDataGridViewTextBoxColumn
            // 
            this.tASDELIVERABLESDataGridViewTextBoxColumn.DataPropertyName = "TAS_DELIVERABLES";
            this.tASDELIVERABLESDataGridViewTextBoxColumn.HeaderText = "Result Format";
            this.tASDELIVERABLESDataGridViewTextBoxColumn.Name = "tASDELIVERABLESDataGridViewTextBoxColumn";
            // 
            // tASKBEGINDataGridViewTextBoxColumn
            // 
            this.tASKBEGINDataGridViewTextBoxColumn.DataPropertyName = "TASK_BEGIN";
            this.tASKBEGINDataGridViewTextBoxColumn.HeaderText = "Start Date";
            this.tASKBEGINDataGridViewTextBoxColumn.Name = "tASKBEGINDataGridViewTextBoxColumn";
            // 
            // tASKENDDataGridViewTextBoxColumn
            // 
            this.tASKENDDataGridViewTextBoxColumn.DataPropertyName = "TASK_END";
            this.tASKENDDataGridViewTextBoxColumn.HeaderText = "End Date";
            this.tASKENDDataGridViewTextBoxColumn.Name = "tASKENDDataGridViewTextBoxColumn";
            // 
            // tASKPRIORITYDataGridViewTextBoxColumn
            // 
            this.tASKPRIORITYDataGridViewTextBoxColumn.DataPropertyName = "TASK_PRIORITY";
            this.tASKPRIORITYDataGridViewTextBoxColumn.HeaderText = "Priority";
            this.tASKPRIORITYDataGridViewTextBoxColumn.Name = "tASKPRIORITYDataGridViewTextBoxColumn";
            // 
            // tASKSTATUSDataGridViewTextBoxColumn
            // 
            this.tASKSTATUSDataGridViewTextBoxColumn.DataPropertyName = "TASK_STATUS";
            this.tASKSTATUSDataGridViewTextBoxColumn.HeaderText = "Status";
            this.tASKSTATUSDataGridViewTextBoxColumn.Name = "tASKSTATUSDataGridViewTextBoxColumn";
            // 
            // tASKREADYDataGridViewTextBoxColumn
            // 
            this.tASKREADYDataGridViewTextBoxColumn.DataPropertyName = "TASK_READY";
            this.tASKREADYDataGridViewTextBoxColumn.HeaderText = "Progress";
            this.tASKREADYDataGridViewTextBoxColumn.Name = "tASKREADYDataGridViewTextBoxColumn";
            // 
            // tASKHOURSDataGridViewTextBoxColumn
            // 
            this.tASKHOURSDataGridViewTextBoxColumn.DataPropertyName = "TASK_HOURS";
            this.tASKHOURSDataGridViewTextBoxColumn.HeaderText = "Hours";
            this.tASKHOURSDataGridViewTextBoxColumn.Name = "tASKHOURSDataGridViewTextBoxColumn";
            // 
            // pROJECT_TASKSBindingSource
            // 
            this.pROJECT_TASKSBindingSource.DataMember = "PROJECT_TASKS";
            this.pROJECT_TASKSBindingSource.DataSource = this.projectManagementDBDataSet;
            // 
            // projectManagementDBDataSet
            // 
            this.projectManagementDBDataSet.DataSetName = "ProjectManagementDBDataSet";
            this.projectManagementDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // taskCommentrt
            // 
            this.taskCommentrt.Location = new System.Drawing.Point(26, 102);
            this.taskCommentrt.Name = "taskCommentrt";
            this.taskCommentrt.Size = new System.Drawing.Size(260, 96);
            this.taskCommentrt.TabIndex = 22;
            this.taskCommentrt.Text = "";
            // 
            // taskCommentl
            // 
            this.taskCommentl.AutoSize = true;
            this.taskCommentl.Location = new System.Drawing.Point(23, 77);
            this.taskCommentl.Name = "taskCommentl";
            this.taskCommentl.Size = new System.Drawing.Size(51, 13);
            this.taskCommentl.TabIndex = 21;
            this.taskCommentl.Text = "Comment";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.taskCommentl);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.taskCommentrt);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Location = new System.Drawing.Point(1013, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 332);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Last Updated";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 28);
            this.button1.TabIndex = 23;
            this.button1.Text = "Add Update";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(185, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Hours";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Contributor";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(188, 244);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(97, 20);
            this.textBox2.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Task";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(26, 44);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(231, 21);
            this.comboBox3.TabIndex = 15;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(26, 244);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(134, 21);
            this.comboBox4.TabIndex = 17;
            // 
            // Task_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 361);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.taskListGrid);
            this.Name = "Task_List";
            this.Text = "Task_List";
            this.Load += new System.EventHandler(this.Task_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.taskListGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECT_TASKSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementDBDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView taskListGrid;
        private ProjectManagementDBDataSet projectManagementDBDataSet;
        private System.Windows.Forms.BindingSource pROJECT_TASKSBindingSource;
        private ProjectManagementDBDataSetTableAdapters.PROJECT_TASKSTableAdapter pROJECT_TASKSTableAdapter;
        private ProjectManagementDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.RichTextBox taskCommentrt;
        private System.Windows.Forms.Label taskCommentl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
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