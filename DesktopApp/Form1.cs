using Business;

namespace DesktopApp
{
    public partial class Form1 : Form
    {
        UserManager userManager = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var email = txtEmail.Text;
            var password = txtPasswod.Text;

            var checkEmail = userManager.GetByEmail(email);

            if (checkEmail != null)
            {
                if (checkEmail.Email == email && checkEmail.Password == userManager.PasswordHash(password))
                {
                    Dashboard dashboard = new Dashboard();
                    dashboard.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Email or password is not correct.");
                }
            }
            else
            {
                MessageBox.Show("Email or password is not correct.");
            }

           
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            RegisterScreen registerScreen = new RegisterScreen();
            registerScreen.ShowDialog();
        }
    }
}