using System;
using System.Numerics;

namespace BasicProgrammingLab
{
    class Program
    {
        /// <summary>
        /// Entry point of the program.
        /// Displays menu and calls selected examples.
        /// </summary>
        static void Main()
        {
            int choice;
            do
            {
                Console.WriteLine("1 Fibonacci");
                Console.WriteLine("2 Prime");
                Console.WriteLine("3 Armstrong");
                Console.WriteLine("4 Reverse & Palindrome");
                Console.WriteLine("5 GCD & LCM");
                Console.WriteLine("6 Pascal Triangle");
                Console.WriteLine("7 Binary to Decimal");
                Console.WriteLine("8 Diamond Pattern");
                Console.WriteLine("9 Factorial (Big)");
                Console.WriteLine("10 Guessing Game");
                Console.WriteLine("11 Digital Root");
                Console.WriteLine("12 Continue Example");
                Console.WriteLine("13 Strong Number");
                Console.WriteLine("14 Goto Search");
                Console.WriteLine("0 Exit");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: Fibonacci(); break;
                    case 2: Prime(); break;
                    case 3: Armstrong(); break;
                    case 4: ReversePalindrome(); break;
                    case 5: GcdLcm(); break;
                    case 6: Pascal(); break;
                    case 7: BinaryToDecimal(); break;
                    case 8: Diamond(); break;
                    case 9: FactorialBig(); break;
                    case 10: GuessGame(); break;
                    case 11: DigitalRoot(); break;
                    case 12: ContinueDemo(); break;
                    case 13: Strong(); break;
                    case 14: GotoSearch(); break;
                }
            } while (choice != 0);
        }

        /// <summary>
        /// Example to generate Fibonacci series up to N terms.
        /// </summary>
        static void Fibonacci()
        {
            int n = int.Parse(Console.ReadLine());
            long a = 0, b = 1;
            for (int i = 1; i <= n; i++)
            {
                Console.Write(a + " ");
                long c = a + b;
                a = b;
                b = c;
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Example to check whether a number is prime using for loop and break.
        /// </summary>
        static void Prime()
        {
            int n = int.Parse(Console.ReadLine());
            bool prime = n > 1;

            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    prime = false;
                    break;
                }
            }

            Console.WriteLine(prime ? "Prime" : "Not Prime");
        }

        /// <summary>
        /// Example to check Armstrong number.
        /// </summary>
        static void Armstrong()
        {
            int n = int.Parse(Console.ReadLine());
            int temp = n, digits = 0;

            while (temp > 0)
            {
                digits++;
                temp /= 10;
            }

            temp = n;
            int sum = 0;

            while (temp > 0)
            {
                int d = temp % 10;
                int p = 1;
                for (int i = 0; i < digits; i++) p *= d;
                sum += p;
                temp /= 10;
            }

            Console.WriteLine(sum == n ? "Armstrong" : "Not Armstrong");
        }

        /// <summary>
        /// Example to reverse a number and check palindrome.
        /// </summary>
        static void ReversePalindrome()
        {
            int n = int.Parse(Console.ReadLine());
            int temp = n, rev = 0;

            while (temp > 0)
            {
                rev = rev * 10 + temp % 10;
                temp /= 10;
            }

            Console.WriteLine(rev);
            Console.WriteLine(rev == n ? "Palindrome" : "Not Palindrome");
        }

        /// <summary>
        /// Example to calculate GCD and LCM of two numbers.
        /// </summary>
        static void GcdLcm()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int x = a, y = b;
            while (y != 0)
            {
                int r = x % y;
                x = y;
                y = r;
            }

            Console.WriteLine(x);
            Console.WriteLine((a * b) / x);
        }

        /// <summary>
        /// Example to print Pascal's Triangle using nested loops.
        /// </summary>
        static void Pascal()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int val = 1;
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(val + " ");
                    val = val * (i - j) / (j + 1);
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Example to convert binary number to decimal without built-in functions.
        /// </summary>
        static void BinaryToDecimal()
        {
            string bin = Console.ReadLine();
            int dec = 0, p = 1;

            for (int i = bin.Length - 1; i >= 0; i--)
            {
                if (bin[i] == '1') dec += p;
                p *= 2;
            }

            Console.WriteLine(dec);
        }

        /// <summary>
        /// Example to print diamond pattern using nested loops.
        /// </summary>
        static void Diamond()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
                Console.WriteLine(new string(' ', n - i) + new string('*', 2 * i - 1));

            for (int i = n - 1; i >= 1; i--)
                Console.WriteLine(new string(' ', n - i) + new string('*', 2 * i - 1));
        }

        /// <summary>
        /// Example to calculate factorial of large numbers using BigInteger.
        /// </summary>
        static void FactorialBig()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger f = 1;
            for (int i = 1; i <= n; i++) f *= i;
            Console.WriteLine(f);
        }

        /// <summary>
        /// Example of guessing game using do-while loop.
        /// </summary>
        static void GuessGame()
        {
            int secret = 7, guess;
            do
            {
                guess = int.Parse(Console.ReadLine());
            } while (guess != secret);

            Console.WriteLine("Correct");
        }

        /// <summary>
        /// Example to calculate digital root of a number.
        /// </summary>
        static void DigitalRoot()
        {
            int n = int.Parse(Console.ReadLine());
            while (n >= 10)
            {
                int sum = 0;
                while (n > 0)
                {
                    sum += n % 10;
                    n /= 10;
                }
                n = sum;
            }
            Console.WriteLine(n);
        }

        /// <summary>
        /// Example to demonstrate continue statement.
        /// </summary>
        static void ContinueDemo()
        {
            for (int i = 1; i <= 50; i++)
            {
                if (i % 3 == 0) continue;
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Example to check Strong number.
        /// </summary>
        static void Strong()
        {
            int n = int.Parse(Console.ReadLine());
            int temp = n, sum = 0;

            while (temp > 0)
            {
                int d = temp % 10;
                int f = 1;
                for (int i = 1; i <= d; i++) f *= i;
                sum += f;
                temp /= 10;
            }

            Console.WriteLine(sum == n ? "Strong" : "Not Strong");
        }

        /// <summary>
        /// Example to use goto statement to exit nested loops.
        /// </summary>
        static void GotoSearch()
        {
            int[,] a = { {1,2,3},{4,5,6},{7,8,9} };
            int key = int.Parse(Console.ReadLine());

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (a[i, j] == key)
                        goto found;
                }
            }

            Console.WriteLine("Not Found");
            return;

        found:
            Console.WriteLine("Found");
        }
    }
}

