using System;
namespace ClassWork
{
    /// <summary>
    /// Program to check addmission eligiblity
    /// </summary>
    public class Addmission
    {
        /// <summary>
        /// Method to print the program
        /// </summary>
        public void Print()
        {
            #region Declaration           
            String? a = Console.ReadLine();
            String? b = Console.ReadLine();
            String? c = Console.ReadLine();
            int math = int.TryParse(a, out math) ? math : 0;
            int chem = int.TryParse(b, out chem) ? chem : 0;
            int phys = int.TryParse(c, out phys) ? phys : 0;
            #endregion

            #region Logic +output         
            bool eligible =math >= 65 && phys >= 55 && chem >= 50 &&(math + phys + chem >= 180 || math + phys >= 140);
            if (eligible)
            {
                System.Console.WriteLine("yes");
            }
            else
            {
                System.Console.WriteLine("no");
            }
            #endregion

        }
    }
}