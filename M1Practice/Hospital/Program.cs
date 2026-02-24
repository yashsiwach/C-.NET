public class Person
{
    public string Name{get;set;}
    
}
public class Doctor : Person
{
    public int Salary{get;set;}
}
public class Patient : Person
{
    
}
public class Appointment{
        public Doctor doctor{get;set;}
        public DateTime dateTime{get;set;}
        public Patient patient{get;set;}
        public string Disease{get;set;}

}
public class MedicalRecord
{
    public List<Appointment>data=new();
}
public class Program
{
    public static void Main(string[] args)
    {
        List<Doctor>D=new();
        List<Patient>P=new();
        List<Appointment>A=new();
        Dictionary<int,MedicalRecord>M=new();
        D.Add(new Doctor{Name="ram",Salary=100});
        D.Add(new Doctor{Name="mohan",Salary=900});
        D.Add(new Doctor{Name="ritesh",Salary=1200});
        D.Add(new Doctor{Name="rohan",Salary=260});

        P.Add(new Patient{Name="pater"});
        P.Add(new Patient{Name="honey"});
        P.Add(new Patient{Name="amit"});
        P.Add(new Patient{Name="nav"});

        A.Add(new Appointment{doctor=D[0],dateTime=new DateTime(2023,2,4),patient=P[2],Disease="pox"});
        A.Add(new Appointment{doctor=D[1],dateTime=new DateTime(2026,2,3),patient=P[1],Disease="fever"});
        A.Add(new Appointment{doctor=D[2],dateTime=new DateTime(2026,1,23),patient=P[0],Disease="cancer"});
        A.Add(new Appointment{doctor=D[1],dateTime=new DateTime(2025,10,12),patient=P[1],Disease="nose"});
        A.Add(new Appointment{doctor=D[3],dateTime=new DateTime(2026,1,14),patient=P[2],Disease="piles"});

        var docmoreten=A.GroupBy(x=>x.doctor).ToDictionary(g=>g.Key,g=>g.Count()).ToList().Where(x=>x.Value>1);
        var last30=A.Where(x=>DateTime.Now.AddDays(-30)<x.dateTime).Select(x=>x.patient).ToList();
        var Appbydoc=A.GroupBy(x=>x.doctor).ToDictionary(g=>g.Key,g=>g.ToList());
        int rev=0;
        var top2=A.GroupBy(x=>x.doctor).ToDictionary(g=>g.Key,g=>rev+=g.Count()*g.Key.Salary);
       
        var topper2=top2.OrderByDescending(x=>x.Value);
        var pwithdis=A.GroupBy(x=>x.Disease).ToDictionary(g=>g.Key,g=>g.ToList());
        Console.WriteLine();
        ////
        Console.WriteLine("doctors with more than 1 appointments");
        foreach(var i in docmoreten)
        {
            Console.WriteLine(i.Key+" "+i.Value);
        }

        Console.WriteLine("patients treated in last 30 days");
        foreach(var i in last30)
        {
            Console.Write(i+ " ");
        }
        Console.WriteLine();
        Console.WriteLine("Group appointments by doctor");
        foreach(var i in Appbydoc)
        {
            Console.WriteLine(i.Key);
            foreach(var j in i.Value)
            {
                Console.Write(j+" ");
            }
        }
        Console.WriteLine();
        Console.WriteLine("top 2 highest earning doctors");
        foreach(var i in topper2)
        {
            Console.WriteLine(i.Key+" "+i.Value);
        }
        Console.WriteLine("patients by disease");
        foreach(var i in pwithdis)
        {
            Console.WriteLine(i.Key);
            foreach(var j in i.Value)
            {
                Console.Write(j+" ");
            }
        }
        Console.WriteLine();
        Console.WriteLine("total revenue generated");
        Console.WriteLine(rev);

    }
}