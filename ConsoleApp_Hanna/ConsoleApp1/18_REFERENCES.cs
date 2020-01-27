using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAIN_NAM;

namespace REFERENCES_NAM
{
    public class REFERENCES
    {
        public void REFERENCES_M()
        {
            //REFERENCES
            Console.WriteLine("17\t\t\tREFERENCES Variables & Methods");
            int x = 5;
            ref int xRef = ref x; //xRef points on the same place in memory as variable x
            Console.WriteLine($"x={x}");
            Console.WriteLine($"xRef={xRef}");
            xRef = 125;
            Console.WriteLine($"x={x}");
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
            ref int nRef = ref Find(numbers, 4);
            Console.WriteLine(numbers[3]);//4
            nRef = 45;
            Console.WriteLine(numbers[3]);//45
            try
            {
                ref int nRef1 = ref Find(numbers, 85);
                Console.WriteLine(nRef1);
            }
            catch (Exception ex) { Console.WriteLine("Error:" + ex.Message); }
            Program.CheckReturnToContent();
        }
        static ref int Find(int[] numbers, int number)//find element "number" in array "numbers" and return reference on number in array
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == number)
                {
                    return ref numbers[i];
                }
            }
            throw new Exception("Number not found");
        }
    }
}
