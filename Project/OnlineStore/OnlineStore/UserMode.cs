using BusinessLayer;
using DataAcessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStore;
public partial class UserMode:Form
{
    DataTable dt;
    ProductService _productService;
    UserService _userService;
    UserFavoriteProductsService _userFavoriteProductsService;
    User user;
    string _loginUserName;
    int _selectedProductID;
    public UserMode(string loginUserName)
    {
        InitializeComponent();
        _loginUserName = loginUserName;
        dt = new DataTable();
        _productService = new ProductService();
        _userService = new UserService();
        _userFavoriteProductsService = new UserFavoriteProductsService();
        user = _userService.LoginUser(_loginUserName);
    }
    private void btn_UserLogout_Click(object sender,EventArgs e)
    {
        this.Hide();
        new LoginPage().Show();
    }
    private void UserMode_Load(object sender,EventArgs e)
    {
        User user = _userService.LoginUser(_loginUserName);
        lbl_UserDashboard.Text = $"Hi, {user.Name.ToUpper().Split(" ")[0]}";
    }
    private void btn_UserShowProducts_Click(object sender,EventArgs e)
    {
        dgv_UserProducts.Visible = true;
        lbl_Notes.Visible = true;
        dgv_UserFavouriteProducts.Visible = false;
        lbl_UserProfileUserName.Visible = false;
        txt_UserProfileUserName.Visible = false;
        lbl_UserProfileEmail.Visible = false;
        txt_UserProfileEmail.Visible = false;
        lbl_UserProfileAddress.Visible = false;
        txt_UserProfileAddress.Visible = false;
        lbl_UserProfileAge.Visible = false;
        nud_UserProfileAge.Visible = false;
        lbl_UserProfileFavouriteSport.Visible = false;
        txt_UserProfileFavouriteSport.Visible = false;
        lbl_UserProductName.Visible = false;
        txt_ProductName.Visible = false;
        btn_UserUpdateProfile.Visible = false;
        btn_AddToFavourite.Visible = false;
        dt = _productService.GetProducts();
        dgv_UserProducts.DataSource = dt;
        loadDataGridView(dt,UserModeDataGridViewValues.Products);
    }
    private void dgv_UserProducts_RowHeaderMouseDoubleClick(object sender,DataGridViewCellMouseEventArgs e)
    {
        lbl_UserProductName.Visible = true;
        txt_ProductName.Visible = true;
        btn_AddToFavourite.Visible = true;
        DataGridViewRow row = dgv_UserProducts.Rows[e.RowIndex];
        txt_ProductName.Text = row.Cells["Name"].Value!.ToString();
        _selectedProductID = (int) row.Cells["ID"].Value!;
    }
    private void btn_AddToFavourite_Click(object sender,EventArgs e)
    {
        if(string.IsNullOrWhiteSpace(txt_ProductName.Text))
        {
            MessageBox.Show(
                        "There is now product!!",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            return;
        }
        if(btn_AddToFavourite.Text == "+ Add to Favourite")
        {
            DataTable tempData = _userFavoriteProductsService.GetProduct(_selectedProductID);
            if(tempData.Rows.Count == 0)
            {
                int affectedRows = -1;
                affectedRows = _userFavoriteProductsService.AddFavouriteProduct(user.ID,_selectedProductID);
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
                    btn_AddToFavourite.Visible = false;
                    lbl_UserProductName.Visible = false;
                    txt_ProductName.Visible = false;
                    MessageBox.Show(
                        "The product has been Added successfully!!",
                        "Done",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    dt = _productService.GetProducts();
                    loadDataGridView(dt,UserModeDataGridViewValues.Products);
                    return;
                }
            }
            else
            {
                MessageBox.Show(
                        "This product is already exist in your favorite list!!",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                return;
            }
        }
        else
        {
            int affectedRows = -1;
            affectedRows = _userFavoriteProductsService.DeleteFavourite(_selectedProductID);
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
                btn_AddToFavourite.Visible = false;
                lbl_UserProductName.Visible = false;
                txt_ProductName.Visible = false;
                MessageBox.Show(
                    "The product has been Deleted successfully!!",
                    "Done",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                dt = _userFavoriteProductsService.GetFavouriteProducts(user.ID);
                loadDataGridView(dt,UserModeDataGridViewValues.FavouriteProducts);
                return;
            }
        }
    }
    private void btn_UserFavouriteProducts_Click(object sender,EventArgs e)
    {
        dgv_UserProducts.Visible = false;
        lbl_Notes.Visible = true;
        dgv_UserFavouriteProducts.Visible = true;
        lbl_UserProfileUserName.Visible = false;
        txt_UserProfileUserName.Visible = false;
        lbl_UserProfileEmail.Visible = false;
        txt_UserProfileEmail.Visible = false;
        lbl_UserProfileAddress.Visible = false;
        txt_UserProfileAddress.Visible = false;
        lbl_UserProfileAge.Visible = false;
        nud_UserProfileAge.Visible = false;
        lbl_UserProfileFavouriteSport.Visible = false;
        txt_UserProfileFavouriteSport.Visible = false;
        lbl_UserProductName.Visible = false;
        txt_ProductName.Visible = false;
        btn_UserUpdateProfile.Visible = false;
        btn_AddToFavourite.Visible = false;
        dt = _userFavoriteProductsService.GetFavouriteProducts(user.ID);
        dgv_UserProducts.DataSource = dt;
        loadDataGridView(dt,UserModeDataGridViewValues.FavouriteProducts);
    }
    private void dgv_UserFavouriteProducts_RowHeaderMouseDoubleClick(object sender,DataGridViewCellMouseEventArgs e)
    {
        lbl_UserProductName.Visible = true;
        txt_ProductName.Visible = true;
        btn_AddToFavourite.Visible = true;
        btn_AddToFavourite.Text = "- Remove";
        btn_AddToFavourite.BackColor = Color.Red;
        DataGridViewRow row = dgv_UserProducts.Rows[e.RowIndex];
        txt_ProductName.Text = row.Cells["Name"].Value!.ToString();
        _selectedProductID = (int) row.Cells["ID"].Value!;
    }
    private void loadDataGridView(DataTable data,UserModeDataGridViewValues values)
    {
        if(values == UserModeDataGridViewValues.Products)
        {
            dgv_UserProducts.DataSource = data;
            dgv_UserProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_UserProducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_UserProducts.DefaultCellStyle.BackColor = Color.Black;
            dgv_UserProducts.DefaultCellStyle.ForeColor = Color.White;
            dgv_UserProducts.DefaultCellStyle.Font = new Font(dgv_UserProducts.Font,FontStyle.Regular);
            dgv_UserProducts.ColumnHeadersDefaultCellStyle.Font = new Font(dgv_UserProducts.Font,FontStyle.Bold);
            dgv_UserProducts.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_UserProducts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        }
        else
        {
            dgv_UserFavouriteProducts.DataSource = data;
            dgv_UserFavouriteProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_UserFavouriteProducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_UserFavouriteProducts.DefaultCellStyle.BackColor = Color.Black;
            dgv_UserFavouriteProducts.DefaultCellStyle.ForeColor = Color.White;
            dgv_UserFavouriteProducts.DefaultCellStyle.Font = new Font(dgv_UserFavouriteProducts.Font,FontStyle.Regular);
            dgv_UserFavouriteProducts.ColumnHeadersDefaultCellStyle.Font = new Font(dgv_UserFavouriteProducts.Font,FontStyle.Bold);
            dgv_UserFavouriteProducts.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_UserFavouriteProducts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        }
    }
    private void btn_UserProfile_Click(object sender,EventArgs e)
    {
        dgv_UserProducts.Visible = false;
        lbl_Notes.Visible = false;
        dgv_UserFavouriteProducts.Visible = false;
        lbl_UserProfileUserName.Visible = true;
        txt_UserProfileUserName.Visible = true;
        lbl_UserProfileEmail.Visible = true;
        txt_UserProfileEmail.Visible = true;
        lbl_UserProfileAddress.Visible = true;
        txt_UserProfileAddress.Visible = true;
        lbl_UserProfileAge.Visible = true;
        nud_UserProfileAge.Visible = true;
        lbl_UserProfileFavouriteSport.Visible = true;
        txt_UserProfileFavouriteSport.Visible = true;
        lbl_UserProductName.Visible = false;
        txt_ProductName.Visible = false;
        btn_UserUpdateProfile.Visible = true;
        btn_AddToFavourite.Visible = false;
        txt_UserProfileUserName.Text = user.Name;
        txt_UserProfileEmail.Text = user.Email;
        txt_UserProfileAddress.Text = user.Address;
        txt_UserProfileFavouriteSport.Text = user.FavoriteSport;
        nud_UserProfileAge.Value = user.Age;
    }
    private void btn_UserUpdateProfile_Click(object sender,EventArgs e)
    {
        if(string.IsNullOrEmpty(txt_UserProfileUserName.Text))
        {
            MessageBox.Show(
                        "Please enter the user name!!",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            return;
        }
        if(string.IsNullOrEmpty(txt_UserProfileAddress.Text))
        {
            MessageBox.Show(
                        "Please enter the user Address!!",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            return;
        }
        if(string.IsNullOrEmpty(txt_UserProfileFavouriteSport.Text))
        {
            MessageBox.Show(
                        "Please enter the user favorite sport!!",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            return;
        }
        if(nud_UserProfileAge.Value <= 0)
        {
            MessageBox.Show(
                        "Please enter a valid Age!!",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            return;
        }
        user.Name = txt_UserProfileUserName.Text;
        user.Address = txt_UserProfileAddress.Text;
        user.FavoriteSport = txt_UserProfileFavouriteSport.Text;
        user.Age = (int)nud_UserProfileAge.Value;
        int affectedRows = -1;
        affectedRows = _userService.UpdateUser(user);
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
                "Your profile has been Updated successfully!!",
                "Done",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            lbl_UserDashboard.Text = $"Hi, {user.Name.ToUpper().Split(" ")[0]}";
            return;
        }
    }
}
