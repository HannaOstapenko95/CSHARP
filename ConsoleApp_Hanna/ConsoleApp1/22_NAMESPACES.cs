using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAIN_NAM;
using first_space;
using second_space;

namespace NAMESPACES_NAM
{
    public class NAMESPACES
    {
        public void NAMESPACES_M()
        {
            Console.WriteLine("\t\t\tNamespaces");
            first_space.namespace_cl fc = new first_space.namespace_cl();
            second_space.namespace_cl sc = new second_space.namespace_cl();
            fc.func();
            sc.func();
            Program.CheckReturnToContent();
        }
    }
}
namespace first_space
{
    class namespace_cl
    {
        public void func()
        {
            Console.WriteLine("Inside first_space");
        }
    }
}

namespace second_space
{
    class namespace_cl
    {
        public void func()
        {
            Console.WriteLine("Inside second_space");
        }
    }
}