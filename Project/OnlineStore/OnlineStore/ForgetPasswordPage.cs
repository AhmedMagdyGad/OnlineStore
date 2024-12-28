using Accessibility;
using BusinessLayer;
using DataAcessLayer;

namespace OnlineStore;
public partial class ForgetPasswordPage:Form
{
    UserService _userService;
    string _email = string.Empty;
    public ForgetPasswordPage()
    {
        InitializeComponent();
        _userService = new UserService();
    }
    private void btn_BackToLogin_Click(object sender,EventArgs e)
    {
        this.Hide();
        new LoginPage().Show();
    }
    private void btn_ForgetPassword_Click(object sender,EventArgs e)
    {
        if(string.IsNullOrWhiteSpace(txt_email.Text))
        {
            MessageBox.Show(
                "You must enter a Email!!",
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
            MessageBox.Show(
                    "Invalid Email !!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            return;
        }
        if(user.FavoriteSport.ToLower() != txt_FavouriteSport.Text.ToLower())
        {
            MessageBox.Show(
                    "Invalid Favorite Sport !!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            return;
        }
        _email = user.Email;
        txt_email.Text = string.Empty;
        txt_email.PasswordChar = '*';
        txt_FavouriteSport.Text = string.Empty;
        txt_FavouriteSport.PasswordChar = '*';
        lbl_Email.Text = "New Password";
        lbl_FavouriteSport.Text = "Confirm Password";
        btn_ForgetPassword.Visible = false;
        btn_ChangePassword.Visible = true;
        btn_ShowPassword.Visible = true;
        btn_ShowConfirmPassword.Visible = true;
    }
    private void btn_ChangePassword_Click(object sender,EventArgs e)
    {
        if(string.IsNullOrWhiteSpace(txt_email.Text) || txt_email.Text.Length < 8)
        {
            MessageBox.Show(
                "Password is too short!!",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return;
        }
        if(string.IsNullOrWhiteSpace(txt_FavouriteSport.Text)
            || txt_FavouriteSport.Text.Length < 8
            || txt_FavouriteSport.Text != txt_email.Text)
        {
            MessageBox.Show(
                "Passwords doesn't matches!!",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return;
        }
        User user = _userService.LoginUser(_email);
        user.Password = txt_email.Text;
        int affectedRows = _userService.UpdateUser(user);
        if(affectedRows <= 0)
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
            MessageBox.Show(
                "Password has been successfully changed!!",
                "Done",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            this.Hide();
            new LoginPage().Show();
        }
    }
    private void btn_ShowPassword_Click(object sender,EventArgs e)
    {
        if(txt_email.PasswordChar == '*')
            txt_email.PasswordChar = '\0';
        else
            txt_email.PasswordChar = '*';
    }
    private void btn_ShowConfirmPassword_Click(object sender,EventArgs e)
    {
        if(txt_FavouriteSport.PasswordChar == '*')
            txt_FavouriteSport.PasswordChar = '\0';
        else
            txt_FavouriteSport.PasswordChar = '*';
    }
}
