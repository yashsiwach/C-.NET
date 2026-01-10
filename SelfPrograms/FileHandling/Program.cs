public class Program
{
    public static void Main()
    {
        //create +override the text
        string s="Well ";
        File.WriteAllText("test.txt",s);
        
        //create + append the text
        File.AppendAllText("test1.txt",s);

        //create +override the text
        using(StreamWriter sw= new StreamWriter("ok.txt"))
        {
            sw.WriteLine("this is masge from w");
        }

        //read
        if (File.Exists("yash.txt"))
        {
            System.Console.WriteLine("yes");
        }
        else
        {
            System.Console.WriteLine("no");
        }

        //delete a file.
        File.Delete("test1.txt");

        // Read till last line linewise!
        using (StreamReader sr=new StreamReader("test.txt"))
        {
            string? line;
            while ((line = sr.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
            }
        }

        // exception handling +file opening + streamreader( better code under not need to learn only for the Dispose() learning )
        StreamReader? sr2=null;
        try
        {
            sr2=new StreamReader("test1.txt");
            string? temp;
            while ((temp = sr2.ReadLine()) != null)
            {
                System.Console.WriteLine(temp);
            }
        }
        catch(FileNotFoundException e)
        {
            System.Console.WriteLine(e.Message);
        }
        finally
        {
            if (sr2 != null)
            {
                sr2.Dispose();
            }
            System.Console.WriteLine("Done");
        }

        // best practice No need to use finally
        try
        {
            using(StreamReader sr3=new StreamReader("ok.txt"))
            {
                string? line;
                while ((line = sr3.ReadLine()) != null)
                {
                    System.Console.WriteLine(line);
                }
            }
        }
        catch(FileNotFoundException e)
        {
            System.Console.WriteLine(e.Message);
        }

        //only used with byte data so filestream while streamwriter and streamreader works on the text not on bytes
        //write +create +override
        using(FileStream sr4=new FileStream("binary.bin",FileMode.Create))
        using(BinaryWriter bw=new BinaryWriter(sr4)){
            bw.Write("yash");
        }
        //open + read
        using(FileStream sr5=new FileStream("binary.bin",FileMode.Open))
        using(BinaryReader br=new BinaryReader(sr5))
        {
            string str=br.ReadString();
            System.Console.WriteLine(str);
        }
        
        
    }
}