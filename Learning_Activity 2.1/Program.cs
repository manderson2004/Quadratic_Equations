using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_Activity_2._1
{
    internal class Program
    {
        /*
Learning Activity 2: Quadratic Equations

Write a program to calculate the roots of a quadratic equation. A quadratic equation is an equation of the form:

ax^2+bx+c=0

The roots of a quadratic equation are given by the formula:

x=(-b±√(b^2-4ac))/2a

a quadratic equation, we are trying to solve for X; there are two roots. We potentially have an undefined situation (imaginary), and in this case we ignore
quadratic formula is ax^2 + by + c = 0
x = (-b +-sqrt(b^2-4ac))/2a
call  (b ^ 2 - 4ac) a certain variable (whatever you want, but temp) --> d

  steps for solving this
  1. read in values for a, b, c
  2. compute temporary variable d= (b^2-4ac)
  3. check if d is greater than 0. If not, there are no real roots. 
  4. if d is greater than 0, compute two different roots 
  5. these two roots are (-b + sqrt(b^2 - 4ac))/2a, (-b - sqrt(b^2-4ac))/2a
  6. print those two roots
*/
        static void Main(string[] args)
        {
            int a, b, c;

            double d, x1, x2;

            Console.Write("Calculate the roots of the Quadratic Equation ax^2+bx+c=0: \n");

            Console.Write("Input a value for 'a': ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Input a value for 'b': ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Input a value for 'c': ");
            c = int.Parse(Console.ReadLine());

            d = b * b - 4 * a * c;
            if (d == 0)
            {
                x1 = -b / (2.0 * a);
                x2 = x1;
                Console.Write("First Root = {0}\n", x1);
                Console.Write("Second Root = {0}\n", x2);
            }
            else if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);

                Console.Write("First Root = {0}\n", x1);
                Console.Write("Second Root = {0}\n", x2);
            }
            else if (d < 0)
            {
                Console.Write("There is no Real Number solution.");
            }
            Console.Read();
        }
    }
}
