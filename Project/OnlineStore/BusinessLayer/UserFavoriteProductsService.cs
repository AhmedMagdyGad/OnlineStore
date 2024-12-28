using DataAcessLayer;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer;
public class UserFavoriteProductsService
{
    ApplicationDBContext _context;
    public UserFavoriteProductsService()
    {
        _context = new ApplicationDBContext();
    }

    public DataTable GetFavouriteProducts(int userID)
        => _context.Select($"select P.* from Products P inner join UserFavorites UF on P.ID = UF.ProductID inner join Users U on UF.UserID = U.ID WHERE U.ID = {userID}");

    public int AddFavouriteProduct(int userID,int productID)
        => _context.ExecuteNonQuery($"INSERT INTO UserFavorites values({userID}, {productID})");

    public DataTable GetProduct(int productID)
        => _context.Select($"SELECT * FROM UserFavorites where ProductID = {productID}");

    public int DeleteFavourite(int productID)
        => _context.ExecuteNonQuery($"DELETE FROM UserFavorites where ProductID = {productID}");
}
