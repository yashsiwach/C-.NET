
public delegate void Print();

// public class Stu:IComparable<Stu>
// {
//     public int mark1{get;set;}
//     public int mark2{get;set;}
//     public int CompareTo(Stu other)
//     {
//         if(this.mark1==other.mark1)return other.mark2-this.mark2;
//         return other.mark1-this.mark1;
//     }
// }

public class Program
{
    public static void Main()
    {
        // Action a=()=>Console.WriteLine("A");
        // Action b=()=>Console.WriteLine("B");
        // Print p=a;
        // p+=b;
        // p();
        string str=""
        if (Regex.IsMatch(str, "[a-zA-Z+@@\.\.@gmail\.com]"))
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}





        // List<Stu>lis=new List<Stu>();
        // lis.Add(new Stu{mark1=40,mark2=59});
        // lis.Add(new Stu{mark1=70,mark2=29});
        // lis.Add(new Stu{mark1=70,mark2=99});
        // lis.Add(new Stu{mark1=30,mark2=79});
        // lis.Sort();
        // foreach(var i in lis)
        // {
        //     Console.WriteLine(i.mark1+" "+i.mark2);
        // }
//         string s="Hello";
//         int n=s.Length;
//         int k=2;
//         var temp=s.ToCharArray().Reverse().Select(x=>"aeiouAEIOU".Contains(x)?(char)x+1:x).Distinct().Take(n-k).Reverse().Concat().Reverse();
//         Console.WriteLine(new string(temp));
      
        
//     }
// } 

