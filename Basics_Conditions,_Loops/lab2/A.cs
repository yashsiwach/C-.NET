using System;

namespace Feet
{
    #region Feet and Centimeter Conversion

    /// <summary>
    /// Class A performs feet-to-centimeter conversion
    /// and supports reverse conversion based on user choice.
    /// </summary>
    public class A
    {
        #region Methods

        /// <summary>
        /// Reads input from the user, validates it using TryParse,
        /// converts feet to centimeters or vice versa using
        /// a constant conversion factor, and prints the result.
        /// </summary>
        public void Print()
        {
            const float Cm = 30.48f;
            string? Str;
            bool Flag = false;
            char Ch = 'Y';

            while ((Str = Console.ReadLine()) != null)
            {
                if (!float.TryParse(Str, out float ft))
                {
                    Console.Write("invalid");
                }
                else if (ft < 0)
                {
                    Console.Write("positive is needed");
                }
                else
                {
                    float ans = (Flag == false) ? (ft * Cm) : (ft / Cm);
                    Console.WriteLine(ans);

                    Console.WriteLine("want to reverse it? Y / N");
                    Ch = Convert.ToChar(Console.ReadLine());

                    Flag = Ch == 'y' ? (Flag = (!Flag)) : Flag;

                    if (!(Ch == 'y' || Ch == 'n'))
                        break;
                }
            }
        }

        #endregion
    }

    #endregion
}
