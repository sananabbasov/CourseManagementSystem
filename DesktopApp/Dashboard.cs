using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            StudentScreen student = new();
            student.ShowDialog();
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            TeacherScreen teacher = new();
            teacher.ShowDialog();
        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            RoleScreen role = new();
            role.ShowDialog();
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            GroupScreen group = new();
            group.ShowDialog();
        }
    }
}
