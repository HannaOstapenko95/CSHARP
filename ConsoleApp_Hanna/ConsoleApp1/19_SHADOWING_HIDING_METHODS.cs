using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAIN_NAM;
using PERSON_NAM;

namespace SHADOWING_HIDING_METHODS_NAM
{
    public class SHADOWING_HIDING_METHODS
    {
        public void SHADOWING_HIDING_METHODS_M()
        {
            Console.WriteLine("\t\t\tShadowing / hiding of methods, properties, variables");
            Person1 bob = new Person1("Bob", "Robertson");
            bob.Display();      // Bob Robertson

            Employee tom = new Employee("Tom", "Smith", "Microsoft");
            tom.Display();      // Tom Smith работает в Microsoft. New method Display()
            Program.CheckReturnToContent();
        }
    }
}
