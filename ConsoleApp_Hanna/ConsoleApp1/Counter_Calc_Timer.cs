using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter_Calc_Timer_NAM
{
    public class Counter_Calc_Timer
    {
        public class Counter
        {
            public int Seconds { get; set; }
            //Преобразование типов
            public static implicit operator Counter(int x)//want to change type int to Counter
            {
                return new Counter { Seconds = 150 };
            }
            public static explicit operator int(Counter counter)//want to change type int to Counter
            {
                return counter.Seconds;
            }
            //Преобразование classes
            public static explicit operator Counter(Timer timer)
            {
                int h = timer.Hours * 3600;
                int m = timer.Minutes * 60;
                return new Counter { Seconds = h + m + timer.Seconds };
            }
            public static implicit operator Timer(Counter counter)
            {
                int h = counter.Seconds / 3600;
                int m = (counter.Seconds - h * 3600) / 60;
                int s = counter.Seconds - h * 3600 - m * 3600;
                return new Timer { Hours = h, Minutes = m, Seconds = s };
            }

            public int Value { get; set; }
            //Reload of operators
            public static Counter operator +(Counter c1, Counter c2)
            {
                return new Counter { Value = c1.Value + c2.Value };
            }
            public static int operator +(Counter c1, int x) //the order of parameters - important!
            {
                return c1.Value + x;
            }
            public static bool operator >(Counter c1, Counter c2)
            {
                if (c1.Value > c2.Value)
                    return true;
                else return false;
            }
            public static bool operator <(Counter c1, Counter c2)
            {
                if (c1.Value > c2.Value)
                    return false;
                else return true;
            }
            public static bool operator true(Counter c1)
            {
                return c1.Value != 0;
            }
            public static bool operator false(Counter c1)
            {
                return c1.Value == 0;
            }

        }
       public class Timer
        {
            public int Hours { get; set; }
            public int Minutes { get; set; }
            public int Seconds { get; set; }
        }
        public class Calculator
        {
            public static void Add(int x, int y)
            {
                int z = x + y;
                Console.WriteLine($"Sum {x} and {y} equals {z}"); //Interpolation of strings
            }
        }
    }
}
