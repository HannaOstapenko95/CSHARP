using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAIN_NAM;

namespace ARRAYS_NAM
{
    public class ARRAYS //Fixed size & Defined Order, Zero indexing. Cannot change size after instantiation
    {
        public void ARRAYS_M()
        {
            Console.WriteLine("\t\t\t\t\tARRAYS");
            int[] nums3 = new int[] { 1, 2, 3, 5 };
            //int[] nums3 = new int[4] { 1, 2, 3, 5 };
            int[] nums4 = new[] { 1, 2, 3, 5 };
            int[] nums5 = { 1, 2, 3, 5 };
            int[] ar = new int[5];//массив
            ar[0] = 20;
            ar[1] = 21;
            ar[2] = 22;
            ar[3] = 23;
            ar[4] = 24;
            int[] ar1 = { 1, 2, 3 };
            int[] ar12 = new int[3] { 1, 2, 3 };
            Console.WriteLine("Third element = " + ar[3]);
            for (int i = 0; i < ar.Length; i++)
                Console.Write(ar[i] + ", ");
            Console.WriteLine("\n");
            string[] daysOfWeek = //Collection/Array Initializer 
            {
                "Monday",
                "Tuesday",
                "Wenesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
            Console.WriteLine("\nBefore: ");
            foreach (string day in daysOfWeek)
                Console.WriteLine(day);
            daysOfWeek[2] = "Wednesday";
            Console.WriteLine("\nAfter: ");
            foreach (string day in daysOfWeek)
                Console.WriteLine(day);

            Console.WriteLine("Which day do you want to display?");
            Console.WriteLine("Monday = 1, etc > ");
            int iDay = int.Parse(Console.ReadLine());
            string chosenDay = daysOfWeek[iDay-1];
            Console.WriteLine($"That day is {chosenDay}");

            string[] st = new string[3] { "Anna", "Helen", "Luda" };
            for (int i = 0; i < st.Length; i++)
                Console.Write(st[i] + ", ");
            var numbers = new double[3];
            numbers[0] = 12.7;
            numbers[1] = 10.3;
            numbers[2] = 6.11;
            var res = numbers[0];
            res += numbers[1];
            res += numbers[2];
            Console.WriteLine("\nSum of array elements = " + res);
            var numbers1 = new double[3] { 12.45, 7.345, 10.3};
            var numbers2 = new [] { 12.7, 10.3, 6.11, 4.1 };
            //List<double> grades = new List<double>();
            //var grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };
            var res1 = 0.0;
            foreach(var number in numbers2)
            {
                res1 += number;
            }
            Console.WriteLine("\nSum of array var elements = " + res1);

            //Read data from CSV file as array
            string filePath = @"U:\C#-TRAINING\1\ConsoleApp_Hanna\countries.csv";
            CsvReader reader = new CsvReader(filePath);
            //Same: Country[] countries = reader.ReadFirstNCountries(3);
            IList<Country> countries = reader.ReadFirstNCountries(3);
            foreach (Country country in countries)
            {
                // Console.WriteLine($"{country.Population}: {country.Name}");
                Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");

            }
            Program.CheckReturnToContent();

        }
    }
    class Country
    {
        public string Name { get; }
        public string Code { get; }
        public string Region { get; }
        public int Population { get; }
        public Country(string name, string code, string region, int population) //constructor
        {
            this.Name = name;
            this.Code = code;
            this.Region = region;
            this.Population = population;
        }
    }
    class CsvReader
    {
        private string _csvFilePath;
        public CsvReader (string csvFilePath)
        {
            this._csvFilePath = csvFilePath;
        }
        public Country[] ReadFirstNCountries (int nCountries)
        {
            Country[] countries = new Country[nCountries];//Know size, but no values
            using (StreamReader sr = new StreamReader(_csvFilePath))
            {
                //read header line
                sr.ReadLine();
                for (int i = 0; i < nCountries; i++)
                {
                    string csvLine = sr.ReadLine();
                    countries[i] = ReadCountryFromCsvLine(csvLine);
                }
            }
            return countries;
        }
        public Country ReadCountryFromCsvLine(string csvLine)
        {
            string[] parts = csvLine.Split(';');
            string name = parts[0];
            string code = parts[1];
            string region = parts[2];
            int population = int.Parse(parts[3]);
            return new Country(name, code, region, population);

        }
    }
    class PopulationFormatter
    {
        public static string FormatPopulation (int population)
        {
            if (population == 0) return "(Unknown)";
            int popRounded = RoundPopulation4(population);
            return $"{popRounded: ### ### ### ###}".Trim();
        }
        //Rounds the population to 4 significant figures
        private static int RoundPopulation4(int population)
        {
            int accuracy = Math.Max((int)(GetHighestPowerofThree(population)/10_0001), 1);
            return RoundToNearest(population, accuracy);
        }
        /// <summary>
        /// Rounds the number to the specified accuracy
        /// For example, if the accuracy is 10, then we round to the nearest 10:
        /// 23 -> 20
        /// 25 -> 30
        /// etc.
        /// </summary>
        /// <param name="exact"></param>
        /// <param name="accuracy"></param>
        /// <returns></returns>
        public static int RoundToNearest(int exact, int accuracy)
        {
            int adjusted = exact + accuracy / 2;
            return adjusted - adjusted % accuracy;
        }

        /// <summary>
        /// Returns the highest number that is a power of 10 and is no larger than the number supplied
        /// Examples:
        /// GetHighestPowerOfTen(11) = 10
        /// GetHighestPowerOfTen(99) = 10
        /// GetHighestPowerOfTen(100) = 100
        /// GetHighestPowerOfTen(843) = 100
        /// GetHighestPowerOfTen(1000) = 1000
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static long GetHighestPowerofThree(int x)
        {
            long result = 1;
            while (x > 0)
            {
                x /= 3;
                result *= 3;
            }
            return result;
        }
    }
}
