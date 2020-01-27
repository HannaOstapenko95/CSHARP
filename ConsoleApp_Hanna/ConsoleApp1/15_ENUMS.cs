using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAIN_NAM;
using ANIMALS_NAM;

namespace ENUMS_NAM
{
    public enum Breed { Dog, Cat, Bird, Tiger }; //ENUM

    public class ENUMS
    {

        public void ENUMS_M()
        {

            //Enum
            Console.WriteLine("\t\t\tENUM");
            Animal dog = new Animal(Breed.Tiger);
            dog.Print();
            Days day = Days.Tuesday;
            Console.WriteLine("Day = " + day);
            Console.WriteLine("Day = " + (int)day);
            ApplyOperation_enum(10, 15, Oper.Add);
            ApplyOperation_enum(10, 15, Oper.Multiply);
            Oper op;
            op = Oper.Multiply;
            Console.WriteLine((int)op); 
            Program.CheckReturnToContent();
        }

        static void ApplyOperation_enum(double x, double y, Oper ep)
        {
            double res = 0.0;
            switch (ep)
            {
                case Oper.Add:
                    res = x + y;
                    break;
                case Oper.Divide:
                    res = x / y;
                    break;
                case Oper.Multiply:
                    res = x * y;
                    break;
                case Oper.Subtract:
                    res = x - y;
                    break;
            }
            Console.WriteLine($"Result of Operatin {ep} (via enum)" + res);
        }

        enum Days
        {
            Monday = 10,//0
            Tuesday,//1
            Wednesday//2
        }
        enum Color
        {
            White = 1,
            Black = 2,
            Green = 2,
            Blue = White // Blue = 1
        }
        enum Oper { Add, Subtract, Divide, Multiply }

       
        enum Time : byte //byte, int, short, long
        {
            Morning,
            Evening
        }
    }
}
