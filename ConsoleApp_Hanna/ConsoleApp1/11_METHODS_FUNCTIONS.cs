using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAIN_NAM;
using NUnit.Framework;

namespace METHODS_FUNCTIONS_NAM
{
    public class METHODS_FUNCTIONS
    {
        public void METHODS_FUNCTIONS_M()
        {
            //Function is method with no void witch returns something
            Console.WriteLine("\t\t\tMethods, Functions, ref, out, param, recursion");
            WriteHello();
            WriteHello2("Second method with arguments");
            Console.WriteLine("\t\t\t\tREF parameters, OUT parameters");
            Console.WriteLine("\t\tREF changes variable - not just copy");
            Console.WriteLine("\t\tOUT enables to return several results of one function");
            
            Console.WriteLine("Enter first number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Add(n1, n2); 
            //new
            Console.WriteLine("What is the name of your separate method?");
            string method = "New method";
            Console.WriteLine(AnnounceMethod(method));
            AnnounceMethod1(method);
            Console.WriteLine("N1 is now (doesn't change) = " + n1);
            int y1 = 9;
            AddRef(ref y1, 5); //REF changes variable - not just copy, so value of variable will change
            Console.WriteLine("Y1 is now (changed because of ref) " + y1);
            int par, area;
            DataParam(10, 15, out area, out par);
            int res = Multiply(n1, n2);
            Console.WriteLine("Result of multiplication = " + res);
            Console.WriteLine("\t\tUnnecessary parameters");
            Option(1, 2);
            Option(1, 2, 3);
            Option(1, 2, 3, 4);
            Console.WriteLine("\t\tNamed parameters");
            Option(s: 1, x: 2, z: 7, y: 9);
            Console.WriteLine("\t\tPARAMS parameters (unlimited number of parameters)");
            AdditionPARAMS(new int[] { 1, 2, 3, 4 });
            AdditionPARAMS(2, 3, 4, 5);
            AdditionPARAMS();
            AdditionPARAMS(4, 5);
            Addition(2, "Hello", 1, 2, 3, 4, 5);
            //Область видимости класса, метода, блока кода
            //Переменные метода перекрывают переменные класса
            int rr = 9;
            Console.WriteLine("\t\tRecursive Functions");
            Console.WriteLine("Factorial 5 (120) = " + Factorial(5));
            Console.WriteLine("Factorial 4 (24) = " + Factorial(4));
            Console.WriteLine("Fibonachi 8 (21) = " + Fibonachi(rr));
            SayHello();
            Addition1(1, 2, 3, 4, 5);
            int[] array = new int[] { 1, 2, 3, 4 };
            AdditionMas(array, 2);
            Program.CheckReturnToContent();
        }

        public static void WriteHello()
        {
            Console.WriteLine("Hello from Write Hello");
        }

        public static void WriteHello2(string str)
        {
            Console.WriteLine(str);
        }

        
        public static void Add(int n1, int n2)
        {
            n1 = n1 + n2;
            Console.WriteLine("Result of ADD is = " + (n1));
        }
        static string AnnounceMethod(string method)
        {
            return method + " this is a separate method";
        }
        static void AnnounceMethod1(string method)
        {
            Console.WriteLine(method + " this is a separate VOID method");
        }
        public static void AddRef(ref int r1, int r2)
        {
            r1 = r1 + r2;
            Console.WriteLine("Result of AddRef is = " + (r1));
        }
        public static void DataParam(int w, int h, out int area, out int param)
        {
            param = (w * h) * 2;
            area = w * h;
            Console.WriteLine($"Area = {area}, Param = {param}");
        }

        public static int Multiply(int n1, int n2)
        {
            return n1 * n2;
        }
        static int Option(int x, int y, int z = 5, int s = 7)
        {
            int d = (x + y + z + s);
            Console.WriteLine($"Sum of Option {x}, {y}, {z}, {s} = " + d);
            return d;
        }
        static void Addition(int x, string mes, params int[] integers)
        { }
        static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
                return n * Factorial(n - 1);
        }
        //F(n)=f(n-1)+f(n-2)
        static int Fibonachi(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            else return Fibonachi(n - 1) + Fibonachi(n - 2);
        }
        static void SayHello() => Console.WriteLine("Hello SayHello");
        static void AdditionPARAMS(params int[] numbers)
        {
            int res = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                res += numbers[i];
            }
            Console.WriteLine(res);
        }
        // передача параметра с params
        static void Addition1(params int[] integers)
        {
            int result = 0;
            for (int i = 0; i < integers.Length; i++)
            {
                result += integers[i];
            }
            Console.WriteLine(result);
        }
        // передача массива
        static void AdditionMas(int[] integers, int k)
        {
            int result = 0;
            for (int i = 0; i < integers.Length; i++)
            {
                result += (integers[i] * k);
            }
            Console.WriteLine(result);
        }



    }
}
