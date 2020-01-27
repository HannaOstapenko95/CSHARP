using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAIN_NAM;
using MULTI_INHERITANCE_NAM;

namespace TEST_CLASSES_NAM
{
    //[DebuggerDisplay("First name = {FirstName} Approved = {Approved}")]
    interface ISomeInterface //no access modificator needed
    {
        int property { get; set; }
        void Print(); //method needed to be realized in inherided
    }
    interface IDraw //no access modificator needed
    {
        void Draw(); //method needed to be realized in inherided
    }

    public class Test_classescs
    {
        public class Test : ISomeInterface, IDraw
        {
            public int property { get; set; }
            public void Print()
            {
                Console.WriteLine("Text_1 from Interface");
            }
            public void Draw()
            {
                Console.WriteLine("From second interface - Draw method");
            }
        }

        public class Test2 : ISomeInterface
        {
            public int property { get; set; }
            public void Print()
            {
                Console.WriteLine("Text_2 from Interface");
            }
        }
    }
}
