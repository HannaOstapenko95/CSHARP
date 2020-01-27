﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAIN_NAM;

namespace NULLABLES_NAM
{
    public class NullableTypesExamples
    {
        public void NULLABLES_M()
        {
            Console.WriteLine("23\t\t\tNullables");
            int? num1 = null;
            int? num2 = 45;
            double? num3 = new double?();
            double? num4 = 3.14157;
            bool? boolval = new bool?();
            // display the values
            Console.WriteLine("Nullables at Show: {0}, {1}, {2}, {3}", num1, num2, num3, num4);
            Console.WriteLine("A Nullable boolean value: {0}", boolval);
            double? num11 = null;
            double? num21 = 3.14157;
            double num31;
            num31 = num11 ?? 5.34;
            Console.WriteLine(" Value of num3: {0}", num31);
            num31 = num21 ?? 5.34;
            Console.WriteLine(" Value of num3: {0}", num31);
            Program.CheckReturnToContent();
        }
    }
}
