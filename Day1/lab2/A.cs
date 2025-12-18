using System;
// C) Approach (step-by-step)
// Read feet value.
// Validate with double.TryParse.
// Use constant conversion factor 30.48.
// Compute: cm = feet * 30.48.
// Print result.
// G) Small enhancement
// Keep conversion factor in a constant (done). Next: ask user if they want cm-to-feet as reverse conversion.
namespace Feet
{
    public class A
    {
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
                    if (!(Ch == 'y' || Ch == 'n')) break;
                }

            }
        }
    }
}