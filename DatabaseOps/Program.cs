using Microsoft.Data.SqlClient;

public class Student
{
    public int id { get; set; }
    public string? name { get; set; }
    public int age { get; set; }
    public string? grade { get; set; }
}
class Program
{

    public static void ShowDB(SqlConnection con, string? sql)
    {
            using (var cmd = new SqlCommand(sql, con))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string? name = reader.GetString(1);
                        int age = reader.GetInt32(2);
                        string? grade = reader.GetString(3);

                        Console.WriteLine($"{id} | {name} | {age} | {grade}");
                    }
                }
            }
    }

    public static void InsertIntoDB(Student obj, string? insetSql, SqlConnection con)
    {
        using var insertcmd = new SqlCommand(insetSql, con);
        insertcmd.Parameters.AddWithValue("@id", obj.id);
        insertcmd.Parameters.AddWithValue("@name", obj.name);
        insertcmd.Parameters.AddWithValue("@age", obj.age);
        insertcmd.Parameters.AddWithValue("@grade", obj.grade);
        int num = insertcmd.ExecuteNonQuery();
        Console.WriteLine("Inserted Successfully");
    }

    public static void DeleteIntoDB(SqlConnection con, string? sql,int id)
    {
        using var cmd = new SqlCommand(sql, con);
        cmd.Parameters.AddWithValue("@id", id);
        cmd.ExecuteNonQuery();
        Console.WriteLine("Deleted Successfully");
        
    }
    static void Main()
    {
        DotNetEnv.Env.Load();
        string? cs=Environment.GetEnvironmentVariable("ConnectionString")!;
        string? sql = "SELECT id, name ,age ,grade FROM dbo.student";
        string? insetSql = "Insert into student(id,name,age,grade) Values(@id,@name, @age,@grade)";
        string? deleteSql = "Delete from student where id=@id";
        
        using var connection = new SqlConnection(cs);
        connection.Open();
        
        // List<Student> data = new List<Student>();
        int count = 0;
        while (count != 4)
        {
            Console.WriteLine("1 -> Show Database\n2 -> Insert Into Database\n3->Delete with Id\n4->Exit");
            count = int.Parse(Console.ReadLine()!);
            if (count == 1)
            {
                ShowDB(connection,sql);
            }
            else if (count == 2)
            {
                Console.WriteLine("Enter the id");
                int id = int.Parse(Console.ReadLine()!);
                Console.WriteLine("Enter the name");
                string? name = Console.ReadLine();
                Console.WriteLine("Enter the age");
                int age = int.Parse(Console.ReadLine()!);
                Console.WriteLine("Enter the grade");
                string? grade = Console.ReadLine();
                Student obj = new Student();
                InsertIntoDB(obj,insetSql, connection);
            }
            else if (count == 3)
            {
                Console.WriteLine("Enter the id");
                int id = int.Parse(Console.ReadLine()!);
                DeleteIntoDB(connection, deleteSql, id);
            }
            else 
            {
                Console.WriteLine("Thankyou");
            }
        }
    }
}