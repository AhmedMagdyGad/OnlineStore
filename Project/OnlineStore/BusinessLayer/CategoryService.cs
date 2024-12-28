using DataAcessLayer;
using System.Data;

namespace BusinessLayer;
public class CategoryService
{
    ApplicationDBContext _context;
    public CategoryService()
    {
        _context = new ApplicationDBContext();
    }

    public DataTable GetCategories()
        => _context.Select($"SELECT ID, Name FROM Categories");

    public int AddCategory(Category category)
        => _context.ExecuteNonQuery($"INSERT INTO Categories (Name) SELECT '{category.Name}' WHERE NOT EXISTS (SELECT 1 FROM Categories WHERE Name = '{category.Name}');");

    public int UpdateCategory(Category category)
        => _context.ExecuteNonQuery($"UPDATE Categories set Name = '{category.Name}' where ID = {category.ID}");

    public int DeleteCategory(int id)
        => _context.ExecuteNonQuery($"DELETE FROM Categories where ID = {id}");
}
