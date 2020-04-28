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
            AppDomain currentAppDomain = AppDomain.CurrentDomain;
            currentAppDomain.UnhandledException += new UnhandledExceptionEventHandler(HandleException);

            Console.WriteLine("Enter first number:");
            int numb1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int numb2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter operation:");
            string operation = (Console.ReadLine()).ToUpperInvariant();
            try {
                Calculator calc = new Calculator();
                Console.WriteLine($"RESULT = { calc.Calculate(numb1, numb2, operation)}");

            }
            //Exception filter
            /*catch (ArgumentNullException ex) when (ex.ParamName == "operation")
            {
                Console.WriteLine($"Operation was not provided: {ex}");
            }
            catch (ArgumentNullException ex) 
            {
                Console.WriteLine($"Argument was null: {ex}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Operation is not supported: {ex}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Sorry, something goes wrong: {ex}");   
            }*/

            /*catch (CalculationOperationNotSupportedException ex)
            {
                //Log.Error(ex);
                Console.WriteLine(ex);
            }*/
            catch (CalculationException ex) //will catch also CalculationOperationNotSupportedException
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("...finally...");
            }

           
            Program.CheckReturnToContent();
        }

        private static void HandleException(object sender, UnhandledExceptionEventArgs e)
        {
            Console.WriteLine($"Sorry, there was a problem and we need to close. Details: {e.ExceptionObject}");
        }
    }
    public class Calculator
    {
        public int Calculate(int n1, int n2, string operation2)
        {
            //throw new ArgumentNullException(nameof(n1));
            //Way 1
            string notNullOperation = operation2 ?? throw new ArgumentNullException(nameof(operation2));
            //Way 2
            //if (operation2 is null)
            //{
            //    throw new ArgumentNullException(nameof(operation2));
            //}
            if (notNullOperation == "/")
            {
                try
                {
                    int res = Divide(n1, n2);
                    return res;
                }
                /*catch (DivideByZeroException ex)
                {
                    //throw;
                    throw new ArithmeticException("An error occured during calculation", ex); //wrapped exception
                }*/
                catch (ArithmeticException ex)
                {
                    //throw;
                    throw new CalculationException("Error occurred during devision", ex); //wrapped exception
                }
            }
            else
            {
                /*throw new ArgumentOutOfRangeException(nameof(operation2), "The mathematical operation is not supported");
                Console.WriteLine("Unknown operation");
                return 0;*/

                //throw new CalculationOperationNotSupportedException();

                throw new CalculationOperationNotSupportedException(operation2);
                return 0;
            }
        }

        int Divide(int n1, int n2)
        {
            int res = n1 / n2;
            return res;
        }
    }
    public class CalculationException : Exception
    {
        private static readonly string DefaultMessage = "An error occurred during calculating.";
        /// <summary>
        /// Creates a new <see cref="CalculationException"/> with a predefined message.
        /// </summary>
        public CalculationException() : base(DefaultMessage)
        {

        }
        /// <summary>
        /// Creates a new <see cref="CalculationException"/> with a user-supplied message.
        /// </summary>
        public CalculationException(string message) : base(message)
        {

        }
        /// <summary>
        /// Creates a new <see cref="CalculationException"/> with a predefined message and a wrapped inner exception.
        /// </summary>
        public CalculationException(Exception innerException) : base(DefaultMessage, innerException)
        {

        }
        /// <summary>
        /// Creates a new <see cref="CalculationException"/> with a user-supplied message and a wrapped inner exception.
        /// </summary>
        public CalculationException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
    public class CalculationOperationNotSupportedException : CalculationException
    {
        public string Operation { get; }
        /// <summary>
        /// Creates a new <see cref="CalculationOperationNotSupportedException"/> with a predefined parameter
        /// </summary>
        public CalculationOperationNotSupportedException() : base("Specified operation was out of the range of valid values.")
        {

        }
        /// <summary>
        /// Creates a new <see cref="CalculationOperationNotSupportedException"/> with the operation that is not supported
        /// </summary>
        public CalculationOperationNotSupportedException(string operation) : this()
        {
            Operation = operation;
        }
        /// <summary>
        /// Creates a new <see cref="CalculationOperationNotSupportedException"/> with the user-supplied message and a wrapped inner exception.
        /// </summary>
        public CalculationOperationNotSupportedException(string message, Exception innerException) : base(message, innerException)
        {
        }
        /// <summary>
        /// Creates a new <see cref="CalculationOperationNotSupportedException"/> with the user-supplied message and not-supported operation.
        /// </summary>
        public CalculationOperationNotSupportedException(string operation, string message) : base(message)
        {
            Operation = operation;
        }
        public override string Message
        {
            get
            {
                string message = base.Message;
                if (Operation != null)
                {
                    return message + Environment.NewLine + 
                        $"Unsupported operation {Operation}";
                }
                return message;
            }
        }
    }
}
