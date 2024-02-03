using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Sum of Two Numbers
            //Console.WriteLine("Sum of Two Numbers\n");
            //double num1, num2, result = 0;

            //while(true)
            //{
            //    Console.Write("Enter num1: ");
            //    string first = Console.ReadLine();
            //    Console.Write("Enter num2: ");
            //    string sec = Console.ReadLine();

            //    if (double.TryParse(first, out num1) && double.TryParse(sec, out num2))
            //    {
            //        result = num1 + num2;
            //        Console.WriteLine("Sum: " + result);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Input is not a number!!");
            //    }

            //}
            #endregion

            #region print output of specified operations
            //Console.WriteLine(-1 + 4 * 6);
            //Console.WriteLine((35 + 5) % 7);
            //Console.WriteLine(14 + (-4) *6 / 11);
            //Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
            #endregion

            #region swap two numbers
            //int num1, num2, temp;

            //Console.Write("Enter num1: ");
            //num1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter num2: ");
            //num2 = int.Parse(Console.ReadLine());

            //temp = num1;
            //num1 = num2;
            //num2 = temp;

            //Console.WriteLine("\n\nSwap");
            //Console.WriteLine("First Number: " +num1);
            //Console.WriteLine("Second Number: "+num2);
            #endregion

            #region product of 3 inputs Expected output: 2 x 3 x 6 = 36
            //double num1, num2, num3, pro;

            //Console.Write("Enter num1: ");
            //num1 = double.Parse(Console.ReadLine());

            //Console.Write("Enter num2: ");
            //num2 = double.Parse(Console.ReadLine());

            //Console.Write("Enter num3: ");
            //num3 = double.Parse(Console.ReadLine());

            //pro = num1 * num2 * num3;

            //Console.WriteLine($"{num1} x {num2} x {num3} = " + pro);

            #endregion

            #region add, sub, mul, div, mod
            //double num1, num2, res = 0;
            //Console.Write("Enter num1: ");
            //num1 = double.Parse(Console.ReadLine());

            //Console.Write("Enter num2: ");
            //num2 = double.Parse(Console.ReadLine());

            //res = num1 + num2;
            //Console.WriteLine($"{num1} + {num2} = " +res);
            //res = num1 - num2;
            //Console.WriteLine($"{num1} - {num2} = " + res);
            //res = num1 * num2;
            //Console.WriteLine($"{num1} x {num2} = " + res);
            //res = num1 / num2;
            //Console.WriteLine($"{num1} / {num2} = " + res);
            //res = num1 % num2;
            //Console.WriteLine($"{num1} mod {num2} = " + res);
            #endregion

            #region multiplication table of input

            //Console.Write("Input number: ");
            //int num;

            //if(int.TryParse(Console.ReadLine(), out num))
            //{
            //    Console.WriteLine($"Multiplication Table for: {num}");

            //    for(int i = 1; i <= 10; i++)
            //    {
            //        int result = num * i;
            //        Console.WriteLine($"{num} x {i} = {result}");
            //    }
            //}

            #endregion

            #region get average
            //////
            ///// manual
            //double num1, num2, num3, num4, ave;
            //Console.Write("Enter num1: ");
            //num1 = double.Parse(Console.ReadLine());
            //Console.Write("Enter num2: ");
            //num2 = double.Parse(Console.ReadLine());
            //Console.Write("Enter num3: ");
            //num3 = double.Parse(Console.ReadLine());
            //Console.Write("Enter num4: ");
            //num4 = double.Parse(Console.ReadLine());

            //ave = (num1 + num2 + num3 + num4) / 4;
            //Console.WriteLine($"Average: {num1}, {num2}, {num3}, {num4} = {ave}");

            /////
            /// loop
            
            //Console.Write("How many numbers would you like to calculate?: ");
            //if(int.TryParse(Console.ReadLine(), out int count) && count > 0)
            //{
            //    double sum = 0;

            //    for(int i = 1; i <= count; i++)
            //    {
            //        Console.Write($"Enter num {i}: ");
            //        if(double.TryParse(Console.ReadLine(), out double num))
            //        {
            //            sum += num;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Input is not a number. Try again.");
            //            i--;
            //        }
            //    }

            //    double ave = sum / count;
            //    Console.WriteLine($"Average of = {ave}");
            //}


            #endregion



            Console.ReadKey();
        }
    }
}
