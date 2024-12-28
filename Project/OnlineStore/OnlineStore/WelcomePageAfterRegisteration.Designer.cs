namespace OnlineStore;

partial class WelcomePageAfterRegistration
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomePageAfterRegistration));
        pictureBox1 = new PictureBox();
        btn_Login = new Button();
        ((System.ComponentModel.ISupportInitialize) pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // pictureBox1
        // 
        pictureBox1.Dock = DockStyle.Fill;
        pictureBox1.Image = (Image) resources.GetObject("pictureBox1.Image");
        pictureBox1.Location = new Point(0,0);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(1124,630);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // btn_Login
        // 
        btn_Login.BackColor = Color.LightGreen;
        btn_Login.FlatStyle = FlatStyle.Popup;
        btn_Login.Font = new Font("Arial Narrow",13.8F,FontStyle.Bold,GraphicsUnit.Point, 0);
        btn_Login.Location = new Point(322,541);
        btn_Login.Margin = new Padding(3,2,3,2);
        btn_Login.Name = "btn_Login";
        btn_Login.Size = new Size(539,40);
        btn_Login.TabIndex = 6;
        btn_Login.Text = "Login";
        btn_Login.UseVisualStyleBackColor = false;
        btn_Login.Click += btn_Login_Click;
        // 
        // WelcomePageAfterRegistration
        // 
        AutoScaleDimensions = new SizeF(7F,15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ControlDarkDark;
        ClientSize = new Size(1124,630);
        Controls.Add(btn_Login);
        Controls.Add(pictureBox1);
        Name = "WelcomePageAfterRegistration";
        Text = "Welcome Page";
        ((System.ComponentModel.ISupportInitialize) pictureBox1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private PictureBox pictureBox1;
    private Button btn_Login;
}