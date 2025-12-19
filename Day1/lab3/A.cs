using System;
// F) Edge cases
// Seconds = 0 ➜ 0 minutes, 0 seconds
// Seconds less than 60 ➜ 0 minutes, same seconds
// Very large input ➜ still works (within int range)
// Non-numeric ➜ show message
// G) Small enhancement
// Next improvement: convert to hours + minutes + seconds using division/modulus (real-world time formatting).
namespace Time
{
    public class A
    {
        public void Print()
        {
            string str= Console.ReadLine();
            if(!(int.TryParse(str,out int sec)))
            {
                Console.WriteLine("invalid");
            }
            else if (sec < 0)
            {Siwach143
                Console.WriteLine("negetive time");
            }
            else
            {
                int hours =sec/3600;
                sec = sec%3600;
                int min=sec/60;
                sec=sec%60;
                Console.WriteLine($" { hours} : {min} : {sec}");
            }
        }
    }
}