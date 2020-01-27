using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_display
{
    public class DisplayClass
    {
        public int age;
        string name;
        public void Display(string name)
        {
            Console.WriteLine($"Name: {name}");
        }
    }
}
