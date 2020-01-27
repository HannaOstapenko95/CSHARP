using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAIN_NAM;

namespace TRY_CATCH_NAM
{
    public class TRY_CATCH
    {
        public void TRY_CATCH_M()
        {
            Console.WriteLine("\t\t\tTry & Catch");
            Console.WriteLine("Enter number: ");
            try
            {
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Num is - " + num1);
                //finally - will work
            }
            catch (FormatException)
            { //DivideByZeroException, Exception(for all), IndexOutOfRangeException
                Console.WriteLine("Format Exception");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"IndexOutOfRangeException {ex.Message}");
            }
            finally //works 100% - not mandatory
            {
                Console.WriteLine("End from FINALLY block");
            }
            int[] nums = new int[4];
            try
            {
                nums[5] = 23;
                Console.WriteLine("Try block END");
            }
            /*catch
             {
                 Console.WriteLine("Error occured");
             }*/
            catch (Exception ex) //for general
            {
                Console.WriteLine($"Error occured {ex.Message}");
                Console.WriteLine("Error occured");;
            }
            try
            {
                Console.WriteLine("Write string:");
                string s = Console.ReadLine();
                if (s.Length > 4)
                {
                    throw new Exception("Length is more than 4");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occured {ex.Message}");
            }
            int x8 = 0;
            int y8 = 0;
            try
            {
                int result = x8 / y8;
            }
            catch (DivideByZeroException) when (y8 == 0 && x8 == 0)
            {
                Console.WriteLine("Y should not be equal ZERO");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                int x = 5;
                int y = x / 0;
                Console.WriteLine($"Result: {y}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                Console.WriteLine($"Method: {ex.TargetSite}");
                Console.WriteLine($"Stack trace: {ex.StackTrace}");
            }
            Program.CheckReturnToContent();
        }
    }
}
