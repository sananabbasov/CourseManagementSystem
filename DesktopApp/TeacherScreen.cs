using Business;
using DataAccess;
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
    public partial class TeacherScreen : Form
    {
        TeacherManager teacherManager = new();


        public TeacherScreen()
        {
            InitializeComponent();
        }

        public void FillTeacherDGW()
        {
            dgwTeachers.DataSource = teacherManager.GetAllTeacher();
            dgwTeachers.Columns[2].Visible = false; // sehf usul
            dgwTeachers.Columns[3].Visible = false; // sehf usul
            dgwTeachers.Columns[4].Visible = false; // sehf usul
            dgwTeachers.Columns[5].Visible = false; // sehf usul
            dgwTeachers.Columns[6].Visible = false; // sehf usul
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var fullname = txtFullname.Text;
            var email = txtEmail.Text;
            var password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(fullname) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("* inputs is required!");
            }
            else
            {
                User user = new()
                {
                    Fullname = fullname,
                    Email = email,
                    Password = password,
                };

                teacherManager.AddTeacher(user);
                MessageBox.Show("Teacher is added.");
                txtFullname.Text = "";
                txtEmail.Text = "";
                txtPassword.Text = "";

                FillTeacherDGW();
            }
        }

        private void TeacherScreen_Load(object sender, EventArgs e)
        {
            FillTeacherDGW();
        }

        private void dgwTeachers_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int userId = (int)dgwTeachers.Rows[e.RowIndex].Cells[6].Value;
            txtId.Text = userId.ToString();
            var teacher = teacherManager.GetTeacherById(userId);
            btnDelete.Visible = true;
            btnUpdate.Visible = true;
            btnAdd.Visible = false;
            txtFullname.Text = teacher.Fullname;
            txtEmail.Text = teacher.Email;
            txtPassword.Text = teacher.Password;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var fullname = txtFullname.Text;
            var email = txtEmail.Text;
            var password = txtPassword.Text;
            int userId = Convert.ToInt32(txtId.Text);
            var teacher = teacherManager.GetTeacherById(userId);
            teacher.Fullname = fullname;
            teacher.Email = email;
            teacher.Password = password;
            teacherManager.UpdateUser(teacher);
            MessageBox.Show("Teacher is updated.");
            txtFullname.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            btnDelete.Visible = false;
            btnUpdate.Visible = false;
            btnAdd.Visible = true;
            FillTeacherDGW();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result= MessageBox.Show("Are your sure?","Delete teacher", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int userId = Convert.ToInt32(txtId.Text);
                var teacher = teacherManager.GetTeacherById(userId);
                teacherManager.DeleteTeacher(teacher);
                txtFullname.Text = "";
                txtEmail.Text = "";
                txtPassword.Text = "";
                btnDelete.Visible = false;
                btnUpdate.Visible = false;
                btnAdd.Visible = true;
                FillTeacherDGW();
            }
            else
            {
                txtFullname.Text = "";
                txtEmail.Text = "";
                txtPassword.Text = "";
                btnDelete.Visible = false;
                btnUpdate.Visible = false;
                btnAdd.Visible = true;
                
            }
            
        }
    }
}
