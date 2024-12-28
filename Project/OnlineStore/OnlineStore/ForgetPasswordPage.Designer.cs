namespace OnlineStore;

partial class ForgetPasswordPage
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if(disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        label1 = new Label();
        lbl_Email = new Label();
        txt_email = new TextBox();
        lbl_FavouriteSport = new Label();
        txt_FavouriteSport = new TextBox();
        btn_ForgetPassword = new Button();
        btn_BackToLogin = new Button();
        btn_ChangePassword = new Button();
        btn_ShowPassword = new Button();
        btn_ShowConfirmPassword = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Times New Roman",36F,FontStyle.Bold,GraphicsUnit.Point, 0);
        label1.ForeColor = Color.FromArgb(  0,  192,  192);
        label1.Location = new Point(217,9);
        label1.Name = "label1";
        label1.Size = new Size(679,55);
        label1.TabIndex = 1;
        label1.Text = "Shopease Forget Password Page";
        // 
        // lbl_Email
        // 
        lbl_Email.AutoSize = true;
        lbl_Email.Font = new Font("Times New Roman",13.8F,FontStyle.Bold,GraphicsUnit.Point, 0);
        lbl_Email.ForeColor = Color.White;
        lbl_Email.Location = new Point(357,192);
        lbl_Email.Name = "lbl_Email";
        lbl_Email.Size = new Size(58,22);
        lbl_Email.TabIndex = 6;
        lbl_Email.Text = "Email";
        // 
        // txt_email
        // 
        txt_email.BackColor = SystemColors.Window;
        txt_email.Font = new Font("Times New Roman",16.2F,FontStyle.Bold,GraphicsUnit.Point, 0);
        txt_email.Location = new Point(359,216);
        txt_email.Margin = new Padding(3,2,3,2);
        txt_email.Name = "txt_email";
        txt_email.Size = new Size(373,32);
        txt_email.TabIndex = 5;
        // 
        // lbl_FavouriteSport
        // 
        lbl_FavouriteSport.AutoSize = true;
        lbl_FavouriteSport.Font = new Font("Times New Roman",13.8F,FontStyle.Bold,GraphicsUnit.Point, 0);
        lbl_FavouriteSport.ForeColor = Color.White;
        lbl_FavouriteSport.Location = new Point(358,267);
        lbl_FavouriteSport.Name = "lbl_FavouriteSport";
        lbl_FavouriteSport.Size = new Size(139,22);
        lbl_FavouriteSport.TabIndex = 8;
        lbl_FavouriteSport.Text = "Favourite Sport";
        // 
        // txt_FavouriteSport
        // 
        txt_FavouriteSport.BackColor = SystemColors.Window;
        txt_FavouriteSport.Font = new Font("Times New Roman",16.2F,FontStyle.Bold,GraphicsUnit.Point, 0);
        txt_FavouriteSport.Location = new Point(359,291);
        txt_FavouriteSport.Margin = new Padding(3,2,3,2);
        txt_FavouriteSport.Name = "txt_FavouriteSport";
        txt_FavouriteSport.Size = new Size(373,32);
        txt_FavouriteSport.TabIndex = 7;
        // 
        // btn_ForgetPassword
        // 
        btn_ForgetPassword.BackColor = Color.FromArgb(  255,  128,  128);
        btn_ForgetPassword.FlatStyle = FlatStyle.Popup;
        btn_ForgetPassword.Font = new Font("Arial Black",12F,FontStyle.Bold,GraphicsUnit.Point, 0);
        btn_ForgetPassword.Location = new Point(359,342);
        btn_ForgetPassword.Name = "btn_ForgetPassword";
        btn_ForgetPassword.Size = new Size(373,40);
        btn_ForgetPassword.TabIndex = 9;
        btn_ForgetPassword.Text = "Check";
        btn_ForgetPassword.UseVisualStyleBackColor = false;
        btn_ForgetPassword.Click += btn_ForgetPassword_Click;
        // 
        // btn_BackToLogin
        // 
        btn_BackToLogin.Font = new Font("Times New Roman",18F,FontStyle.Bold,GraphicsUnit.Point, 0);
        btn_BackToLogin.ForeColor = Color.Maroon;
        btn_BackToLogin.Location = new Point(12,12);
        btn_BackToLogin.Name = "btn_BackToLogin";
        btn_BackToLogin.Size = new Size(81,34);
        btn_BackToLogin.TabIndex = 10;
        btn_BackToLogin.Text = "Back";
        btn_BackToLogin.UseVisualStyleBackColor = true;
        btn_BackToLogin.Click += btn_BackToLogin_Click;
        // 
        // btn_ChangePassword
        // 
        btn_ChangePassword.BackColor = Color.LightGreen;
        btn_ChangePassword.FlatStyle = FlatStyle.Popup;
        btn_ChangePassword.Font = new Font("Arial Black",12F,FontStyle.Bold,GraphicsUnit.Point, 0);
        btn_ChangePassword.Location = new Point(359,346);
        btn_ChangePassword.Name = "btn_ChangePassword";
        btn_ChangePassword.Size = new Size(373,40);
        btn_ChangePassword.TabIndex = 9;
        btn_ChangePassword.Text = "Change";
        btn_ChangePassword.UseVisualStyleBackColor = false;
        btn_ChangePassword.Visible = false;
        btn_ChangePassword.Click += btn_ChangePassword_Click;
        // 
        // btn_ShowPassword
        // 
        btn_ShowPassword.Location = new Point(732,219);
        btn_ShowPassword.Name = "btn_ShowPassword";
        btn_ShowPassword.Size = new Size(52,25);
        btn_ShowPassword.TabIndex = 11;
        btn_ShowPassword.Text = "Show";
        btn_ShowPassword.UseVisualStyleBackColor = true;
        btn_ShowPassword.Visible = false;
        btn_ShowPassword.Click += btn_ShowPassword_Click;
        // 
        // btn_ShowConfirmPassword
        // 
        btn_ShowConfirmPassword.Location = new Point(732,295);
        btn_ShowConfirmPassword.Name = "btn_ShowConfirmPassword";
        btn_ShowConfirmPassword.Size = new Size(52,25);
        btn_ShowConfirmPassword.TabIndex = 11;
        btn_ShowConfirmPassword.Text = "Show";
        btn_ShowConfirmPassword.UseVisualStyleBackColor = true;
        btn_ShowConfirmPassword.Visible = false;
        btn_ShowConfirmPassword.Click += btn_ShowConfirmPassword_Click;
        // 
        // ForgetPasswordPage
        // 
        AutoScaleDimensions = new SizeF(7F,15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ControlDarkDark;
        ClientSize = new Size(1124,630);
        Controls.Add(btn_ShowConfirmPassword);
        Controls.Add(btn_ShowPassword);
        Controls.Add(btn_BackToLogin);
        Controls.Add(btn_ChangePassword);
        Controls.Add(btn_ForgetPassword);
        Controls.Add(lbl_FavouriteSport);
        Controls.Add(txt_FavouriteSport);
        Controls.Add(lbl_Email);
        Controls.Add(txt_email);
        Controls.Add(label1);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Name = "ForgetPasswordPage";
        Text = "Forget Password Page";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label lbl_Email;
    private TextBox txt_email;
    private Label lbl_FavouriteSport;
    private TextBox txt_FavouriteSport;
    private Button btn_ForgetPassword;
    private Button btn_BackToLogin;
    private Button btn_ChangePassword;
    private Button btn_ShowPassword;
    private Button btn_ShowConfirmPassword;
}