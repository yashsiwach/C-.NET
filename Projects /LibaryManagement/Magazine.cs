namespace LibarySystem
{
    namespace Items{
    public class Magazine : LibaryItem
    {
        public Magazine(string title,string author,int itemId)
        {
            this.title=title;
            this.author=author;
            this.itemId=itemId;
        }
        public override void Display()
        {
            System.Console.WriteLine("Title is:"+title);
            System.Console.WriteLine("Author is:"+ author);
            System.Console.WriteLine("Id is :"+itemId);
        }
        public override void CalculateLateFee(int day)
        {
            System.Console.WriteLine("Late charge for magazine is :"+(day*0.5));            
        }
    }
    }
}