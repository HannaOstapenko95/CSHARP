using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using MAIN_NAM;

namespace REGUL_EXP_IO_NAM
{
    public class REGUL_EXP_IO
    {
        public void REGUL_EXP_IO_M()
        {
            Console.WriteLine("\t\t\tRegular Expressions, File I/O");
            Console.WriteLine("Searching words that start on M and end on E");
            string str = "make maze milk and manage to measure it";
            Console.WriteLine("Matching words start with 'm' and ends with 'e':");
            showMatch(str, @"\bm\S*e\b");
            Console.WriteLine("Removing EXTRA spaces");
            string input = "Hello   World   ";
            string pattern = "\\s+";
            string replacement = " ";

            Regex rgx = new Regex(pattern);
            string result = rgx.Replace(input, replacement);

            Console.WriteLine("Original String: {0}", input);
            Console.WriteLine("Replacement String: {0}", result);


            /*FileStream F = new FileStream(@"U:\C#-TRAINING\app\HAOK-master\ConsoleApp2\ConsoleApp1\test_bytes.txt", FileMode.OpenOrCreate,
            FileAccess.ReadWrite);*/
            /*FileStream F = new FileStream(@"D:\C\ConsoleApp_Hanna\ConsoleApp_Hanna\ConsoleApp1\test_bytes.txt", FileMode.OpenOrCreate,
            FileAccess.ReadWrite);*/
            FileStream F = new FileStream(@"U:\C#-TRAINING\1\ConsoleApp_Hanna\ConsoleApp_Hanna\ConsoleApp1\test_bytes.txt", FileMode.OpenOrCreate,
            FileAccess.ReadWrite);

            for (int i = 1; i <= 20; i++)
            {
                F.WriteByte((byte)i);
            }
            F.Position = 0;
            for (int i = 0; i <= 20; i++)
            {
                Console.Write(F.ReadByte() + " ");
            }
            F.Close();

            Program.CheckReturnToContent();
        }

        private static void showMatch(string text, string expr)
        {
            Console.WriteLine("The Expression: " + expr);
            MatchCollection mc = Regex.Matches(text, expr);

            foreach (Match m in mc)
            {
                Console.WriteLine(m);
            }
        }
    }
}
