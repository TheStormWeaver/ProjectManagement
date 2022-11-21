namespace ProjectManagement
{
    partial class Edit_Project_Status
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
            System.Windows.Forms.Label pSTATUS_IDLabel;
            System.Windows.Forms.Label pSTATUS_NAMELabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_Project_Status));
            this.projectManagementDBDataSet = new ProjectManagement.ProjectManagementDBDataSet();
            this.pROJECT_STATUSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROJECT_STATUSTableAdapter = new ProjectManagement.ProjectManagementDBDataSetTableAdapters.PROJECT_STATUSTableAdapter();
            this.tableAdapterManager = new ProjectManagement.ProjectManagementDBDataSetTableAdapters.TableAdapterManager();
            this.pROJECT_STATUSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pROJECT_STATUSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pSTATUS_IDTextBox = new System.Windows.Forms.TextBox();
            this.pSTATUS_NAMETextBox = new System.Windows.Forms.TextBox();
            this.projectStatusSavebtn = new System.Windows.Forms.Button();
            this.projectStatusCancelbtn = new System.Windows.Forms.Button();
            pSTATUS_IDLabel = new System.Windows.Forms.Label();
            pSTATUS_NAMELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECT_STATUSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECT_STATUSBindingNavigator)).BeginInit();
            this.pROJECT_STATUSBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // pSTATUS_IDLabel
            // 
            pSTATUS_IDLabel.AutoSize = true;
            pSTATUS_IDLabel.Location = new System.Drawing.Point(51, 68);
            pSTATUS_IDLabel.Name = "pSTATUS_IDLabel";
            pSTATUS_IDLabel.Size = new System.Drawing.Size(74, 13);
            pSTATUS_IDLabel.TabIndex = 1;
            pSTATUS_IDLabel.Text = "PSTATUS ID:";
            // 
            // pSTATUS_NAMELabel
            // 
            pSTATUS_NAMELabel.AutoSize = true;
            pSTATUS_NAMELabel.Location = new System.Drawing.Point(51, 94);
            pSTATUS_NAMELabel.Name = "pSTATUS_NAMELabel";
            pSTATUS_NAMELabel.Size = new System.Drawing.Size(94, 13);
            pSTATUS_NAMELabel.TabIndex = 3;
            pSTATUS_NAMELabel.Text = "PSTATUS NAME:";
            // 
            // projectManagementDBDataSet
            // 
            this.projectManagementDBDataSet.DataSetName = "ProjectManagementDBDataSet";
            this.projectManagementDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pROJECT_STATUSBindingSource
            // 
            this.pROJECT_STATUSBindingSource.DataMember = "PROJECT_STATUS";
            this.pROJECT_STATUSBindingSource.DataSource = this.projectManagementDBDataSet;
            // 
            // pROJECT_STATUSTableAdapter
            // 
            this.pROJECT_STATUSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EXPERTSTableAdapter = null;
            this.tableAdapterManager.PROJECT_STATUSTableAdapter = this.pROJECT_STATUSTableAdapter;
            this.tableAdapterManager.PROJECT_TASKSTableAdapter = null;
            this.tableAdapterManager.PROJECTSTableAdapter = null;
            this.tableAdapterManager.TASK_STATUSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjectManagement.ProjectManagementDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pROJECT_STATUSBindingNavigator
            // 
            this.pROJECT_STATUSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pROJECT_STATUSBindingNavigator.BindingSource = this.pROJECT_STATUSBindingSource;
            this.pROJECT_STATUSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pROJECT_STATUSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pROJECT_STATUSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.pROJECT_STATUSBindingNavigatorSaveItem});
            this.pROJECT_STATUSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pROJECT_STATUSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pROJECT_STATUSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pROJECT_STATUSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pROJECT_STATUSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pROJECT_STATUSBindingNavigator.Name = "pROJECT_STATUSBindingNavigator";
            this.pROJECT_STATUSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pROJECT_STATUSBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.pROJECT_STATUSBindingNavigator.TabIndex = 0;
            this.pROJECT_STATUSBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // pROJECT_STATUSBindingNavigatorSaveItem
            // 
            this.pROJECT_STATUSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pROJECT_STATUSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pROJECT_STATUSBindingNavigatorSaveItem.Image")));
            this.pROJECT_STATUSBindingNavigatorSaveItem.Name = "pROJECT_STATUSBindingNavigatorSaveItem";
            this.pROJECT_STATUSBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pROJECT_STATUSBindingNavigatorSaveItem.Text = "Save Data";
            this.pROJECT_STATUSBindingNavigatorSaveItem.Click += new System.EventHandler(this.pROJECT_STATUSBindingNavigatorSaveItem_Click);
            // 
            // pSTATUS_IDTextBox
            // 
            this.pSTATUS_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pROJECT_STATUSBindingSource, "PSTATUS_ID", true));
            this.pSTATUS_IDTextBox.Location = new System.Drawing.Point(151, 65);
            this.pSTATUS_IDTextBox.Name = "pSTATUS_IDTextBox";
            this.pSTATUS_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.pSTATUS_IDTextBox.TabIndex = 2;
            // 
            // pSTATUS_NAMETextBox
            // 
            this.pSTATUS_NAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pROJECT_STATUSBindingSource, "PSTATUS_NAME", true));
            this.pSTATUS_NAMETextBox.Location = new System.Drawing.Point(151, 91);
            this.pSTATUS_NAMETextBox.Name = "pSTATUS_NAMETextBox";
            this.pSTATUS_NAMETextBox.Size = new System.Drawing.Size(100, 20);
            this.pSTATUS_NAMETextBox.TabIndex = 4;
            // 
            // projectStatusSavebtn
            // 
            this.projectStatusSavebtn.Location = new System.Drawing.Point(54, 163);
            this.projectStatusSavebtn.Name = "projectStatusSavebtn";
            this.projectStatusSavebtn.Size = new System.Drawing.Size(75, 23);
            this.projectStatusSavebtn.TabIndex = 5;
            this.projectStatusSavebtn.Text = "Save";
            this.projectStatusSavebtn.UseVisualStyleBackColor = true;
            this.projectStatusSavebtn.Click += new System.EventHandler(this.projectStatusSavebtn_Click);
            // 
            // projectStatusCancelbtn
            // 
            this.projectStatusCancelbtn.Location = new System.Drawing.Point(151, 163);
            this.projectStatusCancelbtn.Name = "projectStatusCancelbtn";
            this.projectStatusCancelbtn.Size = new System.Drawing.Size(75, 23);
            this.projectStatusCancelbtn.TabIndex = 6;
            this.projectStatusCancelbtn.Text = "Cancel";
            this.projectStatusCancelbtn.UseVisualStyleBackColor = true;
            this.projectStatusCancelbtn.Click += new System.EventHandler(this.projectStatusCancelbtn_Click);
            // 
            // Edit_Project_Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.projectStatusCancelbtn);
            this.Controls.Add(this.projectStatusSavebtn);
            this.Controls.Add(pSTATUS_IDLabel);
            this.Controls.Add(this.pSTATUS_IDTextBox);
            this.Controls.Add(pSTATUS_NAMELabel);
            this.Controls.Add(this.pSTATUS_NAMETextBox);
            this.Controls.Add(this.pROJECT_STATUSBindingNavigator);
            this.Name = "Edit_Project_Status";
            this.Text = "Edit_Project_Status";
            this.Load += new System.EventHandler(this.Edit_Project_Status_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECT_STATUSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECT_STATUSBindingNavigator)).EndInit();
            this.pROJECT_STATUSBindingNavigator.ResumeLayout(false);
            this.pROJECT_STATUSBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProjectManagementDBDataSet projectManagementDBDataSet;
        private System.Windows.Forms.BindingSource pROJECT_STATUSBindingSource;
        private ProjectManagementDBDataSetTableAdapters.PROJECT_STATUSTableAdapter pROJECT_STATUSTableAdapter;
        private ProjectManagementDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pROJECT_STATUSBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton pROJECT_STATUSBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox pSTATUS_IDTextBox;
        private System.Windows.Forms.TextBox pSTATUS_NAMETextBox;
        private System.Windows.Forms.Button projectStatusSavebtn;
        private System.Windows.Forms.Button projectStatusCancelbtn;
    }
}