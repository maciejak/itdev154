using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        //Recursion -> Functions that call themselves
        //base case        winding phase
        //recursive case   unwinding phase
        //

        static void Main(string[] args)
        {
            int choice, x, n;

            try
            {
                while (true)
                {
                    choice = GetMenuChoice();
                    if (choice == 9)
                        break;

                    switch (choice)
                    {
                        case 1:
                            WriteLine("Enter an integer to Factorial: ");
                            x = Convert.ToInt32(ReadLine());
                            WriteLine($"{x}| = {Factorial(x)}");
                            WriteLine();
                            break;
                        case 2:
                            WriteLine("Enter a number to print the numbers to: ");
                            x = Convert.ToInt32(ReadLine());
                            WriteLine("The numbers are: ");
                            PrintNumbers(x);
                            WriteLine();
                            break;
                        case 3:
                            WriteLine("Enter a number to print the sum of digits of: ");
                            x = Convert.ToInt32(ReadLine());
                            WriteLine($"The sum  of digits of {x} is: {SumDigits(x)}");
                            WriteLine();
                            break;
                        case 4:
                            WriteLine("Enter a number to perform base conversion on: ");
                            x = Convert.ToInt32(ReadLine());
                            Write($"{x} in Binary = ");
                            ConvertBase(x, 2);
                            WriteLine();
                            Write($"{x} in Octal = ");
                            ConvertBase(x, 8);
                            WriteLine();
                            Write($"{x} in Hexadecimal = ");
                            ConvertBase(x, 16);
                            WriteLine();
                            break;
                        case 5:
                            WriteLine("Enter an integer to raise to a power: ");
                            x = Convert.ToInt32(ReadLine());
                            WriteLine("Enter an exponent: ");
                            n = Convert.ToInt32(ReadLine());
                            WriteLine($"{x}^{n} = {Power(x, n)}");
                            break;
                        case 6:
                            Write("Enter the first integer to find GCD: ");
                            x = Convert.ToInt32(ReadLine());
                            Write("Enter the second integer to find GCD: ");
                            n = Convert.ToInt32(ReadLine());
                            WriteLine($"The GCD of {x} and {n} is {GCD(x, n)}");
                            break;
                        case 7:
                            Write("Enter the number of Fionacci terms to print: ");
                            x = Convert.ToInt32(ReadLine());
                            for(int i = 0; i < x; i++)
                            {
                                Write($"{Fib(i)}");
                            }
                            WriteLine();
                            break;
                        case 8:
                            Write("Enter the number of discs: ");
                            x = Convert.ToInt32(ReadLine());
                            Hanoi(x, 'A', 'B', 'C');
                            break;
                        default: WriteLine("Please enter a valid selection.");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                WriteLine($"An error has occured:{ex.Message}\n{ex.StackTrace}");
            }
        }

        private static int GetMenuChoice()
        {
            WriteLine();
            WriteLine("1. Factorial");
            WriteLine("2. Print numbers from 1 to n");
            WriteLine("3. Sum of digits of an integer");
            WriteLine("4. Base Conversion");
            WriteLine("5. Finding the nth power of a number");
            WriteLine("6. Euclids Algorithm");
            WriteLine("7. Fibonacci Series");
            WriteLine("8. Towers of Hanoi");
            WriteLine("9. Quit");
            Write("Please Enter Your Selection: ");
            int choice = Convert.ToInt32(ReadLine());
            WriteLine();
            return choice;
        }

        public static long Factorial(int n) 
        {
            if (n == 0)
                return 1;
            return n * Factorial(n - 1); 
        }

        public static void PrintNumbers(int n)
        {
            if (n == 0)
                return;
            PrintNumbers(n - 1);
            Write($"{n} ");
        }

        public static int SumDigits(int n)
        {
            if (n / 10 == 0)
                return n;
            return SumDigits(n / 10) + n % 10;
        }

        public static void ConvertBase(int n, int b)
        {
            if (n == 0)
                return;
            ConvertBase(n / b, b);

            int remainder = n % b;
            if (remainder < 10)
                Write(remainder);
            else
                Write((char)(remainder - 10 + 'A'));
        }

        public static double Power(double x, int n)
        {
            if (n == 0)
                return 1;
            return x * Power(x, n - 1);
        }

        public static int GCD(int a, int b)
        {
            if (b == 0)
                return a;
            return GCD(b, a % b);
        }

        public static int Fib(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            return Fib(n - 1) + Fib(n - 2);
        }
        
        public static void Hanoi(int n, char source, char temp, char dest)
        {
            if (n == 1)
            {
                WriteLine($"Move disk {n} from {source} to {dest}");
                return;
            }
            Hanoi(n - 1, source, dest, temp);
            WriteLine($"Move disk {n} from {source} to {dest}");
            Hanoi(n - 1, temp, source, dest);
        }
    }
}
