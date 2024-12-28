using BusinessLayer;
using DataAcessLayer;

namespace OnlineStore
{
    public partial class LoginPage:Form
    {
        UserService userService;
        public LoginPage()
        {
            InitializeComponent();
            userService = new UserService();
        }
        private void btn_DNHA_Click(object sender,EventArgs e)
        {
            this.Hide();
            new RegisterPage().Show();
        }
        private void btn_ForgetPassword_Click(object sender,EventArgs e)
        {
            this.Hide();
            new ForgetPasswordPage().Show();
        }
        private void btn_Login_Click(object sender,EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txt_email.Text))
            {
                MessageBox.Show(
                    "You must enter Email or UserName!!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if(string.IsNullOrWhiteSpace(txt_password.Text) || txt_password.Text.Length < 8)
            {
                MessageBox.Show(
                    "Password is too short!!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            User user = userService.LoginUser(txt_email.Text);
            if(user == null || user.Password != txt_password.Text)
            {
                MessageBox.Show(
                    "Invalid Email or Password!!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if(user.RoleID == (int) Roles.Admin || user.RoleID == (int) Roles.GM)
            {
                this.Hide();
                new AdminMode(user.Name).Show();
            }
            else
            {
                this.Hide();
                new UserMode(user.Name).Show();
            }
        }
        private void btn_ShowPassword_Click(object sender,EventArgs e)
        {
            if(txt_password.PasswordChar == '*')
                txt_password.PasswordChar = '\0';
            else
                txt_password.PasswordChar = '*';
        }
    }
}
