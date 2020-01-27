using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAIN_NAM;

namespace TUPLES_NAM
{
    public class TUPLES
    {
        public void TUPLES_M()
        {
            //Tuples Кортеж
            Console.WriteLine("\t\t\tTUPLES");
            //var tuple1 = (5, 10);
            (int, int) tuple1 = (5, 10);
            Console.WriteLine("First Tuple item = " + tuple1.Item1);
            Console.WriteLine("Second Tuple item = " + tuple1.Item2);
            tuple1.Item1 += 20;
            Console.WriteLine("First item + 20 = " + tuple1.Item1);
            var tuple2 = (count: 55, sum: 100);
            Console.WriteLine("First Tuple item = " + tuple2.count);
            Console.WriteLine("SecondTuple item = " + tuple2.sum);
            var (name, age) = ("Hanna", 24);
            Console.WriteLine(name);
            Console.WriteLine(age);
            //Use Tuple to return several values from function
            var tuple = GetValTuple();
            Console.WriteLine(tuple.Item1);
            Console.WriteLine(tuple.Item2);
            //Method returns tuple and takes tuple and int
            var tuple3 = GetValTuple1(("Toma", 25), 10);
            Console.WriteLine(tuple3.Item1);
            Console.WriteLine(tuple3.Item2);
            var tuple5 = GetNamedValues(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            Console.WriteLine(tuple5.count);
            Console.WriteLine(tuple5.sum);
            var (name1, age1) = GetTuple(("Tom", 23), 12);
            Console.WriteLine(name1);    // Tom
            Console.WriteLine(age1);     // 35
            Program.CheckReturnToContent();
        }
        static (int, int) GetValTuple() //Method returns tuple
        {
            int res = 1111;
            int res2 = 2222;
            return (res, res2);
        }
        static (string, int) GetValTuple1((string, int) tuple, int x) //Method returns tuple and takes tuple and int
        {
            var res = (name: tuple.Item1, age: tuple.Item2 + x);
            return res;
        }
        private static (int sum, int count) GetNamedValues(int[] numbers)//For Tuple
        {
            var result = (sum: 0, count: 0);
            for (int i = 0; i < numbers.Length; i++)
            {
                result.sum += numbers[i];
                result.count++;
            }
            return result;
        }

        private static (string name, int age) GetTuple((string n, int a) tuple, int x)
        {
            var result = (name: tuple.n, age: tuple.a + x);
            return result;
        }
    }
}
