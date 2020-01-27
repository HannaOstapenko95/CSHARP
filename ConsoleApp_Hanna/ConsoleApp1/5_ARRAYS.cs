using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAIN_NAM;

namespace ARRAYS_NAM
{
    public class ARRAYS
    {
        public void ARRAYS_M()
        {
            Console.WriteLine("\t\t\t\t\tARRAYS");
            int[] nums3 = new int[] { 1, 2, 3, 5 };
            //int[] nums3 = new int[4] { 1, 2, 3, 5 };
            int[] nums4 = new[] { 1, 2, 3, 5 };
            int[] nums5 = { 1, 2, 3, 5 };
            int[] ar = new int[5];//массив
            ar[0] = 20;
            ar[1] = 21;
            ar[2] = 22;
            ar[3] = 23;
            ar[4] = 24;
            int[] ar1 = { 1, 2, 3 };
            int[] ar12 = new int[3] { 1, 2, 3 };
            Console.WriteLine("Third element = " + ar[3]);
            for (int i = 0; i < ar.Length; i++)
                Console.Write(ar[i] + ", ");
            Console.WriteLine("\n");
            string[] st = new string[3] { "Anna", "Helen", "Luda" };
            for (int i = 0; i < st.Length; i++)
                Console.Write(st[i] + ", ");
            var numbers = new double[3];
            numbers[0] = 12.7;
            numbers[1] = 10.3;
            numbers[2] = 6.11;
            var res = numbers[0];
            res += numbers[1];
            res += numbers[2];
            Console.WriteLine("\nSum of array elements = " + res);
            var numbers1 = new double[3] { 12.45, 7.345, 10.3};
            var numbers2 = new [] { 12.7, 10.3, 6.11, 4.1 };
            //List<double> grades = new List<double>();
            //var grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };
            var res1 = 0.0;
            foreach(var number in numbers2)
            {
                res1 += number;
            }
            Console.WriteLine("\nSum of array var elements = " + res1);
            Program.CheckReturnToContent();

        }
    }
}
