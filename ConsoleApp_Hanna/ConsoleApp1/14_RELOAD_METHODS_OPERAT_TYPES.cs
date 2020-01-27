using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MAIN_NAM;
using TEAM_PLAYER_NAM;
using Counter_Calc_Timer_NAM;

namespace RELOAD_METHODS_OPERAT_TYPES_NAM
{
    public class RELOAD_METHODS_OPERAT_TYPES
    {
        public void RELOAD_METHODS_OPERAT_TYPES_M()
        {
            //Type of parameters of methods should be different, or number of parameters
            Console.WriteLine("\t\t\tReload of Methods, Reload of Operators, Type conversions");
            SomeReloadMeth test = new SomeReloadMeth();
            //versions of methods should differ by the number or type of parameters, not ONLY via type of methods - void/int..
            //Method signature = method name + number of params + types of params). Return type is not a method signature
            test.Multiply(2, 23);
            test.Multiply3(2, 23, 2);
            test.Multiply(2, 23, 2);
            test.Multiply(2, 23, 2, 2);
            test.Multiply("Text from Reload of Method");
            //Reload of Operators
            Counter_Calc_Timer.Counter c1 = new Counter_Calc_Timer.Counter { Value = 23 };
            Counter_Calc_Timer.Counter c2 = new Counter_Calc_Timer.Counter { Value = 11 };
            int x = c2 + 20;
            Counter_Calc_Timer.Counter c3 = c1 + c2;
            Console.WriteLine("Reload of Operator + = " + c3.Value);
            bool res = c1 > c2;
            Console.WriteLine("Reload of Operator > = " + res);
            Counter_Calc_Timer.Counter counter = new Counter_Calc_Timer.Counter() { Value = 0 };
            if (counter)
                Console.WriteLine(true);
            else
                Console.WriteLine(false);
            object x8 = null;
            object y8 = x8 ?? 100;  // равно 100, так как x равен null
            object z = 200;
            object t = z ?? 44; // равно 200, так как z не равен null
                                //Reload of Types/Classes
            Counter_Calc_Timer.Counter counter1 = new Counter_Calc_Timer.Counter { Seconds = 115 };
            int x1 = (int)counter1; //for explicit
            Counter_Calc_Timer.Counter counter2 = x1;
            byte y = (byte)x; //explicit
            counter1.Seconds = 115;
            Counter_Calc_Timer.Timer timer1 = counter1;
            Console.WriteLine($"{timer1.Hours}:{timer1.Minutes}:{timer1.Seconds}");
            Counter_Calc_Timer.Counter counter3 = (Counter_Calc_Timer.Counter)timer1;
            Console.WriteLine(counter3.Seconds);
            Console.WriteLine("INDEXATORS");
            Team_Player.Team inter = new Team_Player.Team();
            inter[0] = new Team_Player.Player { Name = "Ronaldo", Number = 9 };
            inter[1] = new Team_Player.Player { Name = "R. Baggio", Number = 10 };
            inter[2] = new Team_Player.Player { Name = "Simeone", Number = 8 };
            Console.WriteLine(inter[1]?.Name);
            //Method Signatures = Method name + Param types
            Program.CheckReturnToContent();
        }

        class SomeReloadMeth //Reload of Methods
        {
            public void Multiply(int a, int b)
            {
                Console.WriteLine("Result is:" + a * b);
            }
            public void Multiply3(int a, int b, int c)
            {
                Console.WriteLine("Result of another method is:" + a * b * c);
            }
            public void Multiply(int a, int b, int c)
            {
                Console.WriteLine("Result of reload is:" + a * b * c);
            }
            public void Multiply(int a, int b, int c, int d)
            {
                Console.WriteLine("Result of reload is:" + a * b * c * d);
            }
            public void Multiply(string a)
            {
                Console.WriteLine("Result of reload is:" + a);
            }
        }
    }
}
