class ThreadingEx
{
    public static async Task AsyncMethod()
    {
        System.Console.WriteLine("Task Started");
        await Task.Delay(3000);
        System.Console.WriteLine("3sec done");
    }
    public static async Task<string> Fetchdata(string url)
    {
        using(HttpClient httpClient=new HttpClient())
        {
            var result= await httpClient.GetStringAsync(url);
            return result;
        }
    }
    public static async Task fetcher()
    {
        string result=await Fetchdata("https://jsonplaceholder.typicode.com/todos/1");
        System.Console.WriteLine(result);
    }
}


public class Program
{
    public   static  async Task Main()
    {
        await ThreadingEx.AsyncMethod();
        await ThreadingEx.fetcher();
    }
}