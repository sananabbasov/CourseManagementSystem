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
    public partial class RegisterScreen : Form
    {
        UserManager userManager = new();
        public RegisterScreen()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var email = txtEmail.Text;
            var fullname = asda.Text;
            var password = txtPassword.Text;
            var confirmPassword = txtConfirmPassword.Text;

            if (password != confirmPassword)
            {
                MessageBox.Show("Password is not confirmed.");
            }
            else
            {
                var checkEmail = userManager.GetByEmail(email);

                if (checkEmail != null)
                {
                    MessageBox.Show("Email is exist.");
                }
                else
                {
                    try
                    {
                        User user = new();
                        user.Email = email;
                        user.Fullname = fullname;
                        user.RoleId = 1;
                        userManager.Register(user, password);

                        DialogResult result = MessageBox.Show("Register is success", "Register", MessageBoxButtons.OK);
                        if (result == DialogResult.OK)
                        {
                            this.Close();
                        }
                    }

                    catch (Exception)
                    {
                        MessageBox.Show("Something is wrong.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
    }
}
