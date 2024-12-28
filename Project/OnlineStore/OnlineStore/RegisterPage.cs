using BusinessLayer;
using DataAcessLayer;

namespace OnlineStore;
public partial class RegisterPage:Form
{
    UserService _userService;
    public RegisterPage()
    {
        InitializeComponent();
        _userService = new UserService();
    }
    private void btn_BackToLogin_Click(object sender,EventArgs e)
    {
        this.Hide();
        new LoginPage().Show();
    }
    private void btn_Register_Click(object sender,EventArgs e)
    {
        if(string.IsNullOrWhiteSpace(txt_Username.Text))
        {
            MessageBox.Show(
                "You must enter a UserName!!",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return;
        }
        if(string.IsNullOrWhiteSpace(txt_email.Text))
        {
            MessageBox.Show(
                "You must enter a Email!!",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return;
        }
        if(string.IsNullOrWhiteSpace(txt_Password.Text) || txt_Password.Text.Length < 8)
        {
            MessageBox.Show(
                "Password is too short!!",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return;
        }
        if(string.IsNullOrWhiteSpace(txt_ConfirmPassword.Text)
            || txt_ConfirmPassword.Text.Length < 8
            || txt_ConfirmPassword.Text != txt_Password.Text)
        {
            MessageBox.Show(
                "Passwords doesn't matches!!",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return;
        }
        if(string.IsNullOrWhiteSpace(txt_Address.Text))
        {
            MessageBox.Show(
                "You must enter an Address!!",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return;
        }
        if(nud_Age.Value < 12)
        {
            MessageBox.Show(
                "You're age must be bigger than 12 years!!",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return;
        }
        if(string.IsNullOrWhiteSpace(txt_FavouriteSport.Text))
        {
            MessageBox.Show(
                "You must enter a Favorite sport!!",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return;
        }
        User user = _userService.LoginUser(txt_email.Text);
        if(user == null)
        {
            User newUser = new User
            {
                Name = txt_Username.Text,
                Email = txt_email.Text,
                Password = txt_Password.Text,
                Address = txt_Address.Text,
                Age = (int) nud_Age.Value,
                FavoriteSport = txt_FavouriteSport.Text
            };
            int resutl = -1;
            resutl = _userService.AddUser(newUser);
            if(resutl <= 0)
            {
                MessageBox.Show(
                    "Something happen, Please try again!!",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            else
            {
                this.Hide();
                new WelcomePageAfterRegistration().Show();
            }
        }
        else
        {
            MessageBox.Show(
                "Duplicated Email !!",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return;
        }
    }
    private void btn_ShowPassword_Click(object sender,EventArgs e)
    {
        if(txt_Password.PasswordChar == '*')
            txt_Password.PasswordChar = '\0';
        else
            txt_Password.PasswordChar = '*';
    }
    private void btn_ShowConfirmPassword_Click(object sender,EventArgs e)
    {
        if(txt_ConfirmPassword.PasswordChar == '*')
            txt_ConfirmPassword.PasswordChar = '\0';
        else
            txt_ConfirmPassword.PasswordChar = '*';
    }
}
