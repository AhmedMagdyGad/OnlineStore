namespace OnlineStore;

partial class AdminMode
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
        panel1 = new Panel();
        btn_ForgetPassword = new Button();
        btn_AdminShowProducts = new Button();
        btn_AdminProfile = new Button();
        btn_AdminShowUsers = new Button();
        btn_AdminShowCategories = new Button();
        lbl_AdminDashboard = new Label();
        dgv_AdminProducts = new DataGridView();
        txt_AdminProduct = new TextBox();
        lbl_AdminProduct = new Label();
        nud_AdminProductPrice = new NumericUpDown();
        lbl_AdminProductPrice = new Label();
        lbl_AdminProductQuantity = new Label();
        nud_AdminProductQuantity = new NumericUpDown();
        cb_AdminProductCategory = new ComboBox();
        lbl_AdminProductCategory = new Label();
        btn_AdminAddProduct = new Button();
        btn_AdminDeleteProduct = new Button();
        btn_AdminUpdateProduct = new Button();
        txt_AdminEmail = new TextBox();
        txt_AdminUsernameShow = new TextBox();
        txt_AdminUserAddress = new TextBox();
        lbl_AdminShowUserName = new Label();
        lbl_AdminEmailShow = new Label();
        lbl_AdminShowAddress = new Label();
        lbl_AdminAgeShow = new Label();
        nud_AdminUserAge = new NumericUpDown();
        cb_AdminRolesShow = new ComboBox();
        lbl_AdminRoleShow = new Label();
        dgv_AdminCategories = new DataGridView();
        dgv_AdminUsers = new DataGridView();
        txt_AdminProfileUserName = new TextBox();
        lbl_AdminProfileUserName = new Label();
        txt_AdminProfileEmail = new TextBox();
        lbl_AdminProfileEmail = new Label();
        txt_AdminProfileAddress = new TextBox();
        lbl_AdminProfileAddress = new Label();
        nud_AdminProfileAge = new NumericUpDown();
        lbl_AdminProfileAge = new Label();
        txt_AdminProfileFavouriteSport = new TextBox();
        lbl_AdminProfileFavouriteSport = new Label();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) dgv_AdminProducts).BeginInit();
        ((System.ComponentModel.ISupportInitialize) nud_AdminProductPrice).BeginInit();
        ((System.ComponentModel.ISupportInitialize) nud_AdminProductQuantity).BeginInit();
        ((System.ComponentModel.ISupportInitialize) nud_AdminUserAge).BeginInit();
        ((System.ComponentModel.ISupportInitialize) dgv_AdminCategories).BeginInit();
        ((System.ComponentModel.ISupportInitialize) dgv_AdminUsers).BeginInit();
        ((System.ComponentModel.ISupportInitialize) nud_AdminProfileAge).BeginInit();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(btn_ForgetPassword);
        panel1.Controls.Add(btn_AdminShowProducts);
        panel1.Controls.Add(btn_AdminProfile);
        panel1.Controls.Add(btn_AdminShowUsers);
        panel1.Controls.Add(btn_AdminShowCategories);
        panel1.Controls.Add(lbl_AdminDashboard);
        panel1.Dock = DockStyle.Left;
        panel1.Location = new Point(0,0);
        panel1.Name = "panel1";
        panel1.Size = new Size(274,630);
        panel1.TabIndex = 0;
        // 
        // btn_ForgetPassword
        // 
        btn_ForgetPassword.BackColor = Color.FromArgb(  255,  128,  128);
        btn_ForgetPassword.FlatStyle = FlatStyle.Popup;
        btn_ForgetPassword.Font = new Font("Arial Black",12F,FontStyle.Bold,GraphicsUnit.Point, 0);
        btn_ForgetPassword.Location = new Point(55,571);
        btn_ForgetPassword.Name = "btn_ForgetPassword";
        btn_ForgetPassword.Size = new Size(143,47);
        btn_ForgetPassword.TabIndex = 10;
        btn_ForgetPassword.Text = "Logout";
        btn_ForgetPassword.UseVisualStyleBackColor = false;
        btn_ForgetPassword.Click += btn_ForgetPassword_Click;
        // 
        // btn_AdminShowProducts
        // 
        btn_AdminShowProducts.FlatStyle = FlatStyle.Flat;
        btn_AdminShowProducts.Font = new Font("Segoe UI",18F,FontStyle.Bold,GraphicsUnit.Point, 0);
        btn_AdminShowProducts.ForeColor = SystemColors.ControlLightLight;
        btn_AdminShowProducts.Location = new Point(12,176);
        btn_AdminShowProducts.Name = "btn_AdminShowProducts";
        btn_AdminShowProducts.Size = new Size(246,45);
        btn_AdminShowProducts.TabIndex = 1;
        btn_AdminShowProducts.Text = "Products";
        btn_AdminShowProducts.UseVisualStyleBackColor = true;
        btn_AdminShowProducts.Click += btn_AdminShowProducts_Click;
        // 
        // btn_AdminProfile
        // 
        btn_AdminProfile.FlatStyle = FlatStyle.Flat;
        btn_AdminProfile.Font = new Font("Segoe UI",18F,FontStyle.Bold,GraphicsUnit.Point, 0);
        btn_AdminProfile.ForeColor = SystemColors.ControlLightLight;
        btn_AdminProfile.Location = new Point(12,398);
        btn_AdminProfile.Name = "btn_AdminProfile";
        btn_AdminProfile.Size = new Size(246,45);
        btn_AdminProfile.TabIndex = 1;
        btn_AdminProfile.Text = "Profile";
        btn_AdminProfile.UseVisualStyleBackColor = true;
        btn_AdminProfile.Click += btn_AdminProfile_Click;
        // 
        // btn_AdminShowUsers
        // 
        btn_AdminShowUsers.FlatStyle = FlatStyle.Flat;
        btn_AdminShowUsers.Font = new Font("Segoe UI",18F,FontStyle.Bold,GraphicsUnit.Point, 0);
        btn_AdminShowUsers.ForeColor = SystemColors.ControlLightLight;
        btn_AdminShowUsers.Location = new Point(12,324);
        btn_AdminShowUsers.Name = "btn_AdminShowUsers";
        btn_AdminShowUsers.Size = new Size(246,45);
        btn_AdminShowUsers.TabIndex = 1;
        btn_AdminShowUsers.Text = "Users";
        btn_AdminShowUsers.UseVisualStyleBackColor = true;
        btn_AdminShowUsers.Click += btn_AdminShowUsers_Click;
        // 
        // btn_AdminShowCategories
        // 
        btn_AdminShowCategories.FlatStyle = FlatStyle.Flat;
        btn_AdminShowCategories.Font = new Font("Segoe UI",18F,FontStyle.Bold,GraphicsUnit.Point, 0);
        btn_AdminShowCategories.ForeColor = SystemColors.ControlLightLight;
        btn_AdminShowCategories.Location = new Point(12,250);
        btn_AdminShowCategories.Name = "btn_AdminShowCategories";
        btn_AdminShowCategories.Size = new Size(246,45);
        btn_AdminShowCategories.TabIndex = 1;
        btn_AdminShowCategories.Text = "Categories";
        btn_AdminShowCategories.UseVisualStyleBackColor = true;
        btn_AdminShowCategories.Click += btn_AdminShowCategories_Click;
        // 
        // lbl_AdminDashboard
        // 
        lbl_AdminDashboard.AutoSize = true;
        lbl_AdminDashboard.BorderStyle = BorderStyle.FixedSingle;
        lbl_AdminDashboard.Font = new Font("Arial Narrow",36F,FontStyle.Bold,GraphicsUnit.Point, 0);
        lbl_AdminDashboard.ForeColor = SystemColors.Info;
        lbl_AdminDashboard.Location = new Point(0,58);
        lbl_AdminDashboard.Name = "lbl_AdminDashboard";
        lbl_AdminDashboard.Size = new Size(256,59);
        lbl_AdminDashboard.TabIndex = 0;
        lbl_AdminDashboard.Text = "Hello Admin";
        // 
        // dgv_AdminProducts
        // 
        dgv_AdminProducts.AllowUserToAddRows = false;
        dgv_AdminProducts.AllowUserToDeleteRows = false;
        dgv_AdminProducts.BackgroundColor = Color.Black;
        dgv_AdminProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgv_AdminProducts.Dock = DockStyle.Top;
        dgv_AdminProducts.Location = new Point(274,0);
        dgv_AdminProducts.Name = "dgv_AdminProducts";
        dgv_AdminProducts.ReadOnly = true;
        dgv_AdminProducts.RowHeadersWidth = 51;
        dgv_AdminProducts.Size = new Size(850,239);
        dgv_AdminProducts.TabIndex = 1;
        dgv_AdminProducts.Visible = false;
        dgv_AdminProducts.RowHeaderMouseDoubleClick += dgv_AdminProducts_RowHeaderMouseDoubleClick;
        // 
        // txt_AdminProduct
        // 
        txt_AdminProduct.BackColor = SystemColors.Window;
        txt_AdminProduct.Font = new Font("Times New Roman",16.2F,FontStyle.Bold,GraphicsUnit.Point, 0);
        txt_AdminProduct.Location = new Point(472,280);
        txt_AdminProduct.Margin = new Padding(3,2,3,2);
        txt_AdminProduct.Name = "txt_AdminProduct";
        txt_AdminProduct.Size = new Size(373,32);
        txt_AdminProduct.TabIndex = 6;
        txt_AdminProduct.Visible = false;
        // 
        // lbl_AdminProduct
        // 
        lbl_AdminProduct.AutoSize = true;
        lbl_AdminProduct.Font = new Font("Times New Roman",13.8F,FontStyle.Bold,GraphicsUnit.Point, 0);
        lbl_AdminProduct.ForeColor = Color.White;
        lbl_AdminProduct.Location = new Point(471,250);
        lbl_AdminProduct.Name = "lbl_AdminProduct";
        lbl_AdminProduct.Size = new Size(75,22);
        lbl_AdminProduct.TabIndex = 7;
        lbl_AdminProduct.Text = "Product";
        lbl_AdminProduct.Visible = false;
        // 
        // nud_AdminProductPrice
        // 
        nud_AdminProductPrice.DecimalPlaces = 3;
        nud_AdminProductPrice.Font = new Font("Arial Narrow",15.75F,FontStyle.Bold,GraphicsUnit.Point, 0);
        nud_AdminProductPrice.Location = new Point(472,350);
        nud_AdminProductPrice.Maximum = new decimal(new int[] { 100000,0,0,0 });
        nud_AdminProductPrice.Name = "nud_AdminProductPrice";
        nud_AdminProductPrice.Size = new Size(373,32);
        nud_AdminProductPrice.TabIndex = 9;
        nud_AdminProductPrice.Value = new decimal(new int[] { 1,0,0,0 });
        nud_AdminProductPrice.Visible = false;
        // 
        // lbl_AdminProductPrice
        // 
        lbl_AdminProductPrice.AutoSize = true;
        lbl_AdminProductPrice.Font = new Font("Times New Roman",13.8F,FontStyle.Bold,GraphicsUnit.Point, 0);
        lbl_AdminProductPrice.ForeColor = Color.White;
        lbl_AdminProductPrice.Location = new Point(469,320);
        lbl_AdminProductPrice.Name = "lbl_AdminProductPrice";
        lbl_AdminProductPrice.Size = new Size(53,22);
        lbl_AdminProductPrice.TabIndex = 8;
        lbl_AdminProductPrice.Text = "Price";
        lbl_AdminProductPrice.Visible = false;
        // 
        // lbl_AdminProductQuantity
        // 
        lbl_AdminProductQuantity.AutoSize = true;
        lbl_AdminProductQuantity.Font = new Font("Times New Roman",13.8F,FontStyle.Bold,GraphicsUnit.Point, 0);
        lbl_AdminProductQuantity.ForeColor = Color.White;
        lbl_AdminProductQuantity.Location = new Point(469,390);
        lbl_AdminProductQuantity.Name = "lbl_AdminProductQuantity";
        lbl_AdminProductQuantity.Size = new Size(81,22);
        lbl_AdminProductQuantity.TabIndex = 8;
        lbl_AdminProductQuantity.Text = "Quantity";
        lbl_AdminProductQuantity.Visible = false;
        // 
        // nud_AdminProductQuantity
        // 
        nud_AdminProductQuantity.Font = new Font("Arial Narrow",15.75F,FontStyle.Bold,GraphicsUnit.Point, 0);
        nud_AdminProductQuantity.Location = new Point(472,420);
        nud_AdminProductQuantity.Maximum = new decimal(new int[] { 100000,0,0,0 });
        nud_AdminProductQuantity.Name = "nud_AdminProductQuantity";
        nud_AdminProductQuantity.Size = new Size(373,32);
        nud_AdminProductQuantity.TabIndex = 9;
        nud_AdminProductQuantity.Value = new decimal(new int[] { 2,0,0,0 });
        nud_AdminProductQuantity.Visible = false;
        // 
        // cb_AdminProductCategory
        // 
        cb_AdminProductCategory.Font = new Font("Arial Narrow",15.75F,FontStyle.Bold,GraphicsUnit.Point, 0);
        cb_AdminProductCategory.FormattingEnabled = true;
        cb_AdminProductCategory.Location = new Point(472,490);
        cb_AdminProductCategory.Name = "cb_AdminProductCategory";
        cb_AdminProductCategory.Size = new Size(373,33);
        cb_AdminProductCategory.TabIndex = 10;
        cb_AdminProductCategory.Visible = false;
        // 
        // lbl_AdminProductCategory
        // 
        lbl_AdminProductCategory.AutoSize = true;
        lbl_AdminProductCategory.Font = new Font("Times New Roman",13.8F,FontStyle.Bold,GraphicsUnit.Point, 0);
        lbl_AdminProductCategory.ForeColor = Color.White;
        lbl_AdminProductCategory.Location = new Point(470,460);
        lbl_AdminProductCategory.Name = "lbl_AdminProductCategory";
        lbl_AdminProductCategory.Size = new Size(86,22);
        lbl_AdminProductCategory.TabIndex = 8;
        lbl_AdminProductCategory.Text = "Category";
        lbl_AdminProductCategory.Visible = false;
        // 
        // btn_AdminAddProduct
        // 
        btn_AdminAddProduct.BackColor = Color.LightGreen;
        btn_AdminAddProduct.FlatStyle = FlatStyle.Popup;
        btn_AdminAddProduct.Font = new Font("Arial Narrow",13.8F,FontStyle.Bold,GraphicsUnit.Point, 0);
        btn_AdminAddProduct.Location = new Point(907,280);
        btn_AdminAddProduct.Margin = new Padding(3,2,3,2);
        btn_AdminAddProduct.Name = "btn_AdminAddProduct";
        btn_AdminAddProduct.Size = new Size(154,40);
        btn_AdminAddProduct.TabIndex = 11;
        btn_AdminAddProduct.Text = "Add Product";
        btn_AdminAddProduct.UseVisualStyleBackColor = false;
        btn_AdminAddProduct.Visible = false;
        btn_AdminAddProduct.Click += btn_AdminAddProduct_Click;
        // 
        // btn_AdminDeleteProduct
        // 
        btn_AdminDeleteProduct.BackColor = Color.Red;
        btn_AdminDeleteProduct.FlatStyle = FlatStyle.Popup;
        btn_AdminDeleteProduct.Font = new Font("Arial Narrow",13.8F,FontStyle.Bold,GraphicsUnit.Point, 0);
        btn_AdminDeleteProduct.Location = new Point(907,378);
        btn_AdminDeleteProduct.Margin = new Padding(3,2,3,2);
        btn_AdminDeleteProduct.Name = "btn_AdminDeleteProduct";
        btn_AdminDeleteProduct.Size = new Size(154,40);
        btn_AdminDeleteProduct.TabIndex = 11;
        btn_AdminDeleteProduct.Text = "Delete Product";
        btn_AdminDeleteProduct.UseVisualStyleBackColor = false;
        btn_AdminDeleteProduct.Visible = false;
        btn_AdminDeleteProduct.Click += btn_AdminDeleteProduct_Click;
        // 
        // btn_AdminUpdateProduct
        // 
        btn_AdminUpdateProduct.BackColor = Color.FromArgb(  255,  128,  0);
        btn_AdminUpdateProduct.FlatStyle = FlatStyle.Popup;
        btn_AdminUpdateProduct.Font = new Font("Arial Narrow",13.8F,FontStyle.Bold,GraphicsUnit.Point, 0);
        btn_AdminUpdateProduct.Location = new Point(907,329);
        btn_AdminUpdateProduct.Margin = new Padding(3,2,3,2);
        btn_AdminUpdateProduct.Name = "btn_AdminUpdateProduct";
        btn_AdminUpdateProduct.Size = new Size(154,40);
        btn_AdminUpdateProduct.TabIndex = 11;
        btn_AdminUpdateProduct.Text = "Update Product";
        btn_AdminUpdateProduct.UseVisualStyleBackColor = false;
        btn_AdminUpdateProduct.Visible = false;
        btn_AdminUpdateProduct.Click += btn_AdminUpdateProduct_Click;
        // 
        // txt_AdminEmail
        // 
        txt_AdminEmail.BackColor = SystemColors.Window;
        txt_AdminEmail.Font = new Font("Times New Roman",16.2F,FontStyle.Bold,GraphicsUnit.Point, 0);
        txt_AdminEmail.Location = new Point(639,284);
        txt_AdminEmail.Margin = new Padding(3,2,3,2);
        txt_AdminEmail.Name = "txt_AdminEmail";
        txt_AdminEmail.ReadOnly = true;
        txt_AdminEmail.Size = new Size(246,32);
        txt_AdminEmail.TabIndex = 12;
        txt_AdminEmail.Visible = false;
        // 
        // txt_AdminUsernameShow
        // 
        txt_AdminUsernameShow.BackColor = SystemColors.Window;
        txt_AdminUsernameShow.Font = new Font("Times New Roman",16.2F,FontStyle.Bold,GraphicsUnit.Point, 0);
        txt_AdminUsernameShow.Location = new Point(370,284);
        txt_AdminUsernameShow.Margin = new Padding(3,2,3,2);
        txt_AdminUsernameShow.Name = "txt_AdminUsernameShow";
        txt_AdminUsernameShow.Size = new Size(246,32);
        txt_AdminUsernameShow.TabIndex = 12;
        txt_AdminUsernameShow.Visible = false;
        // 
        // txt_AdminUserAddress
        // 
        txt_AdminUserAddress.BackColor = SystemColors.Window;
        txt_AdminUserAddress.Font = new Font("Times New Roman",16.2F,FontStyle.Bold,GraphicsUnit.Point, 0);
        txt_AdminUserAddress.Location = new Point(370,349);
        txt_AdminUserAddress.Margin = new Padding(3,2,3,2);
        txt_AdminUserAddress.Name = "txt_AdminUserAddress";
        txt_AdminUserAddress.Size = new Size(246,32);
        txt_AdminUserAddress.TabIndex = 12;
        txt_AdminUserAddress.Visible = false;
        // 
        // lbl_AdminShowUserName
        // 
        lbl_AdminShowUserName.AutoSize = true;
        lbl_AdminShowUserName.Font = new Font("Times New Roman",13.8F,FontStyle.Bold,GraphicsUnit.Point, 0);
        lbl_AdminShowUserName.ForeColor = Color.White;
        lbl_AdminShowUserName.Location = new Point(370,260);
        lbl_AdminShowUserName.Name = "lbl_AdminShowUserName";
        lbl_AdminShowUserName.Size = new Size(92,22);
        lbl_AdminShowUserName.TabIndex = 13;
        lbl_AdminShowUserName.Text = "Username";
        lbl_AdminShowUserName.Visible = false;
        // 
        // lbl_AdminEmailShow
        // 
        lbl_AdminEmailShow.AutoSize = true;
        lbl_AdminEmailShow.Font = new Font("Times New Roman",13.8F,FontStyle.Bold,GraphicsUnit.Point, 0);
        lbl_AdminEmailShow.ForeColor = Color.White;
        lbl_AdminEmailShow.Location = new Point(639,260);
        lbl_AdminEmailShow.Name = "lbl_AdminEmailShow";
        lbl_AdminEmailShow.Size = new Size(58,22);
        lbl_AdminEmailShow.TabIndex = 14;
        lbl_AdminEmailShow.Text = "Email";
        lbl_AdminEmailShow.Visible = false;
        // 
        // lbl_AdminShowAddress
        // 
        lbl_AdminShowAddress.AutoSize = true;
        lbl_AdminShowAddress.Font = new Font("Times New Roman",13.8F,FontStyle.Bold,GraphicsUnit.Point, 0);
        lbl_AdminShowAddress.ForeColor = Color.White;
        lbl_AdminShowAddress.Location = new Point(370,325);
        lbl_AdminShowAddress.Name = "lbl_AdminShowAddress";
        lbl_AdminShowAddress.Size = new Size(76,22);
        lbl_AdminShowAddress.TabIndex = 13;
        lbl_AdminShowAddress.Text = "Address";
        lbl_AdminShowAddress.Visible = false;
        // 
        // lbl_AdminAgeShow
        // 
        lbl_AdminAgeShow.AutoSize = true;
        lbl_AdminAgeShow.Font = new Font("Times New Roman",13.8F,FontStyle.Bold,GraphicsUnit.Point, 0);
        lbl_AdminAgeShow.ForeColor = Color.White;
        lbl_AdminAgeShow.Location = new Point(639,324);
        lbl_AdminAgeShow.Name = "lbl_AdminAgeShow";
        lbl_AdminAgeShow.Size = new Size(42,22);
        lbl_AdminAgeShow.TabIndex = 13;
        lbl_AdminAgeShow.Text = "Age";
        lbl_AdminAgeShow.Visible = false;
        // 
        // nud_AdminUserAge
        // 
        nud_AdminUserAge.Font = new Font("Arial Narrow",15.75F,FontStyle.Bold,GraphicsUnit.Point, 0);
        nud_AdminUserAge.Location = new Point(639,350);
        nud_AdminUserAge.Maximum = new decimal(new int[] { 100000,0,0,0 });
        nud_AdminUserAge.Name = "nud_AdminUserAge";
        nud_AdminUserAge.Size = new Size(246,32);
        nud_AdminUserAge.TabIndex = 15;
        nud_AdminUserAge.Value = new decimal(new int[] { 2,0,0,0 });
        nud_AdminUserAge.Visible = false;
        // 
        // cb_AdminRolesShow
        // 
        cb_AdminRolesShow.Font = new Font("Arial Narrow",15.75F,FontStyle.Bold,GraphicsUnit.Point, 0);
        cb_AdminRolesShow.FormattingEnabled = true;
        cb_AdminRolesShow.Location = new Point(472,420);
        cb_AdminRolesShow.Name = "cb_AdminRolesShow";
        cb_AdminRolesShow.Size = new Size(373,33);
        cb_AdminRolesShow.TabIndex = 16;
        cb_AdminRolesShow.Visible = false;
        // 
        // lbl_AdminRoleShow
        // 
        lbl_AdminRoleShow.AutoSize = true;
        lbl_AdminRoleShow.Font = new Font("Times New Roman",13.8F,FontStyle.Bold,GraphicsUnit.Point, 0);
        lbl_AdminRoleShow.ForeColor = Color.White;
        lbl_AdminRoleShow.Location = new Point(469,391);
        lbl_AdminRoleShow.Name = "lbl_AdminRoleShow";
        lbl_AdminRoleShow.Size = new Size(48,22);
        lbl_AdminRoleShow.TabIndex = 17;
        lbl_AdminRoleShow.Text = "Role";
        lbl_AdminRoleShow.Visible = false;
        // 
        // dgv_AdminCategories
        // 
        dgv_AdminCategories.AllowUserToAddRows = false;
        dgv_AdminCategories.AllowUserToDeleteRows = false;
        dgv_AdminCategories.BackgroundColor = Color.Black;
        dgv_AdminCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgv_AdminCategories.Location = new Point(274,0);
        dgv_AdminCategories.Name = "dgv_AdminCategories";
        dgv_AdminCategories.ReadOnly = true;
        dgv_AdminCategories.RowHeadersWidth = 51;
        dgv_AdminCategories.Size = new Size(850,239);
        dgv_AdminCategories.TabIndex = 18;
        dgv_AdminCategories.Visible = false;
        dgv_AdminCategories.RowHeaderMouseDoubleClick += dgv_AdminCategories_RowHeaderMouseDoubleClick;
        // 
        // dgv_AdminUsers
        // 
        dgv_AdminUsers.AllowUserToAddRows = false;
        dgv_AdminUsers.AllowUserToDeleteRows = false;
        dgv_AdminUsers.BackgroundColor = Color.Black;
        dgv_AdminUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgv_AdminUsers.Location = new Point(274,0);
        dgv_AdminUsers.Name = "dgv_AdminUsers";
        dgv_AdminUsers.ReadOnly = true;
        dgv_AdminUsers.RowHeadersWidth = 51;
        dgv_AdminUsers.Size = new Size(850,239);
        dgv_AdminUsers.TabIndex = 19;
        dgv_AdminUsers.Visible = false;
        dgv_AdminUsers.RowHeaderMouseDoubleClick += dgv_AdminUsers_RowHeaderMouseDoubleClick;
        // 
        // txt_AdminProfileUserName
        // 
        txt_AdminProfileUserName.BackColor = SystemColors.Window;
        txt_AdminProfileUserName.Font = new Font("Times New Roman",16.2F,FontStyle.Bold,GraphicsUnit.Point, 0);
        txt_AdminProfileUserName.Location = new Point(471,85);
        txt_AdminProfileUserName.Margin = new Padding(3,2,3,2);
        txt_AdminProfileUserName.Name = "txt_AdminProfileUserName";
        txt_AdminProfileUserName.Size = new Size(373,32);
        txt_AdminProfileUserName.TabIndex = 6;
        txt_AdminProfileUserName.Visible = false;
        // 
        // lbl_AdminProfileUserName
        // 
        lbl_AdminProfileUserName.AutoSize = true;
        lbl_AdminProfileUserName.Font = new Font("Times New Roman",13.8F,FontStyle.Bold,GraphicsUnit.Point, 0);
        lbl_AdminProfileUserName.ForeColor = Color.White;
        lbl_AdminProfileUserName.Location = new Point(377,90);
        lbl_AdminProfileUserName.Name = "lbl_AdminProfileUserName";
        lbl_AdminProfileUserName.Size = new Size(92,22);
        lbl_AdminProfileUserName.TabIndex = 7;
        lbl_AdminProfileUserName.Text = "Username";
        lbl_AdminProfileUserName.Visible = false;
        // 
        // txt_AdminProfileEmail
        // 
        txt_AdminProfileEmail.BackColor = SystemColors.Window;
        txt_AdminProfileEmail.Font = new Font("Times New Roman",16.2F,FontStyle.Bold,GraphicsUnit.Point, 0);
        txt_AdminProfileEmail.Location = new Point(469,175);
        txt_AdminProfileEmail.Margin = new Padding(3,2,3,2);
        txt_AdminProfileEmail.Name = "txt_AdminProfileEmail";
        txt_AdminProfileEmail.ReadOnly = true;
        txt_AdminProfileEmail.Size = new Size(373,32);
        txt_AdminProfileEmail.TabIndex = 6;
        txt_AdminProfileEmail.Visible = false;
        // 
        // lbl_AdminProfileEmail
        // 
        lbl_AdminProfileEmail.AutoSize = true;
        lbl_AdminProfileEmail.Font = new Font("Times New Roman",13.8F,FontStyle.Bold,GraphicsUnit.Point, 0);
        lbl_AdminProfileEmail.ForeColor = Color.White;
        lbl_AdminProfileEmail.Location = new Point(409,181);
        lbl_AdminProfileEmail.Name = "lbl_AdminProfileEmail";
        lbl_AdminProfileEmail.Size = new Size(58,22);
        lbl_AdminProfileEmail.TabIndex = 7;
        lbl_AdminProfileEmail.Text = "Email";
        lbl_AdminProfileEmail.Visible = false;
        // 
        // txt_AdminProfileAddress
        // 
        txt_AdminProfileAddress.BackColor = SystemColors.Window;
        txt_AdminProfileAddress.Font = new Font("Times New Roman",16.2F,FontStyle.Bold,GraphicsUnit.Point, 0);
        txt_AdminProfileAddress.Location = new Point(471,258);
        txt_AdminProfileAddress.Margin = new Padding(3,2,3,2);
        txt_AdminProfileAddress.Name = "txt_AdminProfileAddress";
        txt_AdminProfileAddress.Size = new Size(373,32);
        txt_AdminProfileAddress.TabIndex = 6;
        txt_AdminProfileAddress.Visible = false;
        // 
        // lbl_AdminProfileAddress
        // 
        lbl_AdminProfileAddress.AutoSize = true;
        lbl_AdminProfileAddress.Font = new Font("Times New Roman",13.8F,FontStyle.Bold,GraphicsUnit.Point, 0);
        lbl_AdminProfileAddress.ForeColor = Color.White;
        lbl_AdminProfileAddress.Location = new Point(393,264);
        lbl_AdminProfileAddress.Name = "lbl_AdminProfileAddress";
        lbl_AdminProfileAddress.Size = new Size(76,22);
        lbl_AdminProfileAddress.TabIndex = 7;
        lbl_AdminProfileAddress.Text = "Address";
        lbl_AdminProfileAddress.Visible = false;
        // 
        // nud_AdminProfileAge
        // 
        nud_AdminProfileAge.Font = new Font("Arial Narrow",15.75F,FontStyle.Bold,GraphicsUnit.Point, 0);
        nud_AdminProfileAge.Location = new Point(471,346);
        nud_AdminProfileAge.Maximum = new decimal(new int[] { 130,0,0,0 });
        nud_AdminProfileAge.Name = "nud_AdminProfileAge";
        nud_AdminProfileAge.Size = new Size(373,32);
        nud_AdminProfileAge.TabIndex = 9;
        nud_AdminProfileAge.Value = new decimal(new int[] { 1,0,0,0 });
        nud_AdminProfileAge.Visible = false;
        // 
        // lbl_AdminProfileAge
        // 
        lbl_AdminProfileAge.AutoSize = true;
        lbl_AdminProfileAge.Font = new Font("Times New Roman",13.8F,FontStyle.Bold,GraphicsUnit.Point, 0);
        lbl_AdminProfileAge.ForeColor = Color.White;
        lbl_AdminProfileAge.Location = new Point(427,353);
        lbl_AdminProfileAge.Name = "lbl_AdminProfileAge";
        lbl_AdminProfileAge.Size = new Size(42,22);
        lbl_AdminProfileAge.TabIndex = 7;
        lbl_AdminProfileAge.Text = "Age";
        lbl_AdminProfileAge.Visible = false;
        // 
        // txt_AdminProfileFavouriteSport
        // 
        txt_AdminProfileFavouriteSport.BackColor = SystemColors.Window;
        txt_AdminProfileFavouriteSport.Font = new Font("Times New Roman",16.2F,FontStyle.Bold,GraphicsUnit.Point, 0);
        txt_AdminProfileFavouriteSport.Location = new Point(472,422);
        txt_AdminProfileFavouriteSport.Margin = new Padding(3,2,3,2);
        txt_AdminProfileFavouriteSport.Name = "txt_AdminProfileFavouriteSport";
        txt_AdminProfileFavouriteSport.Size = new Size(373,32);
        txt_AdminProfileFavouriteSport.TabIndex = 6;
        txt_AdminProfileFavouriteSport.Visible = false;
        // 
        // lbl_AdminProfileFavouriteSport
        // 
        lbl_AdminProfileFavouriteSport.AutoSize = true;
        lbl_AdminProfileFavouriteSport.Font = new Font("Times New Roman",13.8F,FontStyle.Bold,GraphicsUnit.Point, 0);
        lbl_AdminProfileFavouriteSport.ForeColor = Color.White;
        lbl_AdminProfileFavouriteSport.Location = new Point(332,426);
        lbl_AdminProfileFavouriteSport.Name = "lbl_AdminProfileFavouriteSport";
        lbl_AdminProfileFavouriteSport.Size = new Size(139,22);
        lbl_AdminProfileFavouriteSport.TabIndex = 7;
        lbl_AdminProfileFavouriteSport.Text = "Favourite Sport";
        lbl_AdminProfileFavouriteSport.Visible = false;
        // 
        // AdminMode
        // 
        AutoScaleDimensions = new SizeF(7F,15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ControlDarkDark;
        ClientSize = new Size(1124,630);
        Controls.Add(nud_AdminProfileAge);
        Controls.Add(lbl_AdminProfileAge);
        Controls.Add(lbl_AdminProfileFavouriteSport);
        Controls.Add(lbl_AdminProfileAddress);
        Controls.Add(lbl_AdminProfileEmail);
        Controls.Add(lbl_AdminProfileUserName);
        Controls.Add(txt_AdminProfileFavouriteSport);
        Controls.Add(txt_AdminProfileAddress);
        Controls.Add(txt_AdminProfileEmail);
        Controls.Add(txt_AdminProfileUserName);
        Controls.Add(dgv_AdminProducts);
        Controls.Add(panel1);
        Controls.Add(dgv_AdminUsers);
        Controls.Add(dgv_AdminCategories);
        Controls.Add(lbl_AdminRoleShow);
        Controls.Add(cb_AdminRolesShow);
        Controls.Add(nud_AdminUserAge);
        Controls.Add(lbl_AdminEmailShow);
        Controls.Add(lbl_AdminAgeShow);
        Controls.Add(lbl_AdminShowAddress);
        Controls.Add(lbl_AdminShowUserName);
        Controls.Add(txt_AdminUserAddress);
        Controls.Add(txt_AdminUsernameShow);
        Controls.Add(txt_AdminEmail);
        Controls.Add(btn_AdminUpdateProduct);
        Controls.Add(btn_AdminDeleteProduct);
        Controls.Add(btn_AdminAddProduct);
        Controls.Add(cb_AdminProductCategory);
        Controls.Add(nud_AdminProductQuantity);
        Controls.Add(lbl_AdminProductCategory);
        Controls.Add(lbl_AdminProductQuantity);
        Controls.Add(nud_AdminProductPrice);
        Controls.Add(lbl_AdminProductPrice);
        Controls.Add(lbl_AdminProduct);
        Controls.Add(txt_AdminProduct);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Name = "AdminMode";
        Text = "Admin Mode";
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize) dgv_AdminProducts).EndInit();
        ((System.ComponentModel.ISupportInitialize) nud_AdminProductPrice).EndInit();
        ((System.ComponentModel.ISupportInitialize) nud_AdminProductQuantity).EndInit();
        ((System.ComponentModel.ISupportInitialize) nud_AdminUserAge).EndInit();
        ((System.ComponentModel.ISupportInitialize) dgv_AdminCategories).EndInit();
        ((System.ComponentModel.ISupportInitialize) dgv_AdminUsers).EndInit();
        ((System.ComponentModel.ISupportInitialize) nud_AdminProfileAge).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Panel panel1;
    private Label lbl_AdminDashboard;
    private Button btn_AdminShowCategories;
    private Button btn_AdminShowProducts;
    private Button btn_AdminShowUsers;
    private Button btn_ForgetPassword;
    private Button btn_AdminProfile;
    private DataGridView dgv_AdminProducts;
    private TextBox txt_AdminProduct;
    private Label lbl_AdminProduct;
    private NumericUpDown nud_AdminProductPrice;
    private Label lbl_AdminProductPrice;
    private Label lbl_AdminProductQuantity;
    private NumericUpDown nud_AdminProductQuantity;
    private ComboBox cb_AdminProductCategory;
    private Label lbl_AdminProductCategory;
    private Button btn_AdminAddProduct;
    private Button btn_AdminDeleteProduct;
    private Button btn_AdminUpdateProduct;
    private TextBox txt_AdminEmail;
    private TextBox txt_AdminUsernameShow;
    private TextBox txt_AdminUserAddress;
    private TextBox textBox4;
    private Label lbl_AdminShowUserName;
    private Label lbl_AdminEmailShow;
    private Label lbl_AdminShowAddress;
    private Label lbl_AdminAgeShow;
    private NumericUpDown nud_AdminUserAge;
    private ComboBox cb_AdminRolesShow;
    private Label lbl_AdminRoleShow;
    private DataGridView dgv_AdminCategories;
    private DataGridView dgv_AdminUsers;
    private TextBox txt_AdminProfileUserName;
    private Label lbl_AdminProfileUserName;
    private TextBox txt_AdminProfileEmail;
    private Label lbl_AdminProfileEmail;
    private TextBox txt_AdminProfileAddress;
    private Label lbl_AdminProfileAddress;
    private NumericUpDown nud_AdminProfileAge;
    private Label lbl_AdminProfileAge;
    private TextBox txt_AdminProfileFavouriteSport;
    private Label lbl_AdminProfileFavouriteSport;
}