using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAIN_NAM;

namespace LOOPS_NAM
{
    public class LOOPS
    {
        public void LOOPS_M()
        {
            Console.WriteLine("\t\t\t\t\tFOR");
            //new 
            int prod;
            int sum;
            int i;
            sum = 0;
            prod = 1;
            for (i = 1; i <= 10; i++)
            {
                sum = sum + i;
                prod = prod * i;
            }
            Console.WriteLine("Sum is " + sum);
            Console.WriteLine("Product is " + prod);
            Console.WriteLine("\t\t\tMissing Pieces");
            int i1;
            for (i1 = 0; i1 < 10;)
            {
                Console.WriteLine("Pass #" + i1);
                i1++; // increment loop control var
            }
            int i2;
            i2 = 0; // move initialization out of loop
            for (; i2 < 10;)
            {
                Console.WriteLine("Pass #" + i2);
                i2++; // increment loop control var
            }
            //for ( ; ;) = endless
            int i3;
            int sum1 = 0;
            // Sum the numbers through 5.
            for (i3 = 1; i3 <= 5; sum1 += i3++) ;
            Console.WriteLine("Sum is " + sum1);
            Console.WriteLine("Another FOR with IF (CONTINUE):");
            for (int ii = 10; ii >= 5; ii -= 1)
            {
                if (ii == 8)
                    continue;//пропуск 8, но не выход с функции
                             //break - exit loop
                Console.WriteLine(ii + "\t");
            }
            Console.WriteLine("Another FOR with IF (BREAK):");
            for (int ii = 10; ii >= 5; ii -= 1)
            {
                if (ii == 8)
                    break;//break - exit loop
                Console.WriteLine(ii + "\t");
            }
            Console.WriteLine("\t\t\t\t\tWHILE");
            int iii = 0;
            while (iii <= 6)
            {
                Console.Write(iii + "\t");
                iii++;
            }
            Console.WriteLine("\n");
            Console.WriteLine("\t\t\t\t\t DO WHILE");
            Console.WriteLine("You should enter number until you enter 5");
            int numb;
            do
            {
                Console.WriteLine("Enter number = ");
                numb = Convert.ToInt32(Console.ReadLine());
            } while (numb != 5);
            Console.WriteLine("\n");
            Program.CheckReturnToContent();
        }
    }
}
