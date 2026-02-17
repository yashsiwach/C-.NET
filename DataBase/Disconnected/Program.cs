using System;
using System.Data;
using Microsoft.Data.SqlClient;

public class Program
{
    public static void Main()
    {
        string? ConnectionString = "Data Source=localhost;Database=StudentDB;Persist Security Info=True;User ID=sa;Password=His@r143;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Command Timeout=0";

        string? sql = "select * from student";

        using SqlConnection sqlConnection = new SqlConnection(ConnectionString);
        sqlConnection.Open();

        DataSet dataSet = new();
        SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, sqlConnection);

        dataAdapter.Fill(dataSet, "student");

        foreach (DataRow row in dataSet.Tables["student"].Rows)
        {
            Console.WriteLine(row[0] + " " + row[1] + " " + row[2] + " " + row[3]);
        }

        dataAdapter.InsertCommand = new SqlCommand(
            "INSERT INTO student (id,name,age,grade) VALUES (@id,@name,@age,@grade)",
            sqlConnection);

        dataAdapter.InsertCommand.Parameters.Add("@id", SqlDbType.Int, 0, "id");
        dataAdapter.InsertCommand.Parameters.Add("@name", SqlDbType.VarChar, 50, "name");
        dataAdapter.InsertCommand.Parameters.Add("@age", SqlDbType.Int, 0, "age");
        dataAdapter.InsertCommand.Parameters.Add("@grade", SqlDbType.VarChar, 10, "grade");

        DataRow newRow = dataSet.Tables["student"].NewRow();
        newRow["id"] = 200;
        newRow["name"] = "Jonny";
        newRow["age"] = 22;
        newRow["grade"] = "A";

        dataSet.Tables["student"].Rows.Add(newRow);

        // 🔥 Sync with DB
        dataAdapter.Update(dataSet, "student");

        Console.WriteLine("Inserted Successfully");
        Console.WriteLine("Done");
    }
}