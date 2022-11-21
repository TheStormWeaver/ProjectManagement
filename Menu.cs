using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagement
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void createUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User frm = new User();
            frm.ShowDialog();
        }

        private void viewUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_List frm = new User_List();
            frm.ShowDialog();
        }

        private void viewTasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task_List frm = new Task_List();
            frm.ShowDialog();
        }

        private void viewProjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Project_List frm = new Project_List();
            frm.ShowDialog();
        }

        private void createProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_Project frm = new Create_Project();
            frm.ShowDialog();
        }

        private void editTaskToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Create_Task frm2 = new Create_Task();
            frm2.ShowDialog();
        }
    }
}
