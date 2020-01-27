using System;
using MAIN_NAM;

namespace STRINGS_NAM
{
    public class STRINGS
    {
        public void STRINGS_M()
        {
            Console.WriteLine("\t\t\tStrings");
            string a = "Hello";
            Console.WriteLine("Second character of \"Hello\" = " + a[1]);
            string str = "   ";
            Console.WriteLine(str[2] + "Length of 3 spaces: " + str.Length);
            Console.WriteLine(String.IsNullOrEmpty(str));//if Spaces = False
            Console.WriteLine(String.IsNullOrWhiteSpace(str));//if Spaces or \t = True
            Console.WriteLine(String.Compare("a", "b")); //b>a -> -1;  a=a ->0, a>b ->1, a<b ->1
            string str1 = "HELLO MY WORLD, ARCENAL, Dynamo";
            Console.WriteLine("String: " + str1);
            Console.WriteLine("To Lower: " + str1.ToLower());
            Console.WriteLine("To Upper: " + str1.ToUpper());
            Console.WriteLine("To Lower: " + str1.ToLower());
            Console.WriteLine("String contains \"LLO\": " + str1.Contains("LLO"));
            Console.WriteLine("String starts with \"HEL\": " + (str1.StartsWith("HEL")));
            Console.WriteLine("String ends with \"RLD\": " + str1.EndsWith("RLD"));
            Console.WriteLine("String ends with \"nal\": " + str1.EndsWith("nal"));
            Console.WriteLine("Insert D after 2: " + str1.Insert(2, "D")); //insert after
            Console.WriteLine("Remove all after 3d element: " + str1.Remove(3)); //Remove after
            Console.WriteLine("Replace \"HE\" on \"CA\": " + str1.Replace("HE", "CA"));
            char[] sym = str1.ToCharArray(); //convert string to array
            string[] clubs = str1.Split(',');
            Console.WriteLine("Second element of array from string = " + clubs[2]);
            string action = "Add John Drumps";
            action.Split(' ');
            if (action == "Add")
            {
                Console.WriteLine("Add");
                Console.WriteLine(action);
            }
            else if (action.StartsWith("Add"))
            {
                var arg = action.Split(' ');
                Console.WriteLine("After splitting:" + action);
            }
            Program.CheckReturnToContent();
        }
    }
}
