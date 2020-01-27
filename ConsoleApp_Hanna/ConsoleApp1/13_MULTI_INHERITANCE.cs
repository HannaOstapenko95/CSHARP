using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAIN_NAM;
using TEST_CLASSES_NAM;

namespace MULTI_INHERITANCE_NAM
{
    public class MULTI_INHERITANCE
    {
        public void MULTI_INHERITANCE_M()
        {
            //Множественной наследование
            //Interfaces (like classes) - methods/properties are written in main class, but - realized in other classes(inherited)
            //In Abstract classes (can contain also general methods/properties) which can be realized in main class
            //In C# we cannot inhering methods/properties from several other(main) classes (was in C++)
            //But we can inherit some from several interfaces
            //Interfaces - enable to inherit info from several classes
            Console.WriteLine("\t\t\tINTERFACES (multi-inheritance)");
            Test_classescs.Test test_1 = new Test_classescs.Test();
            Test_classescs.Test2 test_2 = new Test_classescs.Test2();
            test_1.property = 12;
            test_1.Print();
            test_1.Draw();
            Console.WriteLine(test_1.property);
            Console.WriteLine();
            test_2.property = 15;
            test_2.Print();
            Console.WriteLine(test_2.property);
            Program.CheckReturnToContent();
        }
    }
}
