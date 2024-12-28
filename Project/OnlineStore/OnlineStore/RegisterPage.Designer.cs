namespace OnlineStore;

partial class RegisterPage
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
        txt_email = new TextBox();
        lbl_Email = new Label();
        txt_Username = new TextBox();
        lbl_Username = new Label();
        txt_Password = new TextBox();
        lbl_Password = new Label();
        lbl_ConfirmPassword = new Label();
        txt_ConfirmPassword = new TextBox();
        nud_Age = new NumericUpDown();
        lbl_Age = new Label();
        btn_Register = new Button();
        txt_Address = new TextBox();
        lbl_Address = new Label();
        txt_FavouriteSport = new TextBox();
        lbl_FavouriteSport = new Label();
        btn_BackToLogin = new Button();
        btn_ShowPassword = new Button();
        btn_ShowConfirmPassword = new Button();
        ((System.ComponentModel.ISupportInitialize) nud_Age).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Times New Roman",36F,FontStyle.Bold,GraphicsUnit.Point, 0);
        label1.ForeColor = Color.FromArgb(  0,  192,  192);
        label1.Location = new Point(312,4);
        label1.Name = "label1";
        label1.Size = new Size(504,55);
        label1.TabIndex = 0;
        label1.Text = "Shopease Register Page";
        // 
        // txt_email
        // 
        txt_email.BackColor = SystemColors.Window;
        txt_email.Font = new Font("Times New Roman",16.2F,FontStyle.Bold,GraphicsUnit.Point, 0);
        txt_email.Location = new Point(364,165);
        txt_email.Margin = new Padding(3,2,3,2);
        txt_email.Name = "txt_email";
        txt_email.Size = new Size(373,32);
        txt_email.TabIndex = 2;
        // 
        // lbl_Email
        // 
        lbl_Email.AutoSize = true;
        lbl_Email.Font = new Font("Times New Roman",13.8F,FontStyle.Bold,GraphicsUnit.Point, 0);
        lbl_Email.ForeColor = Color.White;
        lbl_Email.Location = new Point(362,141);
        lbl_Email.Name = "lbl_Email";
        lbl_Email.Size = new Size(58,22);
        lbl_Email.TabIndex = 4;
        lbl_Email.Text = "Email";
        // 
        // txt_Username
        // 
        txt_Username.BackColor = SystemColors.Window;
        txt_Username.Font = new Font("Times New Roman",16.2F,FontStyle.Bold,GraphicsUnit.Point, 0);
        txt_Username.Location = new Point(364,99);
        txt_Username.Margin = new Padding(3,2,3,2);
        txt_Username.Name = "txt_Username";
        txt_Username.Size = new Size(373,32);
        txt_Username.TabIndex = 2;
        // 
        // lbl_Username
        // 
        lbl_Username.AutoSize = true;
        lbl_Username.Font = new Font("Times New Roman",13.8F,FontStyle.Bold,GraphicsUnit.Point, 0);
        lbl_Username.ForeColor = Color.White;
        lbl_Username.Location = new Point(361,75);
        lbl_Username.Name = "lbl_Username";
        lbl_Username.Size = new Size(92,22);
        lbl_Username.TabIndex = 4;
        lbl_Username.Text = "Username";
        // 
        // txt_Password
        // 
        txt_Password.Font = new Font("Segoe UI",16.2F,FontStyle.Bold,GraphicsUnit.Point, 0);
        txt_Password.Location = new Point(364,231);
        txt_Password.Margin = new Padding(3,2,3,2);
        txt_Password.Name = "txt_Password";
        txt_Password.PasswordChar = '*';
        txt_Password.Size = new Size(373,36);
        txt_Password.TabIndex = 5;
        // 
        // lbl_Password
        // 
        lbl_Password.AutoSize = true;
        lbl_Password.Font = new Font("Times New Roman",13.8F,FontStyle.Bold,GraphicsUnit.Point, 0);
        lbl_Password.ForeColor = Color.White;
        lbl_Password.Location = new Point(363,207);
        lbl_Password.Name = "lbl_Password";
        lbl_Password.Size = new Size(90,22);
        lbl_Password.TabIndex = 4;
        lbl_Password.Text = "Password";
        // 
        // lbl_ConfirmPassword
        // 
        lbl_ConfirmPassword.AutoSize = true;
        lbl_ConfirmPassword.Font = new Font("Times New Roman",13.8F,FontStyle.Bold,GraphicsUnit.Point, 0);
        lbl_ConfirmPassword.ForeColor = Color.White;
        lbl_ConfirmPassword.Location = new Point(361,276);
        lbl_ConfirmPassword.Name = "lbl_ConfirmPassword";
        lbl_ConfirmPassword.Size = new Size(163,22);
        lbl_ConfirmPassword.TabIndex = 4;
        lbl_ConfirmPassword.Text = "Confirm Password";
        // 
        // txt_ConfirmPassword
        // 
        txt_ConfirmPassword.Font = new Font("Segoe UI",16.2F,FontStyle.Bold,GraphicsUnit.Point, 0);
        txt_ConfirmPassword.Location = new Point(364,301);
        txt_ConfirmPassword.Margin = new Padding(3,2,3,2);
        txt_ConfirmPassword.Name = "txt_ConfirmPassword";
        txt_ConfirmPassword.PasswordChar = '*';
        txt_ConfirmPassword.Size = new Size(373,36);
        txt_ConfirmPassword.TabIndex = 5;
        // 
        // nud_Age
        // 
        nud_Age.Font = new Font("Arial Narrow",15.75F,FontStyle.Bold,GraphicsUnit.Point, 0);
        nud_Age.Location = new Point(364,437);
        nud_Age.Minimum = new decimal(new int[] { 1,0,0,0 });
        nud_Age.Name = "nud_Age";
        nud_Age.Size = new Size(373,32);
        nud_Age.TabIndex = 6;
        nud_Age.Value = new decimal(new int[] { 1,0,0,0 });
        // 
        // lbl_Age
        // 
        lbl_Age.AutoSize = true;
        lbl_Age.Font = new Font("Times New Roman",13.8F,FontStyle.Bold,GraphicsUnit.Point, 0);
        lbl_Age.ForeColor = Color.White;
        lbl_Age.Location = new Point(363,412);
        lbl_Age.Name = "lbl_Age";
        lbl_Age.Size = new Size(42,22);
        lbl_Age.TabIndex = 4;
        lbl_Age.Text = "Age";
        // 
        // btn_Register
        // 
        btn_Register.BackColor = Color.LightGreen;
        btn_Register.FlatStyle = FlatStyle.Popup;
        btn_Register.Font = new Font("Arial Narrow",13.8F,FontStyle.Bold,GraphicsUnit.Point, 0);
        btn_Register.Location = new Point(364,552);
        btn_Register.Margin = new Padding(3,2,3,2);
        btn_Register.Name = "btn_Register";
        btn_Register.Size = new Size(373,40);
        btn_Register.TabIndex = 7;
        btn_Register.Text = "Register";
        btn_Register.UseVisualStyleBackColor = false;
        btn_Register.Click += btn_Register_Click;
        // 
        // txt_Address
        // 
        txt_Address.BackColor = SystemColors.Window;
        txt_Address.Font = new Font("Times New Roman",16.2F,FontStyle.Bold,GraphicsUnit.Point, 0);
        txt_Address.Location = new Point(364,371);
        txt_Address.Margin = new Padding(3,2,3,2);
        txt_Address.Name = "txt_Address";
        txt_Address.Size = new Size(373,32);
        txt_Address.TabIndex = 2;
        // 
        // lbl_Address
        // 
        lbl_Address.AutoSize = true;
        lbl_Address.Font = new Font("Times New Roman",13.8F,FontStyle.Bold,GraphicsUnit.Point, 0);
        lbl_Address.ForeColor = Color.White;
        lbl_Address.Location = new Point(363,347);
        lbl_Address.Name = "lbl_Address";
        lbl_Address.Size = new Size(76,22);
        lbl_Address.TabIndex = 4;
        lbl_Address.Text = "Address";
        // 
        // txt_FavouriteSport
        // 
        txt_FavouriteSport.BackColor = SystemColors.Window;
        txt_FavouriteSport.Font = new Font("Times New Roman",16.2F,FontStyle.Bold,GraphicsUnit.Point, 0);
        txt_FavouriteSport.Location = new Point(364,503);
        txt_FavouriteSport.Margin = new Padding(3,2,3,2);
        txt_FavouriteSport.Name = "txt_FavouriteSport";
        txt_FavouriteSport.Size = new Size(373,32);
        txt_FavouriteSport.TabIndex = 2;
        // 
        // lbl_FavouriteSport
        // 
        lbl_FavouriteSport.AutoSize = true;
        lbl_FavouriteSport.Font = new Font("Times New Roman",13.8F,FontStyle.Bold,GraphicsUnit.Point, 0);
        lbl_FavouriteSport.ForeColor = Color.White;
        lbl_FavouriteSport.Location = new Point(363,479);
        lbl_FavouriteSport.Name = "lbl_FavouriteSport";
        lbl_FavouriteSport.Size = new Size(139,22);
        lbl_FavouriteSport.TabIndex = 4;
        lbl_FavouriteSport.Text = "Favourite Sport";
        // 
        // btn_BackToLogin
        // 
        btn_BackToLogin.Font = new Font("Times New Roman",18F,FontStyle.Bold,GraphicsUnit.Point, 0);
        btn_BackToLogin.ForeColor = Color.Maroon;
        btn_BackToLogin.Location = new Point(12,23);
        btn_BackToLogin.Name = "btn_BackToLogin";
        btn_BackToLogin.Size = new Size(81,34);
        btn_BackToLogin.TabIndex = 8;
        btn_BackToLogin.Text = "Back";
        btn_BackToLogin.UseVisualStyleBackColor = true;
        btn_BackToLogin.Click += btn_BackToLogin_Click;
        // 
        // btn_ShowPassword
        // 
        btn_ShowPassword.Location = new Point(739,237);
        btn_ShowPassword.Name = "btn_ShowPassword";
        btn_ShowPassword.Size = new Size(51,25);
        btn_ShowPassword.TabIndex = 9;
        btn_ShowPassword.Text = "Show";
        btn_ShowPassword.UseVisualStyleBackColor = true;
        btn_ShowPassword.Click += btn_ShowPassword_Click;
        // 
        // btn_ShowConfirmPassword
        // 
        btn_ShowConfirmPassword.Location = new Point(739,307);
        btn_ShowConfirmPassword.Name = "btn_ShowConfirmPassword";
        btn_ShowConfirmPassword.Size = new Size(51,25);
        btn_ShowConfirmPassword.TabIndex = 9;
        btn_ShowConfirmPassword.Text = "Show";
        btn_ShowConfirmPassword.UseVisualStyleBackColor = true;
        btn_ShowConfirmPassword.Click += btn_ShowConfirmPassword_Click;
        // 
        // RegisterPage
        // 
        AutoScaleDimensions = new SizeF(7F,15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ControlDarkDark;
        ClientSize = new Size(1124,630);
        Controls.Add(btn_ShowConfirmPassword);
        Controls.Add(btn_ShowPassword);
        Controls.Add(btn_BackToLogin);
        Controls.Add(btn_Register);
        Controls.Add(nud_Age);
        Controls.Add(txt_ConfirmPassword);
        Controls.Add(lbl_Age);
        Controls.Add(lbl_ConfirmPassword);
        Controls.Add(txt_Password);
        Controls.Add(lbl_Password);
        Controls.Add(lbl_Username);
        Controls.Add(lbl_FavouriteSport);
        Controls.Add(lbl_Address);
        Controls.Add(lbl_Email);
        Controls.Add(txt_Username);
        Controls.Add(txt_FavouriteSport);
        Controls.Add(txt_Address);
        Controls.Add(txt_email);
        Controls.Add(label1);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Name = "RegisterPage";
        Text = "Register Page";
        ((System.ComponentModel.ISupportInitialize) nud_Age).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox txt_email;
    private Label lbl_Email;
    private TextBox txt_Username;
    private Label lbl_Username;
    private TextBox txt_Password;
    private Label lbl_Password;
    private Label lbl_ConfirmPassword;
    private TextBox txt_ConfirmPassword;
    private NumericUpDown nud_Age;
    private Label lbl_Age;
    private Button btn_Register;
    private TextBox txt_Address;
    private Label lbl_Address;
    private TextBox txt_FavouriteSport;
    private Label lbl_FavouriteSport;
    private Button btn_BackToLogin;
    private Button btn_ShowPassword;
    private Button btn_ShowConfirmPassword;
}