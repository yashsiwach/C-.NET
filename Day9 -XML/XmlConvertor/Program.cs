using System.Diagnostics;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Xml.Serialization;
using System.Diagnostics;

public class Program
{
    [Serializable]
    [XmlRoot("baseClass")]
    public class Student
    {
        [XmlElement("StudentId")]
        public int Id { get; set; }
        [XmlAttribute]
        public string? Name { get; set; }
        public List<int> data { get; set; } = new List<int> { 5, 7, 1, 2, 3 };
        public Dictionary<string, int> dict { get; set; } = new Dictionary<string, int>();
        [XmlIgnore]
        public List<string> data1 = new List<string> { "test1", "test2" };

    }
    public class ProcessInfo
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public long Memory { get; set; }
    }

    public static void Main()
    {
        Student stu = new Student();
        stu.Id = 2;
        stu.Name = "test";
        stu.dict["ok"] = 3;
        // XmlSerializer serializer = new XmlSerializer(typeof(Student));
        // StringWriter sw = new StringWriter();
        // serializer.Serialize(sw, stu);
        // string xml = sw.ToString();
        // System.Console.WriteLine(xml);

        //Binary formatter has been discontinued due to security resons

        // #pragma warning disable SYSLIB0011
        // BinaryFormatter bf = new BinaryFormatter();
        // MemoryStream ms = new MemoryStream();
        // bf.Serialize(ms, stu);
        // byte[] bin = ms.ToArray();
        // System.Console.WriteLine(bin.Length);
        // #pragma warning restore SYSLIB0011

        //json serialization
       // string json = JsonSerializer.Serialize(stu);
       // System.Console.WriteLine(json);
        //json deserialization
        //Student? deObj = JsonSerializer.Deserialize<Student>(json);
        //System.Console.WriteLine(deObj.Name);

        Process[] processes = Process.GetProcessesByName("Ulaa");

        List<ProcessInfo> list = new List<ProcessInfo>();

        foreach (Process p in processes)
        {
            list.Add(new ProcessInfo
            {
                Id = p.Id,
                Name = p.ProcessName,
                Memory = p.WorkingSet64
            });
        }
        string json = JsonSerializer.Serialize(list);
        System.Console.WriteLine(json);


        List<ProcessInfo> deArr=JsonSerializer.Deserialize<List<ProcessInfo>>(json);
        foreach(var i in deArr)
        {
            System.Console.WriteLine(i.Name);
        }


    }
}