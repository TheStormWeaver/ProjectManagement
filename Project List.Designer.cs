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
            this.pROJECTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECTDESCRIPTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECTCLIENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECTBEGINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECTENDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECTSTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECTPAYPERHOURDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editProjectStatus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pROJECTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectManagementDBDataSet = new ProjectManagement.ProjectManagementDBDataSet();
            this.projectNameSearchl = new System.Windows.Forms.Label();
            this.projectNameSearcht = new System.Windows.Forms.TextBox();
            this.projectIDSearchl = new System.Windows.Forms.Label();
            this.projectIDSearcht = new System.Windows.Forms.TextBox();
            this.searchProjectbtn = new System.Windows.Forms.Button();
            this.projectUserSearchl = new System.Windows.Forms.Label();
            this.projectStartDateSearchl = new System.Windows.Forms.Label();
            this.projectStartDateSearcht = new System.Windows.Forms.TextBox();
            this.projectStatusSearchl = new System.Windows.Forms.Label();
            this.projectEndDatel = new System.Windows.Forms.Label();
            this.projectEndDateSearcht = new System.Windows.Forms.TextBox();
            this.pROJECTSTableAdapter = new ProjectManagement.ProjectManagementDBDataSetTableAdapters.PROJECTSTableAdapter();
            this.tableAdapterManager = new ProjectManagement.ProjectManagementDBDataSetTableAdapters.TableAdapterManager();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.projectStatusSearchcb = new System.Windows.Forms.ComboBox();
            this.projectUserSearchcb = new System.Windows.Forms.ComboBox();
            this.pROJECTSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pROJECTSListBox = new System.Windows.Forms.ListBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ProjectCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.projectListGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementDBDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTSBindingSource1)).BeginInit();
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
            this.pROJECTPAYPERHOURDataGridViewTextBoxColumn,
            this.editProjectStatus});
            this.projectListGrid.DataSource = this.pROJECTSBindingSource;
            this.projectListGrid.Location = new System.Drawing.Point(25, 17);
            this.projectListGrid.Name = "projectListGrid";
            this.projectListGrid.Size = new System.Drawing.Size(947, 256);
            this.projectListGrid.TabIndex = 0;
            this.projectListGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.projectListGrid_CellContentClick);
            // 
            // pROJECTIDDataGridViewTextBoxColumn
            // 
            this.pROJECTIDDataGridViewTextBoxColumn.DataPropertyName = "PROJECT_ID";
            this.pROJECTIDDataGridViewTextBoxColumn.HeaderText = "Project Code";
            this.pROJECTIDDataGridViewTextBoxColumn.Name = "pROJECTIDDataGridViewTextBoxColumn";
            // 
            // pROJECTNAMEDataGridViewTextBoxColumn
            // 
            this.pROJECTNAMEDataGridViewTextBoxColumn.DataPropertyName = "PROJECT_NAME";
            this.pROJECTNAMEDataGridViewTextBoxColumn.HeaderText = "Name";
            this.pROJECTNAMEDataGridViewTextBoxColumn.Name = "pROJECTNAMEDataGridViewTextBoxColumn";
            // 
            // pROJECTDESCRIPTIONDataGridViewTextBoxColumn
            // 
            this.pROJECTDESCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "PROJECT_DESCRIPTION";
            this.pROJECTDESCRIPTIONDataGridViewTextBoxColumn.HeaderText = "Description";
            this.pROJECTDESCRIPTIONDataGridViewTextBoxColumn.Name = "pROJECTDESCRIPTIONDataGridViewTextBoxColumn";
            // 
            // pROJECTCLIENTDataGridViewTextBoxColumn
            // 
            this.pROJECTCLIENTDataGridViewTextBoxColumn.DataPropertyName = "PROJECT_CLIENT";
            this.pROJECTCLIENTDataGridViewTextBoxColumn.HeaderText = "Client";
            this.pROJECTCLIENTDataGridViewTextBoxColumn.Name = "pROJECTCLIENTDataGridViewTextBoxColumn";
            // 
            // pROJECTBEGINDataGridViewTextBoxColumn
            // 
            this.pROJECTBEGINDataGridViewTextBoxColumn.DataPropertyName = "PROJECT_BEGIN";
            this.pROJECTBEGINDataGridViewTextBoxColumn.HeaderText = "Start Date";
            this.pROJECTBEGINDataGridViewTextBoxColumn.Name = "pROJECTBEGINDataGridViewTextBoxColumn";
            // 
            // pROJECTENDDataGridViewTextBoxColumn
            // 
            this.pROJECTENDDataGridViewTextBoxColumn.DataPropertyName = "PROJECT_END";
            this.pROJECTENDDataGridViewTextBoxColumn.HeaderText = "End Date";
            this.pROJECTENDDataGridViewTextBoxColumn.Name = "pROJECTENDDataGridViewTextBoxColumn";
            // 
            // pROJECTSTATUSDataGridViewTextBoxColumn
            // 
            this.pROJECTSTATUSDataGridViewTextBoxColumn.DataPropertyName = "PROJECT_STATUS";
            this.pROJECTSTATUSDataGridViewTextBoxColumn.HeaderText = "Status";
            this.pROJECTSTATUSDataGridViewTextBoxColumn.Name = "pROJECTSTATUSDataGridViewTextBoxColumn";
            // 
            // pROJECTPAYPERHOURDataGridViewTextBoxColumn
            // 
            this.pROJECTPAYPERHOURDataGridViewTextBoxColumn.DataPropertyName = "PROJECT_PAY_PER_HOUR";
            this.pROJECTPAYPERHOURDataGridViewTextBoxColumn.HeaderText = "Pay Per Hour";
            this.pROJECTPAYPERHOURDataGridViewTextBoxColumn.Name = "pROJECTPAYPERHOURDataGridViewTextBoxColumn";
            // 
            // editProjectStatus
            // 
            this.editProjectStatus.DataPropertyName = "PROJECT_STATUS";
            this.editProjectStatus.HeaderText = "Edit Project Status";
            this.editProjectStatus.Name = "editProjectStatus";
            // 
            // pROJECTSBindingSource
            // 
            this.pROJECTSBindingSource.DataMember = "PROJECTS";
            this.pROJECTSBindingSource.DataSource = this.projectManagementDBDataSet;
            // 
            // projectManagementDBDataSet
            // 
            this.projectManagementDBDataSet.DataSetName = "ProjectManagementDBDataSet";
            this.projectManagementDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectNameSearchl
            // 
            this.projectNameSearchl.AutoSize = true;
            this.projectNameSearchl.Location = new System.Drawing.Point(199, 23);
            this.projectNameSearchl.Name = "projectNameSearchl";
            this.projectNameSearchl.Size = new System.Drawing.Size(35, 13);
            this.projectNameSearchl.TabIndex = 7;
            this.projectNameSearchl.Text = "Name";
            // 
            // projectNameSearcht
            // 
            this.projectNameSearcht.Location = new System.Drawing.Point(202, 49);
            this.projectNameSearcht.Name = "projectNameSearcht";
            this.projectNameSearcht.Size = new System.Drawing.Size(117, 20);
            this.projectNameSearcht.TabIndex = 6;
            // 
            // projectIDSearchl
            // 
            this.projectIDSearchl.AutoSize = true;
            this.projectIDSearchl.Location = new System.Drawing.Point(46, 23);
            this.projectIDSearchl.Name = "projectIDSearchl";
            this.projectIDSearchl.Size = new System.Drawing.Size(68, 13);
            this.projectIDSearchl.TabIndex = 5;
            this.projectIDSearchl.Text = "Project Code";
            // 
            // projectIDSearcht
            // 
            this.projectIDSearcht.Location = new System.Drawing.Point(49, 49);
            this.projectIDSearcht.Name = "projectIDSearcht";
            this.projectIDSearcht.Size = new System.Drawing.Size(118, 20);
            this.projectIDSearcht.TabIndex = 4;
            // 
            // searchProjectbtn
            // 
            this.searchProjectbtn.BackColor = System.Drawing.Color.Transparent;
            this.searchProjectbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchProjectbtn.ForeColor = System.Drawing.Color.Black;
            this.searchProjectbtn.Location = new System.Drawing.Point(49, 211);
            this.searchProjectbtn.Name = "searchProjectbtn";
            this.searchProjectbtn.Size = new System.Drawing.Size(121, 29);
            this.searchProjectbtn.TabIndex = 8;
            this.searchProjectbtn.Text = "Search Projects";
            this.searchProjectbtn.UseVisualStyleBackColor = false;
            this.searchProjectbtn.Click += new System.EventHandler(this.searchProjectbtn_Click);
            // 
            // projectUserSearchl
            // 
            this.projectUserSearchl.AutoSize = true;
            this.projectUserSearchl.Location = new System.Drawing.Point(46, 144);
            this.projectUserSearchl.Name = "projectUserSearchl";
            this.projectUserSearchl.Size = new System.Drawing.Size(83, 13);
            this.projectUserSearchl.TabIndex = 10;
            this.projectUserSearchl.Text = "Assinged Expert";
            // 
            // projectStartDateSearchl
            // 
            this.projectStartDateSearchl.AutoSize = true;
            this.projectStartDateSearchl.Location = new System.Drawing.Point(46, 84);
            this.projectStartDateSearchl.Name = "projectStartDateSearchl";
            this.projectStartDateSearchl.Size = new System.Drawing.Size(58, 13);
            this.projectStartDateSearchl.TabIndex = 12;
            this.projectStartDateSearchl.Text = "Starrt Date";
            // 
            // projectStartDateSearcht
            // 
            this.projectStartDateSearcht.Location = new System.Drawing.Point(49, 106);
            this.projectStartDateSearcht.Name = "projectStartDateSearcht";
            this.projectStartDateSearcht.Size = new System.Drawing.Size(118, 20);
            this.projectStartDateSearcht.TabIndex = 11;
            // 
            // projectStatusSearchl
            // 
            this.projectStatusSearchl.AutoSize = true;
            this.projectStatusSearchl.Location = new System.Drawing.Point(345, 23);
            this.projectStatusSearchl.Name = "projectStatusSearchl";
            this.projectStatusSearchl.Size = new System.Drawing.Size(37, 13);
            this.projectStatusSearchl.TabIndex = 14;
            this.projectStatusSearchl.Text = "Status";
            // 
            // projectEndDatel
            // 
            this.projectEndDatel.AutoSize = true;
            this.projectEndDatel.Location = new System.Drawing.Point(199, 84);
            this.projectEndDatel.Name = "projectEndDatel";
            this.projectEndDatel.Size = new System.Drawing.Size(52, 13);
            this.projectEndDatel.TabIndex = 16;
            this.projectEndDatel.Text = "End Date";
            // 
            // projectEndDateSearcht
            // 
            this.projectEndDateSearcht.Location = new System.Drawing.Point(202, 106);
            this.projectEndDateSearcht.Name = "projectEndDateSearcht";
            this.projectEndDateSearcht.Size = new System.Drawing.Size(117, 20);
            this.projectEndDateSearcht.TabIndex = 15;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.projectStatusSearchcb);
            this.groupBox1.Controls.Add(this.searchProjectbtn);
            this.groupBox1.Controls.Add(this.projectUserSearchcb);
            this.groupBox1.Controls.Add(this.projectNameSearchl);
            this.groupBox1.Controls.Add(this.projectStatusSearchl);
            this.groupBox1.Controls.Add(this.projectEndDatel);
            this.groupBox1.Controls.Add(this.projectNameSearcht);
            this.groupBox1.Controls.Add(this.projectStartDateSearchl);
            this.groupBox1.Controls.Add(this.projectEndDateSearcht);
            this.groupBox1.Controls.Add(this.projectStartDateSearcht);
            this.groupBox1.Controls.Add(this.projectUserSearchl);
            this.groupBox1.Controls.Add(this.projectIDSearchl);
            this.groupBox1.Controls.Add(this.projectIDSearcht);
            this.groupBox1.Location = new System.Drawing.Point(1017, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 261);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Projects";
            // 
            // projectStatusSearchcb
            // 
            this.projectStatusSearchcb.FormattingEnabled = true;
            this.projectStatusSearchcb.Location = new System.Drawing.Point(348, 49);
            this.projectStatusSearchcb.Name = "projectStatusSearchcb";
            this.projectStatusSearchcb.Size = new System.Drawing.Size(81, 21);
            this.projectStatusSearchcb.TabIndex = 18;
            // 
            // projectUserSearchcb
            // 
            this.projectUserSearchcb.FormattingEnabled = true;
            this.projectUserSearchcb.Location = new System.Drawing.Point(49, 166);
            this.projectUserSearchcb.Name = "projectUserSearchcb";
            this.projectUserSearchcb.Size = new System.Drawing.Size(121, 21);
            this.projectUserSearchcb.TabIndex = 17;
            // 
            // pROJECTSBindingSource1
            // 
            this.pROJECTSBindingSource1.DataMember = "PROJECTS";
            this.pROJECTSBindingSource1.DataSource = this.projectManagementDBDataSet;
            // 
            // pROJECTSListBox
            // 
            this.pROJECTSListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pROJECTSBindingSource1, "PROJECT_BEGIN", true));
            this.pROJECTSListBox.DataSource = this.pROJECTSBindingSource1;
            this.pROJECTSListBox.DisplayMember = "PROJECT_DESCRIPTION";
            this.pROJECTSListBox.FormattingEnabled = true;
            this.pROJECTSListBox.Location = new System.Drawing.Point(25, 303);
            this.pROJECTSListBox.Name = "pROJECTSListBox";
            this.pROJECTSListBox.Size = new System.Drawing.Size(947, 212);
            this.pROJECTSListBox.TabIndex = 18;
            this.pROJECTSListBox.ValueMember = "PROJECT_NAME";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProjectCode});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(1017, 303);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(547, 221);
            this.listView1.TabIndex = 19;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ProjectCode
            // 
            this.ProjectCode.Text = "Project Code";
            // 
            // Project_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 596);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pROJECTSListBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.projectListGrid);
            this.Name = "Project_List";
            this.Text = "Project_List";
            this.Load += new System.EventHandler(this.Project_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectListGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementDBDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTSBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView projectListGrid;
        private ProjectManagementDBDataSet projectManagementDBDataSet;
        private System.Windows.Forms.BindingSource pROJECTSBindingSource;
        private ProjectManagementDBDataSetTableAdapters.PROJECTSTableAdapter pROJECTSTableAdapter;
        private ProjectManagementDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label projectNameSearchl;
        private System.Windows.Forms.TextBox projectNameSearcht;
        private System.Windows.Forms.Label projectIDSearchl;
        private System.Windows.Forms.TextBox projectIDSearcht;
        private System.Windows.Forms.Button searchProjectbtn;
        private System.Windows.Forms.Label projectUserSearchl;
        private System.Windows.Forms.Label projectStartDateSearchl;
        private System.Windows.Forms.TextBox projectStartDateSearcht;
        private System.Windows.Forms.Label projectStatusSearchl;
        private System.Windows.Forms.Label projectEndDatel;
        private System.Windows.Forms.TextBox projectEndDateSearcht;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox projectStatusSearchcb;
        private System.Windows.Forms.ComboBox projectUserSearchcb;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTDESCRIPTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTCLIENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTBEGINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTENDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTSTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTPAYPERHOURDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn editProjectStatus;
        private System.Windows.Forms.BindingSource pROJECTSBindingSource1;
        private System.Windows.Forms.ListBox pROJECTSListBox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ProjectCode;
    }
}