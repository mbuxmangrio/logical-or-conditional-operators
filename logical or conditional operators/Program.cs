using System.ComponentModel.DataAnnotations;

namespace logical_or_conditional_operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arithmetic operators.
            int e = 50;
            int f = 40;
            var g = e + f;
            Console.WriteLine($" Addition (+) :{g}");
            g = e - f;
            Console.WriteLine($"Substraction (-) :{g}");
            g = e * f;
            Console.WriteLine($"Multiplication (*) :{g}");
            g = e / f;
            Console.WriteLine($"Division (/) :{g}");
            g = e % f;
            Console.WriteLine($"modulo (%) :{g}");
            //increment and decrement.
            int n = 6;
            Console.WriteLine(++n);
            Console.WriteLine(n++);
            Console.WriteLine(n);
            Console.WriteLine(--n);
            Console.WriteLine(n--);
            Console.WriteLine(n);

            //Assignment operators.
            int h1 = 60; int h2 = 70;
            var j = h1 += h2;
            Console.WriteLine($" Addition :{h1}");
            j = h1 -= h2;
            Console.WriteLine($"Substraction  :{h1}");
            j = h1 *= h2;
            Console.WriteLine($"Multiplication  :{h1}");
            j = h1 /= h2;
            Console.WriteLine($"Division :{h1}");
            j = h1 %= h2;
            Console.WriteLine($"Modulo :{h1}");
            //Relational operators.
            int k = 70;
            int l = 60;
            var m = k == l;
            Console.WriteLine($"Equal to:{m}");
            m = k > l;
            Console.WriteLine($"Greater than :{m}");
            m = k < l;
            Console.WriteLine($"Less than :{m}");
            m = k != l;
            Console.WriteLine($"Not equal to :{m}");
            m = k >= l;
            Console.WriteLine($"Greater than or equal to :{m}");
            m = k <= l;
            Console.WriteLine($"Less than or equal to:{m}");
            //logical AND && example program.
            int a = 60;
            int b = 50;
            bool c = (a > b) && (b < a);//if both conditions are true then result is also true.
            Console.WriteLine(c);
            c = (a > b) && (b > a);//if first condition is true and second one condition is false then result is false.
            Console.WriteLine(c);
            c = (a < b) && (b < a);//if first condition is false and second one is true then result is false.
            Console.WriteLine(c);
            c = (a < b) && (b > a);// if both conditions are false then result is also false.
            Console.WriteLine(c);
            // logical OR || example program.
            int x = 40;
            int y = 50;
            bool z = (x==y) ||(x != y);// if first condition is false and second is true then result is true.
            Console.WriteLine(z);
            z = (x <= y) || (x >= y);//if first condition is true and second is false then result is also true.
            Console.WriteLine(z);
            z = (x > y) || (y < x);//if both conditions are false then result is definately false.
            Console.WriteLine(z);
            z = (x < y) || (y > x);//and same way if both are true then result is true.
            Console.WriteLine(z);
            int s = 20; int t = 60;
            Math.Max(20, 60);
            Console.WriteLine("Math.Max{20,60}");
        //Ternary operators.
            int o = int.Parse(Console.ReadLine());
            string d = (o >= 18) ? "You are eligible to vote" : "You are not eligible to vote";
            Console.WriteLine(d);
            Console.ReadLine();















        }
    }
}
