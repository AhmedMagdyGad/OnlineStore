namespace OnlineStore;

partial class UserMode
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
        btn_UserShowProducts = new Button();
        btn_UserProfile = new Button();
        btn_UserFavouriteProducts = new Button();
        lbl_UserDashboard = new Label();
        panel1 = new Panel();
        btn_UserLogout = new Button();
        dgv_UserProducts = new DataGridView();
        txt_ProductName = new TextBox();
        lbl_UserProductName = new Label();
        btn_AddToFavourite = new Button();
        lbl_Notes = new Label();
        dgv_UserFavouriteProducts = new DataGridView();
        nud_UserProfileAge = new NumericUpDown();
        lbl_UserProfileAge = new Label();
        lbl_UserProfileFavouriteSport = new Label();
        lbl_UserProfileAddress = new Label();
        lbl_UserProfileEmail = new Label();
        lbl_UserProfileUserName = new Label();
        txt_UserProfileFavouriteSport = new TextBox();
        txt_UserProfileAddress = new TextBox();
        txt_UserProfileEmail = new TextBox();
        txt_UserProfileUserName = new TextBox();
        btn_UserUpdateProfile = new Button();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) dgv_UserProducts).BeginInit();
        ((System.ComponentModel.ISupportInitialize) dgv_UserFavouriteProducts).BeginInit();
        ((System.ComponentModel.ISupportInitialize) nud_UserProfileAge).BeginInit();
        SuspendLayout();
        // 
        // btn_UserShowProducts
        // 
        btn_UserShowProducts.FlatStyle = FlatStyle.Flat;
        btn_UserShowProducts.Font = new Font("Segoe UI",18F,FontStyle.Bold,GraphicsUnit.Point, 0);
        btn_UserShowProducts.ForeColor = SystemColors.ControlLightLight;
        btn_UserShowProducts.Location = new Point(12,176);
        btn_UserShowProducts.Name = "btn_UserShowProducts";
        btn_UserShowProducts.Size = new Size(246,45);
        btn_UserShowProducts.TabIndex = 1;
        btn_UserShowProducts.Text = "All Products";
        btn_UserShowProducts.UseVisualStyleBackColor = true;
        btn_UserShowProducts.Click += btn_UserShowProducts_Click;
        // 
        // btn_UserProfile
        // 
        btn_UserProfile.FlatStyle = FlatStyle.Flat;
        btn_UserProfile.Font = new Font("Segoe UI",18F,FontStyle.Bold,GraphicsUnit.Point, 0);
        btn_UserProfile.ForeColor = SystemColors.ControlLightLight;
        btn_UserProfile.Location = new Point(12,398);
        btn_UserProfile.Name = "btn_UserProfile";
        btn_UserProfile.Size = new Size(246,45);
        btn_UserProfile.TabIndex = 1;
        btn_UserProfile.Text = "Profile";
        btn_UserProfile.UseVisualStyleBackColor = true;
        btn_UserProfile.Click += btn_UserProfile_Click;
        // 
        // btn_UserFavouriteProducts
        // 
        btn_UserFavouriteProducts.FlatStyle = FlatStyle.Flat;
        btn_UserFavouriteProducts.Font = new Font("Segoe UI",18F,FontStyle.Bold,GraphicsUnit.Point, 0);
        btn_UserFavouriteProducts.ForeColor = SystemColors.ControlLightLight;
        btn_UserFavouriteProducts.Location = new Point(12,271);
        btn_UserFavouriteProducts.Name = "btn_UserFavouriteProducts";
        btn_UserFavouriteProducts.Size = new Size(246,77);
        btn_UserFavouriteProducts.TabIndex = 1;
        btn_UserFavouriteProducts.Text = "My Favourite Products";
        btn_UserFavouriteProducts.UseVisualStyleBackColor = true;
        btn_UserFavouriteProducts.Click += btn_UserFavouriteProducts_Click;
        // 
        // lbl_UserDashboard
        // 
        lbl_UserDashboard.AutoSize = true;
        lbl_UserDashboard.BorderStyle = BorderStyle.FixedSingle;
        lbl_UserDashboard.Font = new Font("Arial",20.25F,FontStyle.Bold,GraphicsUnit.Point, 0);
        lbl_UserDashboard.ForeColor = SystemColors.Info;
        lbl_UserDashboard.Location = new Point(12,76);
        lbl_UserDashboard.Name = "lbl_UserDashboard";
        lbl_UserDashboard.Size = new Size(2,34);
        lbl_UserDashboard.TabIndex = 0;
        // 
        // panel1
        // 
        panel1.Controls.Add(btn_UserLogout);
        panel1.Controls.Add(btn_UserShowProducts);
        panel1.Controls.Add(btn_UserProfile);
        panel1.Controls.Add(btn_UserFavouriteProducts);
        panel1.Controls.Add(lbl_UserDashboard);
        panel1.Dock = DockStyle.Left;
        panel1.Location = new Point(0,0);
        panel1.Name = "panel1";
        panel1.Size = new Size(274,630);
        panel1.TabIndex = 1;
        // 
        // btn_UserLogout
        // 
        btn_UserLogout.BackColor = Color.FromArgb(  255,  128,  128);
        btn_UserLogout.FlatStyle = FlatStyle.Popup;
        btn_UserLogout.Font = new Font("Arial Black",12F,FontStyle.Bold,GraphicsUnit.Point, 0);
        btn_UserLogout.Location = new Point(55,571);
        btn_UserLogout.Name = "btn_UserLogout";
        btn_UserLogout.Size = new Size(143,47);
        btn_UserLogout.TabIndex = 10;
        btn_UserLogout.Text = "Logout";
        btn_UserLogout.UseVisualStyleBackColor = false;
        btn_UserLogout.Click += btn_UserLogout_Click;
        // 
        // dgv_UserProducts
        // 
        dgv_UserProducts.AllowUserToAddRows = false;
        dgv_UserProducts.AllowUserToDeleteRows = false;
        dgv_UserProducts.BackgroundColor = Color.Black;
        dgv_UserProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgv_UserProducts.Dock = DockStyle.Top;
        dgv_UserProducts.Location = new Point(274,0);
        dgv_UserProducts.Name = "dgv_UserProducts";
        dgv_UserProducts.ReadOnly = true;
        dgv_UserProducts.RowHeadersWidth = 51;
        dgv_UserProducts.Size = new Size(850,303);
        dgv_UserProducts.TabIndex = 11;
        dgv_UserProducts.Visible = false;
        dgv_UserProducts.RowHeaderMouseDoubleClick += dgv_UserProducts_RowHeaderMouseDoubleClick;
        // 
        // txt_ProductName
        // 
        txt_ProductName.BackColor = SystemColors.Window;
        txt_ProductName.Font = new Font("Times New Roman",16.2F,FontStyle.Bold,GraphicsUnit.Point, 0);
        txt_ProductName.Location = new Point(494,382);
        txt_ProductName.Margin = new Padding(3,2,3,2);
        txt_ProductName.Name = "txt_ProductName";
        txt_ProductName.Size = new Size(373,32);
        txt_ProductName.TabIndex = 12;
        txt_ProductName.Visible = false;
        // 
        // lbl_UserProductName
        // 
        lbl_UserProductName.AutoSize = true;
        lbl_UserProductName.Font = new Font("Times New Roman",13.8F,FontStyle.Bold,GraphicsUnit.Point, 0);
        lbl_UserProductName.ForeColor = Color.White;
        lbl_UserProductName.Location = new Point(417,387);
        lbl_UserProductName.Name = "lbl_UserProductName";
        lbl_UserProductName.Size = new Size(75,22);
        lbl_UserProductName.TabIndex = 13;
        lbl_UserProductName.Text = "Product";
        lbl_UserProductName.Visible = false;
        // 
        // btn_AddToFavourite
        // 
        btn_AddToFavourite.BackColor = Color.LightGreen;
        btn_AddToFavourite.FlatStyle = FlatStyle.Popup;
        btn_AddToFavourite.Font = new Font("Arial Narrow",13.8F,FontStyle.Bold,GraphicsUnit.Point, 0);
        btn_AddToFavourite.Location = new Point(494,432);
        btn_AddToFavourite.Margin = new Padding(3,2,3,2);
        btn_AddToFavourite.Name = "btn_AddToFavourite";
        btn_AddToFavourite.Size = new Size(373,40);
        btn_AddToFavourite.TabIndex = 14;
        btn_AddToFavourite.Text = "+ Add to Favourite";
        btn_AddToFavourite.UseVisualStyleBackColor = false;
        btn_AddToFavourite.Visible = false;
        btn_AddToFavourite.Click += btn_AddToFavourite_Click;
        // 
        // lbl_Notes
        // 
        lbl_Notes.AutoSize = true;
        lbl_Notes.Font = new Font("Arial Narrow",21.75F,FontStyle.Regular,GraphicsUnit.Point, 0);
        lbl_Notes.ForeColor = Color.LightCoral;
        lbl_Notes.Location = new Point(427,306);
        lbl_Notes.Name = "lbl_Notes";
        lbl_Notes.Size = new Size(480,33);
        lbl_Notes.TabIndex = 13;
        lbl_Notes.Text = "Double click on the product row to select it !!";
        lbl_Notes.Visible = false;
        // 
        // dgv_UserFavouriteProducts
        // 
        dgv_UserFavouriteProducts.AllowUserToAddRows = false;
        dgv_UserFavouriteProducts.AllowUserToDeleteRows = false;
        dgv_UserFavouriteProducts.BackgroundColor = Color.Black;
        dgv_UserFavouriteProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgv_UserFavouriteProducts.Location = new Point(274,0);
        dgv_UserFavouriteProducts.Name = "dgv_UserFavouriteProducts";
        dgv_UserFavouriteProducts.ReadOnly = true;
        dgv_UserFavouriteProducts.RowHeadersWidth = 51;
        dgv_UserFavouriteProducts.Size = new Size(850,303);
        dgv_UserFavouriteProducts.TabIndex = 15;
        dgv_UserFavouriteProducts.Visible = false;
        dgv_UserFavouriteProducts.RowHeaderMouseDoubleClick += dgv_UserFavouriteProducts_RowHeaderMouseDoubleClick;
        // 
        // nud_UserProfileAge
        // 
        nud_UserProfileAge.Font = new Font("Arial Narrow",15.75F,FontStyle.Bold,GraphicsUnit.Point, 0);
        nud_UserProfileAge.Location = new Point(494,362);
        nud_UserProfileAge.Maximum = new decimal(new int[] { 130,0,0,0 });
        nud_UserProfileAge.Name = "nud_UserProfileAge";
        nud_UserProfileAge.Size = new Size(373,32);
        nud_UserProfileAge.TabIndex = 25;
        nud_UserProfileAge.Value = new decimal(new int[] { 1,0,0,0 });
        nud_UserProfileAge.Visible = false;
        // 
        // lbl_UserProfileAge
        // 
        lbl_UserProfileAge.AutoSize = true;
        lbl_UserProfileAge.Font = new Font("Times New Roman",13.8F,FontStyle.Bold,GraphicsUnit.Point, 0);
        lbl_UserProfileAge.ForeColor = Color.White;
        lbl_UserProfileAge.Location = new Point(450,369);
        lbl_UserProfileAge.Name = "lbl_UserProfileAge";
        lbl_UserProfileAge.Size = new Size(42,22);
        lbl_UserProfileAge.TabIndex = 20;
        lbl_UserProfileAge.Text = "Age";
        lbl_UserProfileAge.Visible = false;
        // 
        // lbl_UserProfileFavouriteSport
        // 
        lbl_UserProfileFavouriteSport.AutoSize = true;
        lbl_UserProfileFavouriteSport.Font = new Font("Times New Roman",13.8F,FontStyle.Bold,GraphicsUnit.Point, 0);
        lbl_UserProfileFavouriteSport.ForeColor = Color.White;
        lbl_UserProfileFavouriteSport.Location = new Point(355,442);
        lbl_UserProfileFavouriteSport.Name = "lbl_UserProfileFavouriteSport";
        lbl_UserProfileFavouriteSport.Size = new Size(139,22);
        lbl_UserProfileFavouriteSport.TabIndex = 21;
        lbl_UserProfileFavouriteSport.Text = "Favourite Sport";
        lbl_UserProfileFavouriteSport.Visible = false;
        // 
        // lbl_UserProfileAddress
        // 
        lbl_UserProfileAddress.AutoSize = true;
        lbl_UserProfileAddress.Font = new Font("Times New Roman",13.8F,FontStyle.Bold,GraphicsUnit.Point, 0);
        lbl_UserProfileAddress.ForeColor = Color.White;
        lbl_UserProfileAddress.Location = new Point(416,280);
        lbl_UserProfileAddress.Name = "lbl_UserProfileAddress";
        lbl_UserProfileAddress.Size = new Size(76,22);
        lbl_UserProfileAddress.TabIndex = 22;
        lbl_UserProfileAddress.Text = "Address";
        lbl_UserProfileAddress.Visible = false;
        // 
        // lbl_UserProfileEmail
        // 
        lbl_UserProfileEmail.AutoSize = true;
        lbl_UserProfileEmail.Font = new Font("Times New Roman",13.8F,FontStyle.Bold,GraphicsUnit.Point, 0);
        lbl_UserProfileEmail.ForeColor = Color.White;
        lbl_UserProfileEmail.Location = new Point(432,197);
        lbl_UserProfileEmail.Name = "lbl_UserProfileEmail";
        lbl_UserProfileEmail.Size = new Size(58,22);
        lbl_UserProfileEmail.TabIndex = 23;
        lbl_UserProfileEmail.Text = "Email";
        lbl_UserProfileEmail.Visible = false;
        // 
        // lbl_UserProfileUserName
        // 
        lbl_UserProfileUserName.AutoSize = true;
        lbl_UserProfileUserName.Font = new Font("Times New Roman",13.8F,FontStyle.Bold,GraphicsUnit.Point, 0);
        lbl_UserProfileUserName.ForeColor = Color.White;
        lbl_UserProfileUserName.Location = new Point(400,106);
        lbl_UserProfileUserName.Name = "lbl_UserProfileUserName";
        lbl_UserProfileUserName.Size = new Size(92,22);
        lbl_UserProfileUserName.TabIndex = 24;
        lbl_UserProfileUserName.Text = "Username";
        lbl_UserProfileUserName.Visible = false;
        // 
        // txt_UserProfileFavouriteSport
        // 
        txt_UserProfileFavouriteSport.BackColor = SystemColors.Window;
        txt_UserProfileFavouriteSport.Font = new Font("Times New Roman",16.2F,FontStyle.Bold,GraphicsUnit.Point, 0);
        txt_UserProfileFavouriteSport.Location = new Point(495,438);
        txt_UserProfileFavouriteSport.Margin = new Padding(3,2,3,2);
        txt_UserProfileFavouriteSport.Name = "txt_UserProfileFavouriteSport";
        txt_UserProfileFavouriteSport.Size = new Size(373,32);
        txt_UserProfileFavouriteSport.TabIndex = 16;
        txt_UserProfileFavouriteSport.Visible = false;
        // 
        // txt_UserProfileAddress
        // 
        txt_UserProfileAddress.BackColor = SystemColors.Window;
        txt_UserProfileAddress.Font = new Font("Times New Roman",16.2F,FontStyle.Bold,GraphicsUnit.Point, 0);
        txt_UserProfileAddress.Location = new Point(494,274);
        txt_UserProfileAddress.Margin = new Padding(3,2,3,2);
        txt_UserProfileAddress.Name = "txt_UserProfileAddress";
        txt_UserProfileAddress.Size = new Size(373,32);
        txt_UserProfileAddress.TabIndex = 17;
        txt_UserProfileAddress.Visible = false;
        // 
        // txt_UserProfileEmail
        // 
        txt_UserProfileEmail.BackColor = SystemColors.Window;
        txt_UserProfileEmail.Font = new Font("Times New Roman",16.2F,FontStyle.Bold,GraphicsUnit.Point, 0);
        txt_UserProfileEmail.Location = new Point(492,191);
        txt_UserProfileEmail.Margin = new Padding(3,2,3,2);
        txt_UserProfileEmail.Name = "txt_UserProfileEmail";
        txt_UserProfileEmail.ReadOnly = true;
        txt_UserProfileEmail.Size = new Size(373,32);
        txt_UserProfileEmail.TabIndex = 18;
        txt_UserProfileEmail.Visible = false;
        // 
        // txt_UserProfileUserName
        // 
        txt_UserProfileUserName.BackColor = SystemColors.Window;
        txt_UserProfileUserName.Font = new Font("Times New Roman",16.2F,FontStyle.Bold,GraphicsUnit.Point, 0);
        txt_UserProfileUserName.Location = new Point(494,101);
        txt_UserProfileUserName.Margin = new Padding(3,2,3,2);
        txt_UserProfileUserName.Name = "txt_UserProfileUserName";
        txt_UserProfileUserName.Size = new Size(373,32);
        txt_UserProfileUserName.TabIndex = 19;
        txt_UserProfileUserName.Visible = false;
        // 
        // btn_UserUpdateProfile
        // 
        btn_UserUpdateProfile.BackColor = Color.FromArgb(  255,  128,  0);
        btn_UserUpdateProfile.FlatStyle = FlatStyle.Popup;
        btn_UserUpdateProfile.Font = new Font("Arial Narrow",13.8F,FontStyle.Bold,GraphicsUnit.Point, 0);
        btn_UserUpdateProfile.Location = new Point(923,274);
        btn_UserUpdateProfile.Margin = new Padding(3,2,3,2);
        btn_UserUpdateProfile.Name = "btn_UserUpdateProfile";
        btn_UserUpdateProfile.Size = new Size(154,40);
        btn_UserUpdateProfile.TabIndex = 26;
        btn_UserUpdateProfile.Text = "Update Me";
        btn_UserUpdateProfile.UseVisualStyleBackColor = false;
        btn_UserUpdateProfile.Visible = false;
        btn_UserUpdateProfile.Click += btn_UserUpdateProfile_Click;
        // 
        // UserMode
        // 
        AutoScaleDimensions = new SizeF(7F,15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ControlDarkDark;
        ClientSize = new Size(1124,630);
        Controls.Add(btn_UserUpdateProfile);
        Controls.Add(nud_UserProfileAge);
        Controls.Add(lbl_UserProfileAge);
        Controls.Add(lbl_UserProfileFavouriteSport);
        Controls.Add(lbl_UserProfileAddress);
        Controls.Add(lbl_UserProfileEmail);
        Controls.Add(lbl_UserProfileUserName);
        Controls.Add(txt_UserProfileFavouriteSport);
        Controls.Add(txt_UserProfileAddress);
        Controls.Add(txt_UserProfileEmail);
        Controls.Add(txt_UserProfileUserName);
        Controls.Add(btn_AddToFavourite);
        Controls.Add(lbl_UserProductName);
        Controls.Add(txt_ProductName);
        Controls.Add(dgv_UserProducts);
        Controls.Add(panel1);
        Controls.Add(lbl_Notes);
        Controls.Add(dgv_UserFavouriteProducts);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Name = "UserMode";
        Text = "User Mode";
        Load += UserMode_Load;
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize) dgv_UserProducts).EndInit();
        ((System.ComponentModel.ISupportInitialize) dgv_UserFavouriteProducts).EndInit();
        ((System.ComponentModel.ISupportInitialize) nud_UserProfileAge).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btn_UserShowProducts;
    private Button btn_UserProfile;
    private Button btn_UserFavouriteProducts;
    private Label lbl_UserDashboard;
    private Panel panel1;
    private Button btn_UserLogout;
    private DataGridView dgv_UserProducts;
    private TextBox txt_ProductName;
    private Label lbl_UserProductName;
    private Button btn_AddToFavourite;
    private Label lbl_Notes;
    private DataGridView dgv_UserFavouriteProducts;
    private NumericUpDown nud_UserProfileAge;
    private Label lbl_UserProfileAge;
    private Label lbl_UserProfileFavouriteSport;
    private Label lbl_UserProfileAddress;
    private Label lbl_UserProfileEmail;
    private Label lbl_UserProfileUserName;
    private TextBox txt_UserProfileFavouriteSport;
    private TextBox txt_UserProfileAddress;
    private TextBox txt_UserProfileEmail;
    private TextBox txt_UserProfileUserName;
    private Button btn_UserUpdateProfile;
}