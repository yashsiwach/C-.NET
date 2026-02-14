using System.Data;
using Microsoft.Data.SqlClient;
public class Program
{
    public static void Main()
    {
        string? ConnectionString = "Data Source=localhost;Database=StudentDB;Persist Security Info=True;User ID=sa;Password=His@r143;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Command Timeout=0";
        string? sql="select * from student";
        using SqlConnection sqlConnection = new SqlConnection(ConnectionString);
        sqlConnection.Open();
        DataSet dataSet = new();
        SqlDataAdapter dataAdapter =  new SqlDataAdapter(sql, sqlConnection);
        dataAdapter.Fill(dataSet);
        foreach (DataRow row in dataSet.Tables[0].Rows)
        {
            Console.WriteLine(row[0]+" "+row[1]+" "+row[2]+" "+row[3]);
        }
        // SqlCommandBuilder cb = new SqlCommandBuilder(da);
//
// ds.Tables["Students"].Rows[0]["Name"] = "Yash";
//
// da.Update(ds, "Students");

    }
}