using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAIN_NAM;

namespace LISTS_NAM
{
    public class LISTS //If number of elements is unknown before reading. Can be resized at any time
    {//More flexible, 
        public void LISTS_M()
        {
            Console.WriteLine("\t\t\t\t\t LISTS & DICTIONARIES");//using System.Collections.Generic;
            List<string> daysOfWeek = new List<string>
            { 
                "Monday",
                "Tuesday",
                "Wenesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
            List<int> numbers = new List<int>(); //always starts empty
            numbers.Add(11);
            numbers.Add(12);
            numbers.Add(13);
            numbers.Add(14);
            Console.WriteLine(numbers[1]);
            for (int i = 0; i < numbers.Count; i++)
                Console.Write(numbers[i] + ", ");
            Console.WriteLine("\n");
            Console.WriteLine("Remove element with index[0]");
            numbers.RemoveAt(0);
            for (int i = 0; i < numbers.Count; i++)
                Console.WriteLine(numbers[i] + ", ");
            Console.WriteLine("Remove element 13");
            numbers.Remove(13);
            for (int i = 0; i < numbers.Count; i++)
                Console.WriteLine(numbers[i] + ", ");
            //List<double> grades = new List<double>(); OR:
            var grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };
            grades.Add(56.1);
            var res1 = 0.0;
            foreach (var number in grades) //ONLY FOR READING COLLECTIONS, NOT MODIFYING
            {
                res1 += number;
            }
            res1 /= grades.Count;
            Console.WriteLine("Average = " + res1);
            Console.WriteLine($"The Average grade is {res1:N1}");
            Console.WriteLine($"The Average grade is {res1:N4}");
            //Read data from CSV file as array
            string filePath = @"U:\C#-TRAINING\1\ConsoleApp_Hanna\countries.csv";
            CsvReader reader = new CsvReader(filePath);
            List<Country> countries = reader.ReadAllCountries();
            //reader.RemoveCommaCountries(countries);
            Country liliput = new Country("Liliput", "LIL", "Somewhere", 200_000);
            int liliputIndex = countries.FindIndex(x => x.Population < 200_000);
            countries.Insert(liliputIndex, liliput); //Insert in the middle of the list in specified index
            countries.RemoveAt(liliputIndex);
            Console.WriteLine("\t\tUSING LINQ (.Take) & Foreach"); //LINQ does not support batching
            foreach (Country country_list in countries.Take(1))
            {
                // Console.WriteLine($"{country.Population}: {country.Name}");
                Console.WriteLine($"{PopulationFormatter.FormatPopulation(country_list.Population).PadLeft(15)}: {country_list.Name}");

            }
            Console.WriteLine("\t\tUSING LINQ (.OrderBy.Take) & Foreach");
            foreach (Country country_list in countries.OrderBy(x => x.Name).Take(2))
            {
                // Console.WriteLine($"{country.Population}: {country.Name}");
                Console.WriteLine($"{PopulationFormatter.FormatPopulation(country_list.Population).PadLeft(15)}: {country_list.Name}");

            }
            Console.WriteLine("\t\tUSING LINQ (.Take.WHERE) & Foreach");
            var filteredCountries = countries.Where(x => !x.Name.Contains(','));//.Take(6); //LINQ method syntax
            var filteredCountries_2 = from country_list in countries
                                      where !country_list.Name.Contains(',')
                                      select country_list;
            foreach (Country country_list in filteredCountries_2)
            {
                Console.WriteLine($"{PopulationFormatter.FormatPopulation(country_list.Population).PadLeft(15)}: {country_list.Name}");
            }
            Console.WriteLine("\t\tUSING FOR");
            for (int i = 0; i <countries.Count; i++)
            {
                Country country_list = countries[i];
                Console.WriteLine($"{PopulationFormatter.FormatPopulation(country_list.Population).PadLeft(15)}: {country_list.Name}");

            }
            Console.WriteLine($"{countries.Count} countries");
            //Iterating only some items
            Console.WriteLine("Enter no. of countries to display >");
            bool inputIsInt = int.TryParse(Console.ReadLine(), out int userInput_2);
            if(!inputIsInt || userInput_2 <= 0)
            {
                Console.WriteLine("You must type in a +ve integer. Exiting");
                return;
            }
            //int maxToDisplay = Math.Min(userInput_2, countries.Count);
            int maxToDisplay = userInput_2;
            /* for (int i = 0; i < maxToDisplay; i++)
             {
                 Country country_list = countries[i];
                 Console.WriteLine($"{PopulationFormatter.FormatPopulation(country_list.Population).PadLeft(15)}: {country_list.Name}");
             }*/
            //for (int i = 0; i < countries.Count; i++)
            for (int i = countries.Count - 1; i >= 0; i--)
            {
                //Batching an iteration
                int displayIndex = countries.Count - 1 - i;
                // if(i>0 && (i% maxToDisplay == 0))
                if (displayIndex > 0 && (displayIndex % maxToDisplay == 0))
                {
                    Console.WriteLine("Hit return to continue, anything else to quit");
                    if (Console.ReadLine() != "")
                        break;
                }
                //
                Country country_list = countries[i];
                //Console.WriteLine($"{i + 1}: {PopulationFormatter.FormatPopulation(country_list
                Console.WriteLine($"{displayIndex + 1}: {PopulationFormatter.FormatPopulation(country_list.Population).PadLeft(15)}: {country_list.Name}");
            }



            //DICTIONARIES - NON ORDERED (Key + Value). KEYs MUST be UNIQUE
            Console.WriteLine("\t\t\tDICTIONARIES");
            Country norway = new Country("Norway", "NOR", "Europe", 568_785);
            Country finland = new Country("Finland", "FIN", "Europe", 268_785);
            var countries_dict = new Dictionary<string, Country>(); //Always empty. Key + Value
            /*var countries_dict = new Dictionary<string, Country> //Initialization
            {
                { norway.Code, norway },
                { finland.Code, finland }
            };*/
            countries_dict.Add(norway.Code, norway);
            countries_dict.Add(finland.Code, finland);
            //Console.WriteLine(countries["MUS"].Name);
            bool exists = countries_dict.TryGetValue("MUS", out Country country);
            if (exists)
            {
                Console.WriteLine(country.Name);
            }
            else Console.WriteLine("There is no country with code MUS");

            Country selectedCountry = countries_dict["NOR"];
            Console.WriteLine(selectedCountry.Name);
            Console.WriteLine("Dictionary:");
            foreach (var countr in countries_dict.Values)
                Console.WriteLine(countr.Name);

            Dictionary<string, Country> countries_from_file = reader.ReadAllCountries_DICT();
            Console.WriteLine("Write country code do you want to look up?");
            string userInput = Console.ReadLine();

            bool gotCountry = countries_from_file.TryGetValue(userInput, out Country country_from);
            if (!gotCountry) Console.WriteLine($"Sorry, there is no country with code, { userInput}");
            else Console.WriteLine($"{country_from.Name} has population {PopulationFormatter.FormatPopulation(country_from.Population)}");

            Console.WriteLine("\t\t\tCollections of Collections");
            Dictionary<string, List<Country>> countries_col_col = reader.ReadAllCountries_Collection_of_Collaction();
            foreach (string region in countries_col_col.Keys)
                Console.WriteLine(region);
            Console.Write("Which of above regions do youwant to display?");
            string chosenRegion = Console.ReadLine();
            if (countries_col_col.ContainsKey(chosenRegion))
            {
                foreach(Country country_col_col in countries_col_col[chosenRegion].Take(4))
                    Console.WriteLine($"{PopulationFormatter.FormatPopulation(country_col_col.Population).PadLeft(15)} : { country_col_col.Name}");
            }
        else 
            Console.WriteLine("That is not a valid region");
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
        public CsvReader(string csvFilePath)
        {
            this._csvFilePath = csvFilePath;
        }
        public List<Country> ReadAllCountries()
        {
            List<Country> countries = new List<Country>();//UnKnow size, but no values
            using (StreamReader sr = new StreamReader(_csvFilePath))
            {
                //read header line
                sr.ReadLine();
                string csvLine;
                while ((csvLine = sr.ReadLine()) != null)
                {
                    countries.Add(ReadCountryFromCsvLine(csvLine));
                }
            }
            return countries;
        }
        public void RemoveCommaCountries(List<Country> countries)
        {
            /* for (int i = 0; i< countries.Count; i++)
             {
                 if (countries[i].Name.Contains(',')) countries.RemoveAt(i); //Remove element by Index
             }*/
            countries.RemoveAll(x => x.Name.Contains(',')); //LAMBDA expression. Predicate - remove if it is true
        }
        public Dictionary<string, Country> ReadAllCountries_DICT()
        {
            var countries = new Dictionary<string, Country>();
            using (StreamReader sr = new StreamReader(_csvFilePath))
            {
                //read header line
                sr.ReadLine();
                string csvLine;
                while ((csvLine = sr.ReadLine()) != null)
                {
                    Country country = ReadCountryFromCsvLine(csvLine);
                    countries.Add(country.Code, country);
                }
            }
            return countries;
        }
        public Dictionary<string, List<Country>> ReadAllCountries_Collection_of_Collaction()
        {
            var countries = new Dictionary<string, List<Country>>();
            using (StreamReader sr = new StreamReader(_csvFilePath))
            {
                //read header line
                sr.ReadLine();
                string csvLine;
                while ((csvLine = sr.ReadLine()) != null)
                {
                    Country country = ReadCountryFromCsvLine(csvLine);
                    if (countries.ContainsKey(country.Region))
                    {
                        countries[country.Region].Add(country);
                    }
                    else
                    {
                        List<Country> countriesInRegion = new List<Country>() { country };
                        countries.Add(country.Region, countriesInRegion);
                    }
                }
            }
            return countries;
        }
        public Country ReadCountryFromCsvLine(string csvLine)
        {
            string[] parts = csvLine.Split(';');
            /*string name = parts[0];
            string code = parts[1];
            string region = parts[2];
            int population = int.Parse(parts[3]);
            return new Country(name, code, region, population);*/
            string name;
            string code;
            string region;
            string popText;
            switch (parts.Length)
            {
                case 4:
                    name = parts[0];
                    code = parts[1];
                    region = parts[2];
                    popText = parts[3];
                    break;
                case 5:
                    name = parts[0] + ", " + parts[1];
                    name = name.Replace("\"", null).Trim();
                    code = parts[2];
                    region = parts[3];
                    popText = parts[4];
                    break;
                default:
                    throw new Exception($"Cannot parse lines from CSV: {csvLine}");
            }
            //TryParse leaves population = 0 if cannot parse
            int.TryParse(popText, out int population);
            return new Country(name, code, region, population);
        }
    }
    class PopulationFormatter
    {
        public static string FormatPopulation(int population)
        {
            if (population == 0) return "(Unknown)";
            int popRounded = RoundPopulation4(population);
            return $"{popRounded: ### ### ### ###}".Trim();
        }
        //Rounds the population to 4 significant figures
        private static int RoundPopulation4(int population)
        {
            int accuracy = Math.Max((int)(GetHighestPowerofThree(population) / 10_0001), 1);
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
