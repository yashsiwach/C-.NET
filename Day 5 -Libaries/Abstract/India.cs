namespace Taxation
{
    /// <summary>
    /// Class to calculate tax in india
    /// </summary>
    public class India : Rules
    {
        /// <summary>
        /// will impose 20% tax if salary is between 10lakhs and 12 lakhs
        /// and 28 % on above 1200000
        /// </summary>
        /// <param name="salary"></param>
        /// <returns></returns>
        public override double Tax(int salary)
        {
            if(salary>=1000000&&salary<=1200000){
                return salary * 0.20;
            }
            else if (salary > 1200000)
            {
                return salary*0.28;
            }
            else
            {
                return 0;
            }
        }
    }
}