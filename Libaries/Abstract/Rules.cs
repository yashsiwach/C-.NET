namespace Taxation
{
    /// <summary>
    /// class to calulate the Tax 
    /// </summary>
    public abstract class Rules
    {
        /// <summary>
        /// function to be override;
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public abstract double Tax(int a);
    }
}