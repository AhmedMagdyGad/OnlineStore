using DataAcessLayer;
using System.Data;

namespace BusinessLayer;

public class UserService
{
    ApplicationDBContext _context;
    public UserService()
    {
        _context = new ApplicationDBContext();
    }

    public User LoginUser(string emailOrUserName)
        => _context.SelectOneRecord(emailOrUserName);

    public DataTable GetUsers()
        => _context.Select($"SELECT ID, Name, Email, Age, Address, RoleID FROM Users where RoleID != 1");

    public DataTable GetUsersRoles()
        => _context.Select($"SELECT ID, Name FROM Roles Where Name != 'GM'");

    public int AddUser(User user)
        => _context.ExecuteNonQuery($"INSERT INTO Users VALUES('{user.Name.ToLower()}','{user.Email.ToLower()}','{user.Password}',{user.Age},'{user.Address}','{user.FavoriteSport}',3)");

    public int UpdateUser(User user)
        => _context.ExecuteNonQuery($"UPDATE Users set Name = '{user.Name.ToLower()}', Password = '{user.Password}', Age = {user.Age}, Address = '{user.Address}', FavouriteSport = '{user.FavoriteSport}', RoleID = {user.RoleID} where ID = {user.ID}");

    public int DeleteUser(int id)
        => _context.ExecuteNonQuery($"DELETE FROM Users Where ID = {id}");
}
