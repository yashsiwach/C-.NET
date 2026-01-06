using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

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
        public List<int> data = new List<int> { 5, 7, 1, 2, 3 };
        //  public Dictionary<string,int>dict=new Dictionary<string, int>();
        [XmlIgnore]
        public List<string> data1 = new List<string> { "test1", "test2" };

    }
    public static void Main()
    {
        Student stu = new Student();
        stu.Id = 2;
        stu.Name = "test";
        //  stu.dict["ok"]=3;
        XmlSerializer serializer = new XmlSerializer(typeof(Student));
        StringWriter sw = new StringWriter();
        serializer.Serialize(sw, stu);
        string xml = sw.ToString();
        System.Console.WriteLine(xml);

        //Binary formatter has been discontinued due to security resons
        
        // #pragma warning disable SYSLIB0011
        // BinaryFormatter bf = new BinaryFormatter();
        // MemoryStream ms = new MemoryStream();
        // bf.Serialize(ms, stu);
        // byte[] bin = ms.ToArray();
        // System.Console.WriteLine(bin.Length);
        // #pragma warning restore SYSLIB0011

    }
}