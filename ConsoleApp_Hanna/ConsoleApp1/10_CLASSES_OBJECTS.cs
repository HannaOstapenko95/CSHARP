using System;
using System.Collections.Generic;
using System.Text;
using MAIN_NAM;
using STUDENTS_NAM;
using ANIMALS_NAM;
using Counter_Calc_Timer_NAM;
using BANDS_NAM;


namespace CLASSES_OBJECTS_M
{
    public class CLASSES_OBJECTS
    {
        public void CLASSES_OBJECTS_M()
        {
            Console.WriteLine("\t\t\tClasses & Objects, Properties, GET/SETS");
            Console.WriteLine("\t\t\tWorking with CAT object");
            Animal cat = new Animal(); //object from class Animal
            Console.WriteLine("\t\t\tGet cat name:");
            Console.WriteLine(cat.name);
            Console.WriteLine("\t\t\tChanging CAT name");
            cat.name = "NEW NAME OF CAT";
            Console.WriteLine("\t\t\tGet cat new name:");
            Console.WriteLine(cat.name);
            Console.WriteLine("\t\t\tGet cat age:");
            Console.WriteLine(cat.age);
            Console.WriteLine("\t\t\tPrint CAT");
            cat.Print();
            Console.WriteLine();
            Console.WriteLine("CONST variable from class Animal:" + Animal.CONSTANT_STR);
            Console.WriteLine();

            Console.WriteLine("\t\t\tWorking with DOG object");
            Animal dog = new Animal(); //object from class Animal
            Console.WriteLine("\t\t\tChanging DOG surname");
            dog.Surname = "Ostapenko"; //from GET. Property - name as variable but capitalized
            string surn = dog.Surname; //via SET
            Console.WriteLine("Dog Surname from GET/SET = " + dog.Surname);
            Console.WriteLine("Constant of class Animal = " + Animal.T);
            //Animal.T = 200; cannot change constant
            //dog.R cannot change READONLY
            int r = dog.R;
            Console.WriteLine("Readonly of class Animal = " + dog.R);
            //dog.R = 34; //dog.R cannot change READONLY
            Console.WriteLine("\t\t\tPrint DOG");
            dog.Print();

            Console.WriteLine("\t\t\tWorking with COW object");
            Animal cow = new Animal("Dolla", "Martyvna", 3, 6.4f);
            Console.WriteLine("\t\t\tPrint COW");
            cow.Print();
            Console.WriteLine("Count of Animals = " + Animal.count);

            Console.WriteLine("\t\t\tWorking with STUDENTS object");
            //Constructors - for initialisation of objects
            Students.Student student1 = new Students.Student();
            //Student student2 = new Student("Helen", 4, false);
            //Initialisator instead of constructor:
            Console.WriteLine("Course of student1 = " + student1.Course);
            student1.Course = 2; //change the value of field COurse via SET
                                 //program can not set value if it is invalid due to conditions in SET
            student1.Course1 = 9;
            student1.Print();
            Console.WriteLine("Old Course of student1 = " + student1.Course);
            Console.WriteLine("New Course of student1 = " + student1.Course1);

            Console.WriteLine("\t\t\tCreating second STUDENT object");
            Students.Student student2 = new Students.Student { name = "Helen", course = 4, step = false };
            Console.WriteLine("\t\t\tPrinting second STUDENT object");
            student2.Print();

            Console.WriteLine("\t\t\tADD Method from Calculator class");
            Counter_Calc_Timer.Calculator.Add(2, 3);
            Console.WriteLine("\t\t\tADD Method from Library Display class");
            Library_display.DisplayClass disp = new Library_display.DisplayClass();
            disp.Display("Test from Library Display class");

            //new
            Console.WriteLine("\t\t\tWorking with BANDs");
            Console.WriteLine("What is the name of your band?");
            BANDS_NAM.Band band = new BANDS_NAM.Band();
            band.Name = Console.ReadLine();
            band.Announce();

            Console.WriteLine("What is the name of your venue?");
            Venue1 venue = new Venue1();
            venue.Name = "The Jazz Hut";
            string[] bandNames = { "Jazztallica", "Jazzadeth" };
            venue.AddBand(bandNames);
            venue.Announce();

            Console.WriteLine("\t\t\tWorking with BOOK objects");
            var book = new Book();
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.grades.Add(101);
            Book book2 = new Book();
            var grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };
            grades.Add(56.1);
            Console.WriteLine("Show statistics:");
            book.ShowStatistics();
            Program.CheckReturnToContent();
        }

        
    }
    public class Book
    {
        public string name;
        public List<double> grades; //field
        static public List<double> grades_stat; //static field not asosiated with objects, but with class itself
        //static method can be called directly from class (object should not be created)
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }
        static public void AddGradeStat(double grade) //static not for object or class member instances, but for entire class
        {
            grades_stat.Add(grade);
        }
        public Book()
        {
            grades = new List<double>();
        }
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
            
        }
        public void ShowStatistics()
        {
            var result = 0.0;
            var highgrade = double.MinValue;
            var lowestgrade = double.MaxValue;
            foreach (var number in grades)
            {
                if (number > highgrade)
                {
                    highgrade = number;
                }
                highgrade = Math.Max(highgrade, number);
                lowestgrade = Math.Min(lowestgrade, number);
                result += number;
            }
            result /= grades.Count;
            Console.WriteLine($"The highest grade is {highgrade}");
            Console.WriteLine($"The lowest grade is {lowestgrade}");
            Console.WriteLine($"The average grade = {result:N1}");
        }
    }
}

