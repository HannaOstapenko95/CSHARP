using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MAIN_NAM;

namespace VARIABLES_NAM
{
    public class VARIABLES
    {
        public void VARIABLES_TYPES_CAST_M()
        {
            try
            {
                Start:  string choose = Convert.ToString(Console.ReadLine());
                if (choose == "1_1" || choose == "1_2" || choose == "1_3")
                {
                    switch (choose)
                    {
                        case "1_1":
                            {
                                Console.WriteLine("1_1\t\t\tLITERALS, String format/output");
                                //new //namespace.class.method 
                                System.Console.Write("Escape sequences: \n First line \t text after tab \t text after tab \nSecond line\n");
                                Console.WriteLine(3.2e3);   //равно 3.2 * 10<sup>3</sup> = 3200
                                Console.WriteLine(1.2E-1);  //равно 1.2 * 10<sup>-1</sup> = 0.12
                                Console.WriteLine("ASCII code " + '\x5A');    // Z
                                                                              //Console.WriteLine("Unicode " + '\u0420');    // Р
                                string name1 = "Tom";
                                int age1 = 34;
                                double height1 = 1.7;
                                Console.WriteLine($"\t\t\tString interpolation \nName: {name1}  Age: {age1}  Heigh: {height1}m");
                                Console.WriteLine("Name: {0}  Age: {2}  Heigh: {1}m", name1, height1, age1);
                                Console.WriteLine("\t\t\tString concatanation \nTime: " + DateTime.Now);
                                Console.WriteLine("\t\t\tString format/output, String literals");
                                //new
                                Console.WriteLine("You ordered " + 2 + " items at $" + 3 + " each.");
                                Console.WriteLine("February has {0} or {1} days.", 28, 29);
                                Console.WriteLine("February has {0,10} or {1,5} days.", 28, 29);
                                int i;
                                Console.WriteLine("Value\tSquared\tCubed");
                                for (i = 1; i < 10; i++)
                                    Console.WriteLine("{0}\t{1}\t{2}", i, i * i, i * i * i);
                                Console.WriteLine("Here is 10/3: {0:#.##}", 10.0 / 3.0);
                                Console.WriteLine("Here is 10/3: {0:#.###}", 10.0 / 3.0);
                                Console.WriteLine("{0:###,###.##}", 123456.56);
                                double res1 = 4.546789;
                                Console.WriteLine($"One digit: {res1:N1}");
                                Console.WriteLine($"Four digits: {res1:N4}");
                                decimal balance;
                                balance = 12323.09m;
                                Console.WriteLine("Current balance is {0:C}", balance);
                                Console.WriteLine("\t\t\tString Literals & Embed Quotes");
                                Console.WriteLine("\"Why?\", he asked.");
                                Console.WriteLine("Company \"Erst and Young\"");
                                Console.WriteLine("\t\t\tVerbatim String Literals");
                                Console.WriteLine(@"This is a verbatim
                                string literal
                                that spans several lines.
                                ");
                                Console.WriteLine(@"Here is some tabbed output:
                                1 2 3 4
                                5 6 7 8
                                ");
                                Console.WriteLine(@"Programmers say, ""I like C#.""");
                                Program.CheckReturnToContent();
                                break;
                            }
                        case "1_2":
                            {
                                Console.WriteLine("1_2\t\t\tVARIABLE TYPES");
                                Console.WriteLine("\tINT & DOUBLE");
                                int ivar; // this declares an int variable
                                double dvar; // this declares a floating-point variable
                                ivar = 100; // assign ivar the value 100
                                dvar = 100.0; // assign dvar the value 100.0
                                Console.WriteLine("Original value of ivar: " + ivar);
                                Console.WriteLine("Original value of dvar: " + dvar);
                                Console.WriteLine(); // print a blank line
                                                     // Now, divide both by 3.
                                ivar = ivar / 3;
                                dvar = dvar / 3.0;
                                Console.WriteLine("ivar after division: " + ivar);
                                Console.WriteLine("dvar after division: " + dvar);
                                Console.WriteLine("\tDOUBLE");
                                double radius;
                                double area;
                                radius = 10.0;
                                area = radius * radius * 3.1416;
                                Console.WriteLine("Area is " + area);
                                Double r1;
                                Double area1;
                                area1 = 10.0;
                                r1 = Math.Sqrt(area1 / 3.1416);
                                Console.WriteLine("Radius is " + r1);
                                Double theta; // angle in radians
                                for (theta = 0.1; theta < 0.3; theta = theta + 0.1)
                                {
                                    Console.WriteLine("Sine of " + theta + " is " +
                                    Math.Sin(theta));
                                    Console.WriteLine("Cosine of " + theta + " is " +
                                    Math.Cos(theta));
                                    Console.WriteLine("Tangent of " + theta + " is " +
                                    Math.Tan(theta));
                                    Console.WriteLine();
                                }
                                Console.WriteLine("\tLONG");
                                long inches;
                                long miles;
                                miles = 93000000; // 93,000,000 miles to the sun
                                                  // 5,280 feet in a mile, 12 inches in a foot.
                                inches = miles * 5280 * 12;
                                Console.WriteLine("Distance to the sun: " +
                                inches + " inches.");
                                Console.WriteLine("\tDECIMAL");
                                decimal price;
                                decimal discount;
                                decimal discounted_price;
                                // Compute discounted price.
                                price = 19.95m;
                                discount = 0.15m; // discount rate is 15%
                                discounted_price = price - (price * discount);
                                Console.WriteLine("Discounted price: $" + discounted_price);
                                decimal amount;
                                decimal rate_of_return;
                                int years, i;
                                amount = 1000.0M;
                                rate_of_return = 0.07M;
                                years = 10;
                                Console.WriteLine("Original investment: $" + amount);
                                Console.WriteLine("Rate of return: " + rate_of_return);
                                Console.WriteLine("Over " + years + " years");
                                for (i = 0; i < years; i++)
                                    amount = amount + (amount * rate_of_return);
                                Console.WriteLine("Future value is $" + amount);
                                Console.WriteLine("\tGet type");
                                ushort n1 = 1;//хранит целое число от 0 до 65535 и занимает 2 байта
                                var c5 = 20;
                                Console.WriteLine("Type = " + c5.GetType());
                                Console.WriteLine(c5.GetType().ToString());
                                bool t = true;
                                char c = 'c'; //Initialization - is given value while declaring
                                Console.WriteLine("\tBOOL");
                                bool b;
                                b = false;
                                Console.WriteLine("b is " + b);
                                b = true;
                                Console.WriteLine("b is " + b);
                                // A bool value can control the if statement.
                                if (b) Console.WriteLine("This is executed.");
                                b = false;
                                if (b) Console.WriteLine("This is not executed.");
                                // Outcome of a relational operator is a bool value.
                                Console.WriteLine("10 > 9 is " + (10 > 9));
                                //new
                                Console.WriteLine("\t\t\t\tDynamic Initialization");
                                // Length of sides.
                                double s1 = 4.0;
                                double s2 = 5.0;
                                // Dynamically initialize hypot.
                                double hypot = Math.Sqrt((s1 * s1) + (s2 * s2));
                                Console.Write("Hypotenuse of triangle with sides " +
                                s1 + " by " + s2 + " is ");
                                Console.WriteLine("{0:#.###}.", hypot);
                                Console.WriteLine("\t\t\t\tImplicitly Typed Variables");
                                var s11 = 4.1;
                                var s21 = 5.3;
                                // Now, hypot is implicitly typed. Its type is double
                                // because the return type of Sqrt() is double.
                                var hypot1 = Math.Sqrt((s11 * s11) + (s21 * s21));
                                Console.Write("Hypotenuse of triangle with sides " +
                                s11 + " by " + s21 + " is ");
                                Console.WriteLine("{0:#.###}.", hypot1);
                                var num = 10; //we cannot change type of variable by changing value
                                int o = 9;
                                uint n = 10;//>0
                                uint a3 = 10U;
                                long b3 = 20L;
                                ulong c3 = 30UL;
                                byte xx = 3;
                                double yy = 45.4; //by default if no "f"
                                decimal rate = 5.6M;
                                System.Int32 b4 = 4;
                                const float u = 1.22f;
                                object obj1 = 1;
                                object obj2 = "Object";
                                char e = 'r';
                                string w = "Hello";
                                Program.CheckReturnToContent();
                                break;
                            }
                        case "1_3":
                            {
                                Console.WriteLine("1_3\t\t\tCASTING & TYPE CONVERSIONS");
                                int i1;
                                float f;
                                i1 = 10;
                                f = i1; // assign an int to a float
                                        // Demonstrate implicit conversion from long to double.
                                long L;
                                double D;
                                L = 100123285L;
                                D = L;
                                Console.WriteLine("L and D: " + L + " " + D);
                                Console.WriteLine("\t\t\tCasting Incompatible Types");
                                // Demonstrate casting
                                //(target-type) expression
                                byte a11 = 4;
                                byte b11 = (byte)(a11 + 70);//сужающее преобразование (явно)
                                int b12 = a11 + 70;//1 byte -> 4 byte расширенное преобразование типов (неявно)
                                short c11 = (short)(a11 + 80);
                                //byte (1 byte) -> short (2 byte) -> int (4 byte) -> long (8 byte) -> decimal (16 byte)
                                //byte (1 byte) -> short (2 byte) -> int (4 byte) -> double (8 byte) 
                                //byte (1 byte) -> short (2 byte) -> float (4 byte) -> double (8 byte) 
                                //char (2 byte) -> int (4 byte)
                                //double -> X decimal
                                {
                                    double x, y;
                                    byte b1;
                                    int i11;
                                    char ch;
                                    uint u1;
                                    short s;
                                    long l;
                                    x = 10.0;
                                    y = 3.0;
                                    // Cast double to int, fractional component lost.
                                    i11 = (int)(x / y);
                                    Console.WriteLine("Integer outcome of x / y: " + i11);
                                    Console.WriteLine();
                                    // Cast an int into a byte, no data lost.
                                    i11 = 255;
                                    b1 = (byte)i11;
                                    Console.WriteLine("b after assigning 255: " + b1 +
                                    " -- no data lost.");
                                    // Cast an int into a byte, data lost.
                                    i11 = 257;
                                    b1 = (byte)i11;
                                    Console.WriteLine("b after assigning 257: " + b1 +
                                    " -- data lost.");
                                    Console.WriteLine();
                                    // Cast a uint into a short, no data lost.
                                    u1 = 32000;
                                    s = (short)u1;
                                    Console.WriteLine("s after assigning 32000: " + s +
                                    " -- no data lost.");
                                    // Cast a uint into a short, data lost.
                                    u1 = 64000;
                                    s = (short)u1;
                                    Console.WriteLine("s after assigning 64000: " + s +
                                    " -- data lost.");
                                    Console.WriteLine();
                                    // Cast a long into a uint, no data lost.
                                    l = 64000;
                                    u1 = (uint)l;
                                    Console.WriteLine("u after assigning 64000: " + u1 +
                                    " -- no data lost.");
                                    // Cast a long into a uint, data lost.
                                    l = -12;
                                    u1 = (uint)l;
                                    Console.WriteLine("u after assigning -12: " + u1 +
                                    " -- data lost.");
                                    Console.WriteLine();
                                    // Cast an int into a char.
                                    b1 = 88; // ASCII code for X
                                    ch = (char)b1;
                                    Console.WriteLine("ch after assigning 88: " + ch);
                                    byte b2;
                                    b2 = 10;
                                    b2 = (byte)(b2 * b2); // cast needed!!
                                    Console.WriteLine("b: " + b2);
                                    char ch1 = 'a', ch2 = 'b';
                                    ch1 = (char)(ch1 + ch2);
                                }
                                double n2;
                                for (n2 = 1.0; n2 <= 10; n2++)
                                {
                                    Console.WriteLine("The square root of {0} is {1}",
                                    n2, Math.Sqrt(n2));
                                    Console.WriteLine("Whole number part: {0}",
                                    (int)Math.Sqrt(n2));
                                    Console.WriteLine("Fractional part: {0}",
                                    Math.Sqrt(n2) - (int)Math.Sqrt(n2));
                                    Console.WriteLine();
                                }
                                Console.WriteLine("Converting a string to an int");
                                try
                                {
                                    int userinput = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Converting a string " + userinput + " to an int");
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("See Error Description: \n" + ex);
                                    Console.WriteLine("It is not a number!");
                                }
                                Console.WriteLine("How many people are in your band?");
                                int numberOfMembers = 0;
                                if (!int.TryParse(Console.ReadLine(), out numberOfMembers))
                                {
                                    Console.WriteLine("Input was not valid");
                                    //Environment.Exit(0);
                                }
                                double d11 = 33.0;
                                decimal d22 = (decimal)d11;
                                try
                                {
                                    int a12 = 33;
                                    int c12 = 600;
                                    byte b112 = checked((byte)(a12 + c12));
                                    Console.WriteLine($"Byte shortened - {b112}");
                                }
                                catch (OverflowException)
                                {
                                    Console.WriteLine("Not valid segment");
                                }
                                Program.CheckReturnToContent();
                                break;
                            }
                    }
                }
                else
                {
                    Console.WriteLine("Input value is wrong!");
                    goto Start;
                }
            }
            catch (Exception r)
            {
                Console.WriteLine("DESCRIPTION OF ERROR: \n" + r);
            }
        }
    }
 }

