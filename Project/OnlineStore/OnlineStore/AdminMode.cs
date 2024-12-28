// Ignore Spelling: Admin

using BusinessLayer;
using DataAcessLayer;
using System.Data;

namespace OnlineStore;
public partial class AdminMode:Form
{
    DataTable dt;
    ProductService _productService;
    CategoryService _categoryService;
    UserService _userService;
    int _productID;
    int _categoryID;
    int _userID;
    string _loginUserName;
    public AdminMode(string loginUserName)
    {
        InitializeComponent();
        dt = new DataTable();
        _productService = new ProductService();
        _categoryService = new CategoryService();
        _userService = new UserService();
        _loginUserName = loginUserName;
    }
    private void btn_ForgetPassword_Click(object sender,EventArgs e)
    {
        this.Hide();
        new LoginPage().Show();
    }
    private void btn_AdminShowProducts_Click(object sender,EventArgs e)
    {
        dgv_AdminProducts.Visible = true;
        dgv_AdminCategories.Visible = false;
        dgv_AdminUsers.Visible = false;
        txt_AdminProduct.Visible = true;
        txt_AdminProduct.Text = string.Empty;
        lbl_AdminProduct.Visible = true;
        lbl_AdminProduct.Text = "Product";
        nud_AdminProductPrice.Visible = true;
        lbl_AdminProductPrice.Visible = true;
        nud_AdminProductQuantity.Visible = true;
        lbl_AdminProductQuantity.Visible = true;
        cb_AdminProductCategory.Visible = true;
        lbl_AdminProductCategory.Visible = true;
        btn_AdminDeleteProduct.Visible = false;
        btn_AdminUpdateProduct.Visible = false;
        btn_AdminAddProduct.Visible = true;
        btn_AdminAddProduct.Text = "Add Product";
        lbl_AdminShowUserName.Visible = false;
        txt_AdminUsernameShow.Visible = false;
        lbl_AdminEmailShow.Visible = false;
        txt_AdminEmail.Visible = false;
        lbl_AdminShowAddress.Visible = false;
        txt_AdminUserAddress.Visible = false;
        lbl_AdminAgeShow.Visible = false;
        nud_AdminUserAge.Visible = false;
        lbl_AdminRoleShow.Visible = false;
        cb_AdminRolesShow.Visible = false;
        lbl_AdminProfileUserName.Visible = false;
        txt_AdminProfileUserName.Visible = false;
        lbl_AdminProfileEmail.Visible = false;
        txt_AdminProfileEmail.Visible = false;
        lbl_AdminProfileAddress.Visible = false;
        txt_AdminProfileAddress.Visible = false;
        lbl_AdminProfileFavouriteSport.Visible = false;
        txt_AdminProfileFavouriteSport.Visible = false;
        lbl_AdminProfileAge.Visible = false;
        nud_AdminProfileAge.Visible = false;
        dt = _productService.GetProducts();
        loadDataGridView(dt,DataGridViewValues.Products);
    }
    private void dgv_AdminProducts_RowHeaderMouseDoubleClick(object sender,DataGridViewCellMouseEventArgs e)
    {
        btn_AdminUpdateProduct.Visible = true;
        btn_AdminUpdateProduct.Text = "Update Product";
        btn_AdminDeleteProduct.Visible = true;
        btn_AdminDeleteProduct.Text = "Delete Product";
        btn_AdminAddProduct.Visible = false;
        DataGridViewRow row = dgv_AdminProducts.Rows[e.RowIndex];
        txt_AdminProduct.Text = row.Cells["Name"].Value!.ToString();
        nud_AdminProductPrice.Value = (decimal) row.Cells["Price"].Value!;
        nud_AdminProductQuantity.Value = (int) row.Cells["Quantity"].Value!;
        cb_AdminProductCategory.SelectedValue = (int) row.Cells["CategoryID"].Value!;
        _productID = (int) row.Cells["ID"].Value!;
    }
    private void btn_AdminAddProduct_Click(object sender,EventArgs e)
    {
        if(btn_AdminAddProduct.Text == "Add Product")
        {
            validateProductInputs();
            Product newProudct = new Product
            {
                Name = txt_AdminProduct.Text,
                Price = nud_AdminProductPrice.Value,
                Quantity = (int) nud_AdminProductQuantity.Value,
                CategoryID = (int) cb_AdminProductCategory.SelectedValue!
            };
            int resutl = -1;
            resutl = _productService.AddProduct(newProudct);
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
                MessageBox.Show(
                    "The product has been added successfully!!",
                    "Done",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txt_AdminProduct.Text = string.Empty;
                nud_AdminProductPrice.Value = 0;
                nud_AdminProductQuantity.Value = 0;
                dt = _productService.GetProducts();
                loadDataGridView(dt,DataGridViewValues.Products);
                return;
            }
        }
        else if(btn_AdminAddProduct.Text == "Add Category")
        {
            validateCategoryInput();
            Category category = new Category
            {
                Name = txt_AdminProduct.Text,
            };
            int resutl = -1;
            resutl = _categoryService.AddCategory(category);
            if(resutl <= 0)
            {
                MessageBox.Show(
                    "Something happen, Please try again with another Name!!",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MessageBox.Show(
                    "The category has been added successfully!!",
                    "Done",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txt_AdminProduct.Text = string.Empty;
                dt = _categoryService.GetCategories();
                loadDataGridView(dt,DataGridViewValues.Categories);
                return;
            }
        }
    }
    private void btn_AdminUpdateProduct_Click(object sender,EventArgs e)
    {
        if(btn_AdminUpdateProduct.Text == "Update Product")
        {
            validateProductInputs();
            Product newProudct = new Product
            {
                ID = _productID,
                Name = txt_AdminProduct.Text,
                Price = nud_AdminProductPrice.Value,
                Quantity = (int) nud_AdminProductQuantity.Value,
                CategoryID = (int) cb_AdminProductCategory.SelectedValue!
            };
            int resutl = -1;
            resutl = _productService.UpdateProduct(newProudct);
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
                btn_AdminUpdateProduct.Visible = false;
                btn_AdminDeleteProduct.Visible = false;
                btn_AdminAddProduct.Visible = true;
                MessageBox.Show(
                    "The product has been Updated successfully!!",
                    "Done",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txt_AdminProduct.Text = string.Empty;
                nud_AdminProductPrice.Value = 0;
                nud_AdminProductQuantity.Value = 0;
                dt = _productService.GetProducts();
                loadDataGridView(dt,DataGridViewValues.Products);
                return;
            }
        }
        else if(btn_AdminUpdateProduct.Text == "Update Category")
        {
            validateCategoryInput();
            Category category = new Category
            {
                ID = _categoryID,
                Name = txt_AdminProduct.Text
            };
            int resutl = -1;
            resutl = _categoryService.UpdateCategory(category);
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
                btn_AdminUpdateProduct.Visible = false;
                btn_AdminDeleteProduct.Visible = false;
                btn_AdminAddProduct.Visible = true;
                MessageBox.Show(
                    "The category has been Updated successfully!!",
                    "Done",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txt_AdminProduct.Text = string.Empty;
                dt = _categoryService.GetCategories();
                loadDataGridView(dt,DataGridViewValues.Categories);
                return;
            }
        }
        else if(btn_AdminUpdateProduct.Text == "Update User")
        {
            validateUserInputs();
            User user = _userService.LoginUser(txt_AdminEmail.Text);
            if(user == null)
            {
                MessageBox.Show(
                    "Something happen, you Cannot change the Email!!",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            user.Name = txt_AdminUsernameShow.Text;
            user.Address = txt_AdminUserAddress.Text;
            user.Age = (int) nud_AdminUserAge.Value;
            user.RoleID = (int) cb_AdminRolesShow.SelectedValue!;
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
                    "User has been successfully updated!!",
                    "Done",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txt_AdminUsernameShow.Text = string.Empty;
                txt_AdminEmail.Text = string.Empty;
                txt_AdminUserAddress.Text = string.Empty;
                nud_AdminUserAge.Value = 1;
                dt = _userService.GetUsers();
                loadDataGridView(dt,DataGridViewValues.Users);
                return;
            }
        }
        else
        {
            User user = _userService.LoginUser(txt_AdminProfileEmail.Text);
            if(validateAdminProfileInputs())
            {
                user.Name = txt_AdminProfileUserName.Text;
                user.Address = txt_AdminProfileAddress.Text;
                user.FavoriteSport = txt_AdminProfileFavouriteSport.Text;
                user.Age = (int) nud_AdminProfileAge.Value;
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
                        "Your account has been successfully updated!!",
                        "Done",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }
            }
            nud_AdminProfileAge.Value = user.Age;
        }
    }
    private void btn_AdminDeleteProduct_Click(object sender,EventArgs e)
    {
        if(btn_AdminDeleteProduct.Text == "Delete Product")
        {
            validateProductInputs();
            int resutl = -1;
            resutl = _productService.DeleteProduct(_productID);
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
                btn_AdminUpdateProduct.Visible = false;
                btn_AdminDeleteProduct.Visible = false;
                btn_AdminAddProduct.Visible = true;
                MessageBox.Show(
                    "The product has been Deleted successfully!!",
                    "Done",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txt_AdminProduct.Text = string.Empty;
                nud_AdminProductPrice.Value = 0;
                nud_AdminProductQuantity.Value = 0;
                dt = _productService.GetProducts();
                loadDataGridView(dt,DataGridViewValues.Products);
                return;
            }
        }
        else if(btn_AdminDeleteProduct.Text == "Delete Category")
        {
            validateCategoryInput();
            int resutl = -1;
            resutl = _categoryService.DeleteCategory(_categoryID);
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
                btn_AdminUpdateProduct.Visible = false;
                btn_AdminDeleteProduct.Visible = false;
                btn_AdminAddProduct.Visible = true;
                MessageBox.Show(
                    "The category has been Deleted successfully!!",
                    "Done",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txt_AdminProduct.Text = string.Empty;
                dt = _categoryService.GetCategories();
                loadDataGridView(dt,DataGridViewValues.Categories);
                return;
            }
        }
        else
        {
            validateUserInputs();
            int resutl = -1;
            resutl = _userService.DeleteUser(_userID);
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
                MessageBox.Show(
                    "The user has been Deleted successfully!!",
                    "Done",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txt_AdminUsernameShow.Text = string.Empty;
                txt_AdminEmail.Text = string.Empty;
                txt_AdminUserAddress.Text = string.Empty;
                nud_AdminUserAge.Value = 1;
                dt = _userService.GetUsers();
                loadDataGridView(dt,DataGridViewValues.Users);
                return;
            }
        }
    }
    private void btn_AdminShowCategories_Click(object sender,EventArgs e)
    {
        dgv_AdminProducts.Visible = false;
        dgv_AdminCategories.Visible = true;
        dgv_AdminUsers.Visible = false;
        txt_AdminProduct.Visible = true;
        txt_AdminProduct.Text = string.Empty;
        lbl_AdminProduct.Visible = true;
        lbl_AdminProduct.Text = "Category";
        nud_AdminProductPrice.Visible = false;
        lbl_AdminProductPrice.Visible = false;
        nud_AdminProductQuantity.Visible = false;
        lbl_AdminProductQuantity.Visible = false;
        cb_AdminProductCategory.Visible = false;
        lbl_AdminProductCategory.Visible = false;
        btn_AdminDeleteProduct.Visible = false;
        btn_AdminUpdateProduct.Visible = false;
        btn_AdminAddProduct.Visible = true;
        btn_AdminAddProduct.Text = "Add Category";
        lbl_AdminShowUserName.Visible = false;
        txt_AdminUsernameShow.Visible = false;
        lbl_AdminEmailShow.Visible = false;
        txt_AdminEmail.Visible = false;
        lbl_AdminShowAddress.Visible = false;
        txt_AdminUserAddress.Visible = false;
        lbl_AdminAgeShow.Visible = false;
        nud_AdminUserAge.Visible = false;
        lbl_AdminRoleShow.Visible = false;
        cb_AdminRolesShow.Visible = false;
        lbl_AdminProfileUserName.Visible = false;
        txt_AdminProfileUserName.Visible = false;
        lbl_AdminProfileEmail.Visible = false;
        txt_AdminProfileEmail.Visible = false;
        lbl_AdminProfileAddress.Visible = false;
        txt_AdminProfileAddress.Visible = false;
        lbl_AdminProfileFavouriteSport.Visible = false;
        txt_AdminProfileFavouriteSport.Visible = false;
        lbl_AdminProfileAge.Visible = false;
        nud_AdminProfileAge.Visible = false;
        dt = _categoryService.GetCategories();
        loadDataGridView(dt,DataGridViewValues.Categories);
    }
    private void dgv_AdminCategories_RowHeaderMouseDoubleClick(object sender,DataGridViewCellMouseEventArgs e)
    {
        btn_AdminUpdateProduct.Visible = true;
        btn_AdminUpdateProduct.Text = "Update Category";
        btn_AdminDeleteProduct.Visible = true;
        btn_AdminDeleteProduct.Text = "Delete Category";
        btn_AdminAddProduct.Visible = false;
        DataGridViewRow row = dgv_AdminCategories.Rows[e.RowIndex];
        txt_AdminProduct.Text = row.Cells["Name"].Value!.ToString();
        _categoryID = (int) row.Cells["ID"].Value!;
    }
    private void btn_AdminShowUsers_Click(object sender,EventArgs e)
    {
        dgv_AdminProducts.Visible = false;
        dgv_AdminCategories.Visible = false;
        dgv_AdminUsers.Visible = true;
        txt_AdminProduct.Visible = false;
        lbl_AdminProduct.Visible = false;
        nud_AdminProductPrice.Visible = false;
        lbl_AdminProductPrice.Visible = false;
        nud_AdminProductQuantity.Visible = false;
        lbl_AdminProductQuantity.Visible = false;
        cb_AdminProductCategory.Visible = false;
        lbl_AdminProductCategory.Visible = false;
        btn_AdminUpdateProduct.Visible = true;
        btn_AdminUpdateProduct.Text = "Update User";
        btn_AdminDeleteProduct.Visible = true;
        btn_AdminDeleteProduct.Text = "Delete User";
        btn_AdminAddProduct.Visible = false;
        lbl_AdminShowUserName.Visible = true;
        txt_AdminUsernameShow.Visible = true;
        lbl_AdminEmailShow.Visible = true;
        txt_AdminEmail.Visible = true;
        lbl_AdminShowAddress.Visible = true;
        txt_AdminUserAddress.Visible = true;
        lbl_AdminAgeShow.Visible = true;
        nud_AdminUserAge.Visible = true;
        lbl_AdminRoleShow.Visible = true;
        cb_AdminRolesShow.Visible = true;
        lbl_AdminProfileUserName.Visible = false;
        txt_AdminProfileUserName.Visible = false;
        lbl_AdminProfileEmail.Visible = false;
        txt_AdminProfileEmail.Visible = false;
        lbl_AdminProfileAddress.Visible = false;
        txt_AdminProfileAddress.Visible = false;
        lbl_AdminProfileFavouriteSport.Visible = false;
        txt_AdminProfileFavouriteSport.Visible = false;
        lbl_AdminProfileAge.Visible = false;
        nud_AdminProfileAge.Visible = false;
        dt = _userService.GetUsers();
        loadDataGridView(dt,DataGridViewValues.Users);
    }
    private void btn_AdminProfile_Click(object sender,EventArgs e)
    {
        dgv_AdminProducts.Visible = false;
        dgv_AdminCategories.Visible = false;
        dgv_AdminUsers.Visible = false;
        txt_AdminProduct.Visible = false;
        lbl_AdminProduct.Visible = false;
        nud_AdminProductPrice.Visible = false;
        lbl_AdminProductPrice.Visible = false;
        nud_AdminProductQuantity.Visible = false;
        lbl_AdminProductQuantity.Visible = false;
        cb_AdminProductCategory.Visible = false;
        lbl_AdminProductCategory.Visible = false;
        btn_AdminUpdateProduct.Visible = true;
        btn_AdminUpdateProduct.Text = "Update Me";
        btn_AdminDeleteProduct.Visible = false;
        btn_AdminAddProduct.Visible = false;
        lbl_AdminShowUserName.Visible = false;
        txt_AdminUsernameShow.Visible = false;
        lbl_AdminEmailShow.Visible = false;
        txt_AdminEmail.Visible = false;
        lbl_AdminShowAddress.Visible = false;
        txt_AdminUserAddress.Visible = false;
        lbl_AdminAgeShow.Visible = false;
        nud_AdminUserAge.Visible = false;
        lbl_AdminRoleShow.Visible = false;
        cb_AdminRolesShow.Visible = false;
        lbl_AdminProfileUserName.Visible = true;
        txt_AdminProfileUserName.Visible = true;
        lbl_AdminProfileEmail.Visible = true;
        txt_AdminProfileEmail.Visible = true;
        lbl_AdminProfileAddress.Visible = true;
        txt_AdminProfileAddress.Visible = true;
        lbl_AdminProfileFavouriteSport.Visible = true;
        txt_AdminProfileFavouriteSport.Visible = true;
        lbl_AdminProfileAge.Visible = true;
        nud_AdminProfileAge.Visible = true;
        User user = _userService.LoginUser(_loginUserName);
        txt_AdminProfileUserName.Text = user.Name;
        txt_AdminProfileEmail.Text = user.Email;
        txt_AdminProfileAddress.Text = user.Address;
        txt_AdminProfileFavouriteSport.Text = user.FavoriteSport;
        nud_AdminProfileAge.Value = user.Age;
    }
    private void dgv_AdminUsers_RowHeaderMouseDoubleClick(object sender,DataGridViewCellMouseEventArgs e)
    {
        DataGridViewRow row = dgv_AdminUsers.Rows[e.RowIndex];
        _userID = (int) row.Cells["ID"].Value!;
        txt_AdminUsernameShow.Text = row.Cells["Name"].Value!.ToString();
        txt_AdminEmail.Text = row.Cells["Email"].Value!.ToString();
        txt_AdminUserAddress.Text = row.Cells["Address"].Value!.ToString();
        nud_AdminUserAge.Value = (int) row.Cells["Age"].Value!;
        cb_AdminRolesShow.SelectedValue = (int) row.Cells["RoleID"].Value!;
    }
    private void loadDataGridView(DataTable data,DataGridViewValues values)
    {
        if(values == DataGridViewValues.Products)
        {
            dgv_AdminProducts.DataSource = data;
            DataTable Categories = _categoryService.GetCategories();
            cb_AdminProductCategory.DataSource = Categories;
            cb_AdminProductCategory.DisplayMember = "Name";
            cb_AdminProductCategory.ValueMember = "ID";
            dgv_AdminProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_AdminProducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_AdminProducts.DefaultCellStyle.BackColor = Color.Black;
            dgv_AdminProducts.DefaultCellStyle.ForeColor = Color.White;
            dgv_AdminProducts.DefaultCellStyle.Font = new Font(dgv_AdminProducts.Font,FontStyle.Regular);
            dgv_AdminProducts.ColumnHeadersDefaultCellStyle.Font = new Font(dgv_AdminProducts.Font,FontStyle.Bold);
            dgv_AdminProducts.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_AdminProducts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv_AdminProducts.Refresh();
        }
        else if(values == DataGridViewValues.Categories)
        {
            dgv_AdminCategories.DataSource = data;
            dgv_AdminCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_AdminCategories.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_AdminCategories.DefaultCellStyle.BackColor = Color.Black;
            dgv_AdminCategories.DefaultCellStyle.ForeColor = Color.White;
            dgv_AdminCategories.DefaultCellStyle.Font = new Font(dgv_AdminProducts.Font,FontStyle.Regular);
            dgv_AdminCategories.ColumnHeadersDefaultCellStyle.Font = new Font(dgv_AdminProducts.Font,FontStyle.Bold);
            dgv_AdminCategories.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_AdminCategories.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv_AdminCategories.Refresh();
        }
        else
        {
            DataTable Roles = _userService.GetUsersRoles();
            cb_AdminRolesShow.DataSource = Roles;
            cb_AdminRolesShow.DisplayMember = "Name";
            cb_AdminRolesShow.ValueMember = "ID";
            dgv_AdminUsers.DataSource = data;
            dgv_AdminUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_AdminUsers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_AdminUsers.DefaultCellStyle.BackColor = Color.Black;
            dgv_AdminUsers.DefaultCellStyle.ForeColor = Color.White;
            dgv_AdminUsers.DefaultCellStyle.Font = new Font(dgv_AdminProducts.Font,FontStyle.Regular);
            dgv_AdminUsers.ColumnHeadersDefaultCellStyle.Font = new Font(dgv_AdminProducts.Font,FontStyle.Bold);
            dgv_AdminUsers.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_AdminUsers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv_AdminUsers.Refresh();
        }
    }
    private void validateProductInputs()
    {
        if(string.IsNullOrWhiteSpace(txt_AdminProduct.Text))
        {
            MessageBox.Show(
                "You must enter the Product name!!",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return;
        }
        if(nud_AdminProductPrice.Value <= 0)
        {
            MessageBox.Show(
                "You must enter a valid price!!",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return;
        }
        if(nud_AdminProductQuantity.Value <= 0)
        {
            MessageBox.Show(
                "You must enter a valid quantity!!",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return;
        }
    }
    private void validateCategoryInput()
    {
        if(string.IsNullOrWhiteSpace(txt_AdminProduct.Text))
        {
            MessageBox.Show(
                "You must enter the Category name!!",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return;
        }
    }
    private void validateUserInputs()
    {
        if(string.IsNullOrWhiteSpace(txt_AdminUsernameShow.Text))
        {
            MessageBox.Show(
                "You must enter the User name!!",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return;
        }
        if(string.IsNullOrWhiteSpace(txt_AdminUserAddress.Text))
        {
            MessageBox.Show(
                "You must enter the User address!!",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return;
        }
        if(string.IsNullOrWhiteSpace(txt_AdminEmail.Text))
        {
            MessageBox.Show(
                "You must enter the User email!!",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return;
        }
        if(nud_AdminUserAge.Value <= 0)
        {
            MessageBox.Show(
                "You must enter a valid age!!",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return;
        }
    }
    private bool validateAdminProfileInputs()
    {
        if(string.IsNullOrWhiteSpace(txt_AdminProfileUserName.Text))
        {
            MessageBox.Show(
                "You must enter the Admin name!!",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return false;
        }
        if(string.IsNullOrWhiteSpace(txt_AdminProfileAddress.Text))
        {
            MessageBox.Show(
                "You must enter the Admin address!!",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return false;
        }
        if(string.IsNullOrWhiteSpace(txt_AdminProfileFavouriteSport.Text))
        {
            MessageBox.Show(
                "You must enter the Admin favorite sport!!",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return false;
        }
        if(nud_AdminProfileAge.Value <= 0)
        {
            MessageBox.Show(
                "You must enter a valid Age!!",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return false;
        }
        return true;
    }
}
