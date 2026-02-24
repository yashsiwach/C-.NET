public class Program
{
    public static void Main(string[] args)
    {
        List<string>ops=new List<string>{"TYPE Hello","TYPE World","UNDO","TYPE CSharp"};
        LinkedList<string>ll=new LinkedList<string>();
        for(int i=0;i<ops.Count;i++)
        {
            if (ops[i] != "UNDO")
            {
                
                ops[i]=ops[i].Remove(0,4);
                Console.WriteLine(ops[i]);
                ll.AddLast(ops[i]);
            }
            else
            {
                if(ll.Count>0)ll.RemoveLast();
            }
        }
        var result=ll.ToList();
        foreach(var i in result)
        {
            Console.Write(i);
        }

    }
    
}
