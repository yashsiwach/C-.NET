public class Program
{
    public static T[] sorted<T>(T[] a, T[] b) where T : IComparable<T>
    {
        int i = 0;
        int j = 0;
        int k = 0;
        T[] ans = new T[a.Length + b.Length];
        while (i < a.Length && j < b.Length)
        {
            if (a[i].CompareTo(b[j]) < 0)
            {
                ans[k] = a[i];
                k++;
                i++;
            }
            else
            {
                ans[k] = b[j];
                j++;
                k++;
            }
        }
        while (i < a.Length)
        {
            ans[k] = a[i];
            i++; k++;
        }
        while (j < b.Length)
        {
            ans[k] = b[j];
            j++;
            k++;
        }
        return ans;
    }
    public static void Main(string[] args)
    {
        int[] a = { 1, 4, 6, 10 };
        int[] b = { 2, 5, 8, 9, 9 };
        var ans = sorted(a, b);
        foreach (var i in ans)
        {
            System.Console.Write(i+" ");
        }

    }
}