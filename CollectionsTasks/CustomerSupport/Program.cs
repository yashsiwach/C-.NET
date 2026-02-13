public class Program
{
    public static void Main(string[] args)
    {
        List<int>a=new List<int>{1,4,7};
        List<int>b=new List<int>{2,3,8,10,11};
        int i=0;
        int j=0;
        List<int>ans=new();
        while (i < 3 && j < 5)
        {
            if (a[i] < b[j])
            {
                ans.Add(a[i]);
                i++;
            }
            else
            {
                ans.Add(b[j]);
                j++;
            }
        }
        while(i<3){ans.Add(a[i]);i++;}
        while(j<5){ans.Add(b[j]);j++;}
        foreach(var it in ans)
        {
            Console.Write(it+" ");
        }

    }
    
}
