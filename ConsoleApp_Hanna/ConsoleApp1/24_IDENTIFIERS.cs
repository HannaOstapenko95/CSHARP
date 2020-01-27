using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAIN_NAM;

namespace IDENTIFIERS_NAM
{
    public class IDENTIFIERS
    {
        public void IDENTIFIERS_M()
        {
            Console.WriteLine("\t\t\tIdentifiers");
            //new
            int @if; // use if as an identifier
            for (@if = 0; @if < 10; @if++)
                Console.WriteLine("@if is " + @if);
            Program.CheckReturnToContent();
        }
    }
    }

