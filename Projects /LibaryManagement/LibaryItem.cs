namespace LibarySystem
{
    /// <summary>
    /// Abstract base class for all library items.
    /// </summary>
    public abstract class LibaryItem
    {
        public string? title;
        public string? author;
        public int itemId;
        public ItemStatus type { get; set; }

        /// <summary>
        /// Displays item details
        /// </summary>
        public abstract void Display();

        /// <summary>
        /// Calculates late fee based on number of days
        /// </summary>
        /// <param name="day">Number of late days</param>
        public abstract void CalculateLateFee(int day);
    }
}
