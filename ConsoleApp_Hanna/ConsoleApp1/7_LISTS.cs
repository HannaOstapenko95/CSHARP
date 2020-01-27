using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAIN_NAM;

namespace LISTS_NAM
{
    public class LISTS
    {
        public void LISTS_M()
        {
            Console.WriteLine("\t\t\t\t\t LISTS");//using System.Collections.Generic;
            List<int> numbers = new List<int>();
            numbers.Add(11);
            numbers.Add(12);
            numbers.Add(13);
            numbers.Add(14);
            Console.WriteLine(numbers[1]);
            for (int i = 0; i < numbers.Count; i++)
                Console.Write(numbers[i] + ", ");
            Console.WriteLine("\n");
            Console.WriteLine("Remove element with index[0]");
            numbers.RemoveAt(0);
            for (int i = 0; i < numbers.Count; i++)
                Console.WriteLine(numbers[i] + ", ");
            Console.WriteLine("Remove element 13");
            numbers.Remove(13);
            for (int i = 0; i < numbers.Count; i++)
                Console.WriteLine(numbers[i] + ", ");
            //List<double> grades = new List<double>(); OR:
            var grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };
            grades.Add(56.1);
            var res1 = 0.0;
            foreach (var number in grades)
            {
                res1 += number;
            }
            res1 /= grades.Count;
            Console.WriteLine("Average = " + res1);
            Console.WriteLine($"The Average grade is {res1:N1}");
            Console.WriteLine($"The Average grade is {res1:N4}");
            Program.CheckReturnToContent();
        }
    }
}
