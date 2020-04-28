#define DEBUG
#define VC_V10
using System;
using VARIABLES_NAM;
using OPERATORS_NAM;
using CONDITIONS_NAM;
using LOOPS_NAM;
using ARRAYS_NAM;
using MULTI_ARRAYS_NAM;
using LISTS_NAM;
using STRINGS_NAM;
using TRY_CATCH_NAM;
using CLASSES_OBJECTS_M;
using METHODS_FUNCTIONS_NAM;
using INHERITANCE_ASIS_NAM;
using MULTI_INHERITANCE_NAM;
using RELOAD_METHODS_OPERAT_TYPES_NAM;
using ENUMS_NAM;
using STRUCTURES_NAM;
using TUPLES_NAM;
using REFERENCES_NAM;
using SHADOWING_HIDING_METHODS_NAM;
using REGUL_EXP_IO_NAM;
using PREPROCESSOR_DIRECTIVES_NAM;
using NAMESPACES_NAM;
using NULLABLES_NAM;
using IDENTIFIERS_NAM;
using FILE_SYSTEM_NAM;
using LINQ_NAM;

namespace MAIN_NAM 
{
    public class Program
    {

        public static void Main(string[] args) //Метод Main ничего не возвращает 
            {
            Console.WriteLine("\t\t\t\t\t\t C#\n");
                Content();
                try
                    {
                        CASES();
                    }
                catch (Exception x)
                    {
                        Console.WriteLine("INFORMATIVE DESCRIPTION OF ERROR: \n " + x);
                        CheckReturnToContent();
                    }
            
            /*GC.Collect();
            GC.Collect(1, GCCollectionMode.Forced);
            GC.WaitForPendingFinalizers();*/
        }
        public static bool Content()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t\t\t\tCONTENT\n");
            Console.WriteLine("1__________Variable types & Literals & Casting and Type Conversions");
            Console.WriteLine("\t1_1__________ Literals, String format/output");
            Console.WriteLine("\t1_2__________ Variable types");
            Console.WriteLine("\t1_3__________ Casting & Type Conversions");
            Console.WriteLine("2__________Operators");
            Console.WriteLine("3__________Conditions (IF/ELSE, SWITCH/CASE)");
            Console.WriteLine("4__________Loops (FOR/WHILE/DO WHILE)");
            Console.WriteLine("5__________Arrays");
            Console.WriteLine("6__________Multi-dimensional arrays & Jagged Array");
            Console.WriteLine("7__________Lists & Dictionaries");
            Console.WriteLine("8__________Strings");
            Console.WriteLine("9__________Try & Catch");
            Console.WriteLine("10_________Classes & Objects, Properties, GET/SETS");
            Console.WriteLine("11_________Methods, Functions, ref, out, param, recursion");
            Console.WriteLine("12_________Inheritance, AS/IS, Virtual methods, Abstract classes");
            Console.WriteLine("13_________Multi-Interfaces");
            Console.WriteLine("14_________Reload of Method, Reload of Operators, Type conversions");
            Console.WriteLine("15_________Enums");
            Console.WriteLine("16_________Structures, Massive of structures");
            Console.WriteLine("17_________Tuples");
            Console.WriteLine("18_________REFERENCES Variables & Methods");
            Console.WriteLine("19_________Shadowing / hiding of methods, properties, variables");
            Console.WriteLine("20_________Regular Expressions, File I/O");
            Console.WriteLine("21_________Preprocessor Directives - CHECK");
            Console.WriteLine("22_________Namespaces");
            Console.WriteLine("23_________Nullables");
            Console.WriteLine("24_________Identifiers");
            Console.WriteLine("25_________Working with Disks(streams and file system)");
            Console.WriteLine("26_________LINQ)");
            //long totalMemory = GC.GetTotalMemory(false);
            //Console.WriteLine(Convert.ToString(totalMemory));
            return true;
        }
        public static void CheckReturnToContent()
        {
            Console.WriteLine("\nPress Y - to go to the CONTENT, Z - to EXIT");
            char g = 'a';
            do
            {
                try
                {
                    g = Convert.ToChar(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error is: \n" + ex + "\n");
                    CheckReturnToContent();
                }

            }
            while (g != 'Y' && g != 'Z');
            if (g == 'Y')
            {
                Content();
                CASES();
            }
            else if (g == 'Z')
                Environment.Exit(0);
        }
        public static void CASES()
        {
            int x_choose;
            try
            {
                x_choose = Convert.ToInt32(Console.ReadLine());
                if (x_choose > 26 || x_choose < 1)
                {
                    Console.WriteLine("\t\t\tEntered number is out of scope!");
                    Console.WriteLine("\t\t\tPlease, reenter number!");
                    CASES();
                }
                else
                {
                    switch (x_choose)
                    {
                        case 1: //Working with variables
                            {
                                Console.BackgroundColor = ConsoleColor.Green;
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine("1\t\t\t\tVARIABLE TYPES & LITERALS & CASTING and TYPE CONVERSIONS");
                                Console.WriteLine("1_1\tLITERALS");
                                Console.WriteLine("1_2\tVARIABLE TYPES");
                                Console.WriteLine("1_3\tCASTING & TYPE CONVERSIONS");
                                VARIABLES vars = new VARIABLES();
                                vars.VARIABLES_TYPES_CAST_M();
                                break;
                            }
                        case 2: //Basic operations
                            {
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Black;
                                OPERATORS oper = new OPERATORS();
                                oper.OPERATIONS();
                                break;
                            }
                        case 3: //Conditions (IF/ELSE, SWITCH/CASE)
                            {
                                Console.BackgroundColor = ConsoleColor.DarkGreen;
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.White;
                                CONDITIONS cond = new CONDITIONS();
                                cond.CONDITIONS_M();
                                break;
                            }
                        case 4: //Loops (FOR/WHILE/DO WHILE)
                            {
                                Console.BackgroundColor = ConsoleColor.Cyan;
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                LOOPS loop_block = new LOOPS();
                                loop_block.LOOPS_M();
                                break;
                            }
                        case 5: //ARRAYS
                            {
                                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.White;
                                ARRAYS arr = new ARRAYS();
                                arr.ARRAYS_M();
                                break;
                            }
                        case 6: //Multi-dimensional arrays
                            {
                                Console.BackgroundColor = ConsoleColor.DarkGray;
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                MULTI_ARRAYS arr_m = new MULTI_ARRAYS();
                                arr_m.MULTI_ARRAYS_M();
                                break;
                            }
                        case 7: //Lists - we don't know number of elements, uses more memory
                            {
                                Console.BackgroundColor = ConsoleColor.DarkBlue;
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.White;
                                LISTS list = new LISTS();
                                list.LISTS_M();
                                break;
                            }
                        case 8: //Strings
                            {
                                STRINGS str = new STRINGS();
                                str.STRINGS_M();
                                break;
                            }
                        case 9: //Try & Catch
                            {
                                TRY_CATCH tr = new TRY_CATCH();
                                tr.TRY_CATCH_M();
                                break;
                            }
                        case 10: //Object & Classes, Properties, GET/SETS (for private)
                            {
                                CLASSES_OBJECTS clas = new CLASSES_OBJECTS();
                                clas.CLASSES_OBJECTS_M();
                                break;
                            }
                        case 11: //METHODS, FUNCTIONS, 
                            {
                                METHODS_FUNCTIONS mth = new METHODS_FUNCTIONS();
                                mth.METHODS_FUNCTIONS_M();
                                break;
                            }
                        case 12: //INHERITANCE, AS/IS, Virtual methods (From External Class file)
                            {
                                INHERITANCE_ASIS_VIRT inh = new INHERITANCE_ASIS_VIRT();
                                inh.INHERITANCE_ASIS_M();
                                break;
                            }
                        case 13:
                            {
                                MULTI_INHERITANCE m_inh = new MULTI_INHERITANCE();
                                m_inh.MULTI_INHERITANCE_M();
                                break;
                            }
                        case 14:
                            {
                                RELOAD_METHODS_OPERAT_TYPES reloading = new RELOAD_METHODS_OPERAT_TYPES();
                                reloading.RELOAD_METHODS_OPERAT_TYPES_M();
                                break;
                            }
                        case 15:
                            {
                                ENUMS enums = new ENUMS();
                                enums.ENUMS_M();
                                break;
                            }
                        case 16:
                            {
                                STRUCTURES str = new STRUCTURES();
                                str.STRUCTURES_M();
                                break;
                            }
                        case 17:
                            {
                                TUPLES tupl = new TUPLES();
                                tupl.TUPLES_M();
                                break;
                            }
                        case 18:
                            {
                                REFERENCES refer = new REFERENCES();
                                refer.REFERENCES_M();
                                break;
                            }
                        case 19:
                            {
                                SHADOWING_HIDING_METHODS shad = new SHADOWING_HIDING_METHODS();
                                shad.SHADOWING_HIDING_METHODS_M();
                                break;
                            }
                        case 20:
                            {
                                REGUL_EXP_IO reg = new REGUL_EXP_IO();
                                reg.REGUL_EXP_IO_M();
                                break;
                            }
                        case 21:
                            {
                                PREPROCESSOR_DIRECTIVES prep = new PREPROCESSOR_DIRECTIVES();
                                prep.PREPROCESSOR_DIRECTIVES_M();
                                break;
                            }
                        case 22:
                            {
                                NAMESPACES nam = new NAMESPACES();
                                nam.NAMESPACES_M();
                                break;
                            }
                        case 23:
                            {
                                NullableTypesExamples nullab = new NullableTypesExamples();
                                nullab.NULLABLES_M();
                                break;
                            }
                        case 24:
                            {
                                IDENTIFIERS iden = new IDENTIFIERS();
                                iden.IDENTIFIERS_M();
                                break;
                            }
                        case 25:
                            {
                                FILE_SYSTEM files = new FILE_SYSTEM();
                                files.FILE_SYSTEM_M();
                                break;
                            }
                        case 26:
                            {
                                LINQ link = new LINQ();
                                link.LINQ_M();
                                break;
                            }
                    }
                }
            }
            catch (Exception x)
            {
                Console.WriteLine("INFORMATIVE DESCRIPTION OF ERROR: \n " + x);
                CheckReturnToContent();
            }

        }
        public int Calculation_for_Test( int x, int y)
        {
            int s = x + y;
            return s;
        }
        

    }
  
} 









