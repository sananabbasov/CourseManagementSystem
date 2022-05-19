using Business;
using Entities;
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
    public partial class GroupScreen : Form
    {
        GroupManager groupManager = new();
        TeacherManager teacherManager = new();
        ShiftManager shiftManager = new();
        public GroupScreen()
        {
            InitializeComponent();
        }
        public void DGVGroups()
        {
            dgvGroups.DataSource = groupManager.GetAllGroups().Select(x => new
            {
                ID = x.Id,
                Group_Name = x.Name,
                Shift = x.ShiftTime.Name,
                Teacher = x.User.Fullname
            }).ToList();
        }
        private void GroupScreen_Load(object sender, EventArgs e)
        {
            DGVGroups();
            var teachers = teacherManager.GetAllTeacher();
            foreach (var teacher in teachers)
            {
                cmbTeachers.Items.Add(teacher.Fullname);
            }
            var shifts = shiftManager.GetShiftTimes();
            foreach (var shift in shifts)
            {
                cmbShifts.Items.Add(shift.Name);
            }


        }

        

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            string groupName = txtGroupName.Text;
            string selectedTeacher = cmbTeachers.Text;
            string selectedShift = cmbShifts.Text;

            var teacher = teacherManager.GetTeacherByName(selectedTeacher);
            var shift = shiftManager.GetShiftByName(selectedShift);

            Group group = new()
            {
                Name = groupName,
                ShiftTimeId = shift.Id,
                UserId = teacher.Id
            };
            groupManager.AddGroup(group);

            txtGroupName.Text = "";
            cmbTeachers.Text = "";
            cmbShifts.Text = "";
            DGVGroups();
        }
    }
}
