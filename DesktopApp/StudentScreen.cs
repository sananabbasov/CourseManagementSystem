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
    public partial class StudentScreen : Form
    {
        GroupManager _groupManager = new();
        PaymentManager _paymentManager = new();
        StudentManager _studentManager = new();



        int studentNewId = 0;
        public StudentScreen()
        {
            InitializeComponent();
        }

        public void FillDGV()
        {
            var studentList = _studentManager.GetAllStudents()
                .Select(student => new
                {
                    ID = student.Id,
                    Email = student.Email,
                    Phone = String.Format("{0:+(### ##) ###-##-##}", Convert.ToInt64(student.Number)),

                }).ToList();

            DgvStudents.DataSource = studentList;
        }

        private void StudentScreen_Load(object sender, EventArgs e)
        {
            FillDGV();
            var groups = _groupManager.GetAllGroups();

            foreach (var group in groups)
            {
                CmbGroups.Items.Add(group.Name);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string fullname = TxtFullname.Text;
            string email = TxtEmail.Text;
            string number = TxtNumber.Text;
            string group = CmbGroups.Text;
            double generalPrice = (double)NmrGeneralPrice.Value;
            double payment = (double)NmrPayment.Value;

            try
            {
                var groups = _groupManager.GetGroupByName(group);

                Random rnd = new();
                Student student = new()
                {
                    Email = email,
                    Number = number,
                    Fullname = fullname,
                    GroupId = groups.Id,
                    Password = rnd.Next(0, 100000).ToString(),
                    MainPrice = generalPrice,
                };

                var students = _studentManager.AddStudent(student);

                _paymentManager.AddPayment(students.Id, payment);

                MessageBox.Show("Student is added.");
                FillDGV();
            }
            catch (Exception)
            {
                MessageBox.Show("Something is wrong.", "Error", MessageBoxButtons.OK);
            }
        }

        private void DgvStudents_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int studentId = (int)DgvStudents.Rows[e.RowIndex].Cells[0].Value;

            try
            {
                var student = _studentManager.GetStudentById(studentId);
                TxtEmail.Text = student.Email;
                TxtNumber.Text = student.Number;
                TxtFullname.Text = student.Fullname;
                CmbGroups.Text = student.Group.Name;
                NmrGeneralPrice.Value = (decimal)student.MainPrice;

                studentNewId = student.Id;


                BtnAdd.Visible = false;
                BtnUpdate.Visible = true;
                BtnDelete.Visible = true;
                BtnPay.Visible = true;
                NmrGeneralPrice.Enabled = false;
            }
            catch (Exception error)
            {
                MessageBox.Show("Something is wrong! \n Error: " + error.Message, "Warning", MessageBoxButtons.OK);
            }



        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    var student = _studentManager.GetStudentById(studentNewId);
                    var group = _groupManager.GetGroupByName(CmbGroups.Text);
                    student.Fullname = TxtFullname.Text;
                    student.Number = TxtNumber.Text;
                    student.Email = TxtEmail.Text;
                    student.GroupId = group.Id;
                    _studentManager.UpdateStudent(student);
                    MessageBox.Show("Student is updated.");
                    FillDGV();
                    TxtEmail.Text = string.Empty;
                    TxtNumber.Text = string.Empty;
                    TxtFullname.Text = string.Empty;
                    CmbGroups.SelectedText = String.Empty;

                }
                catch (Exception)
                {
                    MessageBox.Show("Something is wrong!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }


    }
}
