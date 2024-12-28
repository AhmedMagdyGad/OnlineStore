namespace OnlineStore
{
    partial class LoginPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            pb_Logo = new PictureBox();
            txt_email = new TextBox();
            txt_password = new TextBox();
            lbl_Username = new Label();
            lbl_Password = new Label();
            btn_Login = new Button();
            btn_DNHA = new Button();
            panel1 = new Panel();
            btn_ShowPassword = new Button();
            btn_ForgetPassword = new Button();
            ((System.ComponentModel.ISupportInitialize) pb_Logo).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pb_Logo
            // 
            pb_Logo.Dock = DockStyle.Top;
            pb_Logo.Image = (Image) resources.GetObject("pb_Logo.Image");
            pb_Logo.Location = new Point(0,0);
            pb_Logo.Margin = new Padding(3,2,3,2);
            pb_Logo.Name = "pb_Logo";
            pb_Logo.Size = new Size(1124,352);
            pb_Logo.SizeMode = PictureBoxSizeMode.CenterImage;
            pb_Logo.TabIndex = 0;
            pb_Logo.TabStop = false;
            // 
            // txt_email
            // 
            txt_email.BackColor = SystemColors.Window;
            txt_email.Font = new Font("Times New Roman",16.2F,FontStyle.Bold,GraphicsUnit.Point, 0);
            txt_email.Location = new Point(375,36);
            txt_email.Margin = new Padding(3,2,3,2);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(350,32);
            txt_email.TabIndex = 1;
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Segoe UI",16.2F,FontStyle.Bold,GraphicsUnit.Point, 0);
            txt_password.Location = new Point(375,97);
            txt_password.Margin = new Padding(3,2,3,2);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(350,36);
            txt_password.TabIndex = 2;
            // 
            // lbl_Username
            // 
            lbl_Username.AutoSize = true;
            lbl_Username.Font = new Font("Times New Roman",13.8F,FontStyle.Bold,GraphicsUnit.Point, 0);
            lbl_Username.ForeColor = Color.White;
            lbl_Username.Location = new Point(372,12);
            lbl_Username.Name = "lbl_Username";
            lbl_Username.Size = new Size(168,22);
            lbl_Username.TabIndex = 3;
            lbl_Username.Text = "Username or Email";
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.Font = new Font("Times New Roman",13.8F,FontStyle.Bold,GraphicsUnit.Point, 0);
            lbl_Password.ForeColor = Color.White;
            lbl_Password.Location = new Point(372,72);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(90,22);
            lbl_Password.TabIndex = 4;
            lbl_Password.Text = "Password";
            // 
            // btn_Login
            // 
            btn_Login.BackColor = Color.LightGreen;
            btn_Login.FlatStyle = FlatStyle.Popup;
            btn_Login.Font = new Font("Arial Narrow",13.8F,FontStyle.Bold,GraphicsUnit.Point, 0);
            btn_Login.Location = new Point(633,148);
            btn_Login.Margin = new Padding(3,2,3,2);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(92,40);
            btn_Login.TabIndex = 5;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_Login_Click;
            // 
            // btn_DNHA
            // 
            btn_DNHA.BackColor = Color.DodgerBlue;
            btn_DNHA.FlatStyle = FlatStyle.Popup;
            btn_DNHA.Font = new Font("Arial",12F,FontStyle.Bold,GraphicsUnit.Point, 0);
            btn_DNHA.Location = new Point(375,148);
            btn_DNHA.Margin = new Padding(3,2,3,2);
            btn_DNHA.Name = "btn_DNHA";
            btn_DNHA.Size = new Size(235,40);
            btn_DNHA.TabIndex = 6;
            btn_DNHA.Text = "Does not have account";
            btn_DNHA.UseVisualStyleBackColor = false;
            btn_DNHA.Click += btn_DNHA_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_ShowPassword);
            panel1.Controls.Add(btn_ForgetPassword);
            panel1.Controls.Add(btn_DNHA);
            panel1.Controls.Add(txt_email);
            panel1.Controls.Add(btn_Login);
            panel1.Controls.Add(txt_password);
            panel1.Controls.Add(lbl_Password);
            panel1.Controls.Add(lbl_Username);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0,357);
            panel1.Name = "panel1";
            panel1.Size = new Size(1124,273);
            panel1.TabIndex = 7;
            // 
            // btn_ShowPassword
            // 
            btn_ShowPassword.Location = new Point(727,103);
            btn_ShowPassword.Name = "btn_ShowPassword";
            btn_ShowPassword.Size = new Size(50,25);
            btn_ShowPassword.TabIndex = 10;
            btn_ShowPassword.Text = "Show";
            btn_ShowPassword.UseVisualStyleBackColor = true;
            btn_ShowPassword.Click += btn_ShowPassword_Click;
            // 
            // btn_ForgetPassword
            // 
            btn_ForgetPassword.BackColor = Color.FromArgb(  255,  128,  128);
            btn_ForgetPassword.FlatStyle = FlatStyle.Popup;
            btn_ForgetPassword.Font = new Font("Arial Narrow",12F,FontStyle.Bold,GraphicsUnit.Point, 0);
            btn_ForgetPassword.Location = new Point(375,202);
            btn_ForgetPassword.Name = "btn_ForgetPassword";
            btn_ForgetPassword.Size = new Size(350,40);
            btn_ForgetPassword.TabIndex = 7;
            btn_ForgetPassword.Text = "Forget Password";
            btn_ForgetPassword.UseVisualStyleBackColor = false;
            btn_ForgetPassword.Click += btn_ForgetPassword_Click;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F,15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1124,630);
            Controls.Add(pb_Logo);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3,2,3,2);
            Name = "LoginPage";
            Text = "OnlineStore";
            ((System.ComponentModel.ISupportInitialize) pb_Logo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pb_Logo;
        private TextBox txt_email;
        private TextBox txt_password;
        private Label lbl_Username;
        private Label lbl_Password;
        private Button btn_Login;
        private Button btn_DNHA;
        private Panel panel1;
        private Button btn_ForgetPassword;
        private Button btn_ShowPassword;
    }
}
