using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAIN_NAM;
/*using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;*/

namespace PREPROCESSOR_DIRECTIVES_NAM
{
    public class PREPROCESSOR_DIRECTIVES
    {
        public void PREPROCESSOR_DIRECTIVES_M()
        {
            /*IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");*/
            Console.WriteLine("\t\t\tPreprocessor Directives");
#if (DEBUG && !VC_V10)
            Console.WriteLine("DEBUG is defined");
#elif (!DEBUG && VC_V10)
            Console.WriteLine("VC_V10 is defined");
#elif (DEBUG && VC_V10)
            Console.WriteLine("DEBUG and VC_V10 are defined");
#else
            Console.WriteLine("DEBUG and VC_V10 are not defined");
#endif
            Program.CheckReturnToContent();
        }
    }
}
