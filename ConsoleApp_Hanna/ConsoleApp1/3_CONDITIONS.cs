using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAIN_NAM;

namespace CONDITIONS_NAM
{
    public class CONDITIONS
    {
        public void CONDITIONS_M()
        {
            Console.WriteLine("3\t\t\t\tConditions (IF/ELSE, SWITCH/CASE)");
            Console.WriteLine("\t\t\t\t\t\tIF/ELSE IF/ELSE");
            double j;
            Console.WriteLine("How old are you?");
            j = Convert.ToDouble(Console.ReadLine());
            if (j > 18 && j < 50)
                Console.WriteLine("You are older than 18 AND smaller than 50\n");
            else if (j == 18 || j == 50)
                Console.WriteLine("You are 18 OR 50\n");
            else if (j>50)
                Console.WriteLine("You are older than 50\n");
            else
                Console.WriteLine("You are smaller than 18\n");
            Console.WriteLine("\t\t\t\t\t\tSHORT IF/ELSE IF/ELSE");
            string name = j >= 25 ? "You are 25 OR older than 25" : "You are younger than 25";
            int x = 3;
            int y = 2;
            Console.WriteLine("Write + or - ");
            string sel = Convert.ToString(Console.ReadLine());
            int res = (sel == "+") ? (x + y) : (x - y);
            Console.WriteLine("Result of ternarn operator = " + res);
            Console.WriteLine("\t\t\t\t\tSWITCH/CASE & RANDOM NUMBER");
            Console.WriteLine("C# generates random number (F) from 1 to 3");
            Random randNum = new Random();
            int f = randNum.Next(1, 4);
            Console.WriteLine("Random number (F) = " + f);
            switch (f)
            {
                case 1:
                    Console.WriteLine("F is equal " + f);
                    break;
                case 2:
                    Console.WriteLine("F is equal " + f);
                    break;
                case 3:
                    Console.WriteLine("F is equal " + f);
                    break;
                default:
                    Console.WriteLine("Other");
                    break;
            }
            Console.WriteLine("\t\t\tPattern Matching with SWITCH");
            Console.WriteLine("Enter number from 1 to 4");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Your number = " + num);
            switch (num)
            {
                case var b when b == 1:
                    Console.WriteLine("F is equal " + f);
                    break;
                case var b when b == 2:
                    Console.WriteLine("F is equal " + f);
                    break;
                case var b when b == 3:
                    Console.WriteLine("F is equal " + f);
                    break;
                case var b when b == 4:
                    Console.WriteLine("F is equal " + f);
                    break;
                default:
                    Console.WriteLine("Other");
                    break;
            }
            Console.WriteLine("Write char YY or TT or NN");
            string k = Convert.ToString(Console.ReadLine());
            switch (k)
            {
                case "YY":
                    Console.WriteLine("Case = YY");
                    // return; - exit at all
                    goto case "NN";
                    //break;
                case "TT":
                    Console.WriteLine("Case = TT");
                    return;
                case "NN":
                    Console.WriteLine("Case = NN");
                    break;
            }
            Program.CheckReturnToContent();
        }
    }
}
