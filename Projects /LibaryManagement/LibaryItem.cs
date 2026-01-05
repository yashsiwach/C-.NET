
namespace LibarySystem
{
    public abstract class LibaryItem
    {
        public string? title;
        public string? author;
        public int itemId;
        public abstract void Display();
      
        public abstract void CalculateLateFee(int day);
       
    }
}