namespace Taxation
{
    public class Us : Rules
    {
        /// <summary>
        /// will return the 20% taax
        /// </summary>
        /// <param name="salary"></param>
        /// <returns></returns>
        public override double Tax(int salary)
        {
            if(salary>=500000&&salary<=1200000){
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