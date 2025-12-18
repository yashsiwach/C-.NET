using System;
// C) Approach (step-by-step)
// Read radius as string.
// Validate using double.TryParse.
// If radius < 0 ➜ show message and stop.
// Compute: area = Math.PI * radius * radius.
// Print area (formatted).
namespace Area
{
    public class B
    {
        public void Print()
        {
            string Radi = Console.ReadLine();
            if (!(double.TryParse(Radi, out double radius)))
            {
                Console.WriteLine("invalid");
            }
            else
            {
                if (radius < 0)
                {
                    Console.WriteLine("less than 0");
                }
                else
                {
                    double area = Math.PI * radius * radius;
                    Console.WriteLine($"{area:F2}");


                }
            }

        }
    }
}