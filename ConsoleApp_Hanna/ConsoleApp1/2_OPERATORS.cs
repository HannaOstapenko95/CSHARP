using System;
using System.Text;
using System.Threading.Tasks;
using MAIN_NAM;

namespace OPERATORS_NAM
{
    public class OPERATORS
    {
        public void OPERATIONS()
        {
            Console.WriteLine("2\t\t\t\tOPERATORS");
            Console.WriteLine("\t\t\tDemonstrate the % operator");
            int iresult, irem;
            double dresult, drem;
            iresult = 10 / 3;
            irem = 10 % 3;
            dresult = 10.0 / 3.0;
            drem = 10.0 % 3.0;
            Console.WriteLine("Result and remainder of 10 / 3: " +
            iresult + " " + irem);
            Console.WriteLine("Result and remainder of 10.0 / 3.0: " +
            dresult + " " + drem);
            Console.WriteLine("\t\t\tIncrement & Decrement");
            Console.WriteLine("Demonstrate the difference between prefix and postfix forms of ++");
            int a = 4; //Postfix/Prefix increment/decrement
                       //int b = a++; //a=5, b=4
            int b = ++a; //a=5, b=5
            Console.WriteLine($"a ={a} b = {b}");
            int aa = 4;
            //int bb = --aa;//aa=3. bb=3
            int bb = aa--;//aa=3. bb=4
            Console.WriteLine($"aa ={aa} bb = {bb}");
            int a1 = 3, b1 = 5, c1 = 40;
            int d2 = 0;
            int d1 = c1-- - b1 * a1; 
            d2 = (c1 - (--b1)) * a1; //d2=108
            //39 - 4 * 3             //(c--)=40  c=39
                                     //b*a=15
                                     //40-15 =25
            Console.WriteLine($"a1 ={a1} b1 = {b1} c1 = {c1} d2={d2}");
            Console.WriteLine($"a1 ={a1} b1 = {b1} c1 = {c1} d1={d1}");
            int x11, y11;
            int i;
            x11 = 1;
            y11 = 0;
            Console.WriteLine("Series generated using y = y + x++;");
            for (i = 0; i < 10; i++)
            {
                y11 = y11 + x11++; // postfix ++
                Console.WriteLine(y11 + " ");
            }
            Console.WriteLine();
            x11 = 1;
            y11 = 0;
            Console.WriteLine("Series generated using y = y + ++x;");
            for (i = 0; i < 10; i++)
            {
                y11 = y11 + ++x11; // prefix ++
                Console.WriteLine(y11 + " ");
            }
            Console.WriteLine();
            Console.WriteLine("\t\t\tRelational & Logical Operators");
            int i2, j;
            bool b11, b2;
            i2 = 10;
            j = 11;
            if (i2 < j) Console.WriteLine("i < j");
            if (i2 <= j) Console.WriteLine("i <= j");
            if (i2 != j) Console.WriteLine("i != j");
            if (i2 == j) Console.WriteLine("this won't execute");
            if (i2 >= j) Console.WriteLine("this won't execute");
            if (i2 > j) Console.WriteLine("this won't execute");
            b11 = true;
            b2 = false;
            if (b11 & b2) Console.WriteLine("this won't execute");
            if (!(b11 & b2)) Console.WriteLine("!(b1 & b2) is true");
            if (b11 | b2) Console.WriteLine("b1 | b2 is true");
            if (b11 ^ b2) Console.WriteLine("b1 ^ b2 is true");
            //==, !=, &&, || - second operand we may not calculate
            bool t1 = (5 > 6) | (4 < 6); // -; + True - if 1 is true -> true
            bool t12 = (5 > 6) | (4 > 6); // -; - False
            bool t13 = (5 < 6) & (7 > 6); // +; + True - if 2 true -> true
            Console.WriteLine($"T1 = {t1}, T12 = {t12}, T13 = {t13}");
            Console.WriteLine("\t\t\tImplication operator !p | q");
            bool p = false, q = false;
            int i21, j21;
            for (i21 = 0; i21 < 2; i21++)
            {
                for (j21 = 0; j21 < 2; j21++)
                {
                    if (i21 == 0) p = true;
                    if (i21 == 1) p = false;
                    if (j21 == 0) q = true;
                    if (j21 == 1) q = false;
                    Console.WriteLine("p is " + p + ", q is " + q);
                    if (!p | q) Console.WriteLine(p + " implies " + q +
                     " is " + true);
                    Console.WriteLine();
                }
            }
            Console.WriteLine("\t\t\tArithmetic Operators");
            int x, y;
            Console.WriteLine("Enter first number");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result of ADDIDNG is " + (x + y).ToString());
            Console.WriteLine("Result of MULTIPLICATION is " + (x * y).ToString());
            Console.WriteLine("Result of SUBTRACTION is " + (x - y).ToString());
            Console.WriteLine("\t\t\tBitwise Logical operations: & | ^ ~ <<, >>");
            int x1 = 2; //010
            int x2 = 5; //101
                        //000 - &
                        //111 - 7 - |
            Console.WriteLine($"Logical multiplication (&) of {x1} and {x2} =" + (x1 & x2));
            Console.WriteLine($"Logical sum (|) of {x1} and {x2} =" + (x1 | x2));
            int y1 = 4; //100
                        //int y3 = 0b100; = 4
            int y2 = 0b101; //101 = 5
                            //100 - 4 - &
                            //101 = 5 - |
                            //001 = XOR ^
            int encrypt = y1 ^ y2;
            int y3 = 9; //1001 -> 0110
            Console.WriteLine($"Logical multiplication (&) of {y1} and {y2} =" + (y1 & y2));
            Console.WriteLine($"Logical sum (|) of {y1} and {y2} =" + (y1 | y2));
            Console.WriteLine($"Logical XOR ENCRYPT (^) of {y1} and {y2} =" + (encrypt));
            int decrypt = encrypt ^ y2;
            Console.WriteLine($"Logical XOR DECRYPT (^) of {y1} =" + (decrypt));
            Console.WriteLine($"Logical Deny (~) of {y3} =" + (~y3));
            Console.WriteLine($"Result of ~{y3} =" + Convert.ToString((~y3), 2));
            int x3 = 4; //100
            Console.WriteLine(x3 << 1); //1000 - 8
            Console.WriteLine(x3 << 2); //10000 - 16
            Console.WriteLine(x3 >> 1); //10 - 2
            Console.WriteLine(x3 >> 2); //1 - 1
            Console.WriteLine("\t\t\tBitwise AND to make a number even");
            ushort num;
            ushort i3;
            for (i3 = 1; i3 <= 10; i3++)
            {
                num = i3;
                Console.WriteLine("num: " + num);
                num = (ushort)(num & 0xFFFE);
                Console.WriteLine("num after turning off bit zero: "
                + num + "\n");
            }
            Console.WriteLine("\t\t\tBitwise AND to determine if a number is odd");
            ushort num1;
            num1 = 10;
            if ((num1 & 1) == 1)
                Console.WriteLine("This won't display.");
            num1 = 11;
            if ((num1 & 1) == 1)
                Console.WriteLine(num1 + " is odd.");
            Console.WriteLine("\t\t\t? Operator");
            Console.WriteLine("\t\t\tPrevent a division by zero using the ?");
            int result;
            for (int i31 = -5; i31 < 6; i31++)
            {
                result = i31 != 0 ? 100 / i31 : 0;
                if (i31 != 0)
                    Console.WriteLine("100 / " + i31 + " is " + result);
            }
            Console.WriteLine("\t\t\tDivide by only even, non-zero values");
            for (int i5 = -5; i5 < 6; i5++)
                if (i5 != 0 ? (i5 % 2 == 0) : false)
                    Console.WriteLine("100 / " + i5 + " is " + 100 / i5);
            Program.CheckReturnToContent();
        }
    }
}
