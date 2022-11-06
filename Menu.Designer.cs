namespace ProjectManagement
{
    partial class menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignUsersToTasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewProjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editProjectStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tasksToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.tasksToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewUsersToolStripMenuItem,
            this.createUserToolStripMenuItem,
            this.assignUsersToTasksToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // viewUsersToolStripMenuItem
            // 
            this.viewUsersToolStripMenuItem.Name = "viewUsersToolStripMenuItem";
            this.viewUsersToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.viewUsersToolStripMenuItem.Text = "View Users";
            // 
            // createUserToolStripMenuItem
            // 
            this.createUserToolStripMenuItem.Name = "createUserToolStripMenuItem";
            this.createUserToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.createUserToolStripMenuItem.Text = "Create User";
            this.createUserToolStripMenuItem.Click += new System.EventHandler(this.createUserToolStripMenuItem_Click);
            // 
            // assignUsersToTasksToolStripMenuItem
            // 
            this.assignUsersToTasksToolStripMenuItem.Name = "assignUsersToTasksToolStripMenuItem";
            this.assignUsersToTasksToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.assignUsersToTasksToolStripMenuItem.Text = "Assign Users to Tasks";
            // 
            // tasksToolStripMenuItem
            // 
            this.tasksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewProjectsToolStripMenuItem,
            this.createProjectToolStripMenuItem,
            this.editProjectStatusToolStripMenuItem,
            this.tasksToolStripMenuItem1});
            this.tasksToolStripMenuItem.Name = "tasksToolStripMenuItem";
            this.tasksToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.tasksToolStripMenuItem.Text = "Porjects";
            // 
            // viewProjectsToolStripMenuItem
            // 
            this.viewProjectsToolStripMenuItem.Name = "viewProjectsToolStripMenuItem";
            this.viewProjectsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewProjectsToolStripMenuItem.Text = "View Projects";
            // 
            // createProjectToolStripMenuItem
            // 
            this.createProjectToolStripMenuItem.Name = "createProjectToolStripMenuItem";
            this.createProjectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createProjectToolStripMenuItem.Text = "Create Project";
            // 
            // editProjectStatusToolStripMenuItem
            // 
            this.editProjectStatusToolStripMenuItem.Name = "editProjectStatusToolStripMenuItem";
            this.editProjectStatusToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editProjectStatusToolStripMenuItem.Text = "Edit Project Status";
            // 
            // tasksToolStripMenuItem1
            // 
            this.tasksToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewTasksToolStripMenuItem,
            this.editTaskToolStripMenuItem});
            this.tasksToolStripMenuItem1.Name = "tasksToolStripMenuItem1";
            this.tasksToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.tasksToolStripMenuItem1.Text = "Tasks";
            // 
            // viewTasksToolStripMenuItem
            // 
            this.viewTasksToolStripMenuItem.Name = "viewTasksToolStripMenuItem";
            this.viewTasksToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewTasksToolStripMenuItem.Text = "View Tasks";
            // 
            // editTaskToolStripMenuItem
            // 
            this.editTaskToolStripMenuItem.Name = "editTaskToolStripMenuItem";
            this.editTaskToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editTaskToolStripMenuItem.Text = "Edit Task";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menu";
            this.Text = "Main Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignUsersToTasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewProjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editProjectStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tasksToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewTasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editTaskToolStripMenuItem;
    }
}

