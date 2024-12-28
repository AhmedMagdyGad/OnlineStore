using Microsoft.Data.SqlClient;
using System.Data;

namespace DataAcessLayer;

public class ApplicationDBContext
{
    SqlConnection con;
    public ApplicationDBContext()
    {
        con = new SqlConnection(@"Server=DESKTOP-0GT95GR\SQLEXPRESS;Database=OnlineStoreProjectDB;Trusted_Connection=True;TrustServerCertificate=True");
    }
    public User SelectOneRecord(string emailOrUserName)
    {
        string command = "SELECT * FROM Users WHERE Email = @EmailOrUserName OR Name = @EmailOrUserName";
        SqlCommand cmd = new SqlCommand(command,con);
        cmd.Parameters.AddWithValue("@EmailOrUserName",emailOrUserName.ToLower());
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dataTable = new DataTable();
        adapter.SelectCommand = cmd;
        adapter.Fill(dataTable);
        if(dataTable.Rows.Count > 0)
        {
            DataRow row = dataTable.Rows[0];
            User user = new User
            {
                ID = Convert.ToInt32(row["ID"]),
                Name = row["Name"].ToString()!,
                Email = row["Email"].ToString()!,
                Password = row["Password"].ToString()!,
                Age = Convert.ToInt32(row["Age"]),
                Address = row["Address"].ToString()!,
                FavoriteSport = row["FavouriteSport"].ToString()!,
                RoleID = Convert.ToInt32(row["RoleID"])
            };
            return user;
        }
        return null!;
    }
    public DataTable Select(string command)
    {
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dataTable = new DataTable();
        SqlCommand cmd = new SqlCommand(command,con);
        adapter.SelectCommand = cmd;
        adapter.Fill(dataTable);
        return dataTable;
    }
    public int ExecuteNonQuery(string command)
    {
        SqlCommand cmd = new SqlCommand(command,con);
        int rowsAffected = -1;
        try
        {
            con.Open();
            rowsAffected = cmd.ExecuteNonQuery();
        }
        catch(Exception ex)
        {
            using(StreamWriter sr = new StreamWriter(@"D:\ITI Things\WindowsForm\OnlineStore\ErrorLogs\Logs.txt",true))
            {
                sr.WriteLine("---------- Error Log ----------");
                sr.WriteLine(value: $"TimeStamp: {DateTime.Now}");
                sr.WriteLine($"Message: {ex.Message}");
                sr.WriteLine($"Target Site: {ex.TargetSite}");
                sr.WriteLine($"Stack Trace: {ex.StackTrace}");
                sr.WriteLine("-------------------------------");
                sr.Close();
            }
        }
        finally
        {
            con.Close();
        }
        return rowsAffected;
    }
}
