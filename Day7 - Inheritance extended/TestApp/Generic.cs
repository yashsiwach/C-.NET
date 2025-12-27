namespace Test
{
    public class Generic<TKey, TValue>
    {
        public TKey name;
        public TValue id;
        public void Ok(TKey name,TValue id)
        {
            this.name=name;
            this.id=id;
            System.Console.WriteLine(this.name);
            System.Console.WriteLine(this.id);
        }
    }
}