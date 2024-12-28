using DataAcessLayer;
using System.Data;

namespace BusinessLayer;
public class ProductService
{
    ApplicationDBContext _context;
    public ProductService()
    {
        _context = new ApplicationDBContext();
    }
    public DataTable GetProducts()
        => _context.Select("SELECT ID, Name, Price, Quantity, CategoryID FROM Products");

    public int AddProduct(Product product)
        => _context.ExecuteNonQuery($"INSERT INTO Products VALUES('{product.Name}', {product.Price}, {product.Quantity}, {product.CategoryID})");

    public int UpdateProduct(Product product)
        => _context.ExecuteNonQuery($"UPDATE Products set Name = '{product.Name}', Price = {product.Price}, Quantity = {product.Quantity}, CategoryID = {product.CategoryID} where ID = {product.ID}");

    public int DeleteProduct(int id)
        => _context.ExecuteNonQuery($"DELETE FROM Products WHERE ID = {id}");
}
