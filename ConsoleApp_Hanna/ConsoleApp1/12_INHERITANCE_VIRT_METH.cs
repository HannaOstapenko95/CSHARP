using System;
using System.Collections.Generic;
using MAIN_NAM;
using ANIMALS_NAM;
using ANIMALS_PERS_NAM;
using System.IO;


namespace INHERITANCE_ASIS_NAM
{
    public class INHERITANCE_ASIS_VIRT
    {
        public void INHERITANCE_ASIS_M()
        {
            Console.WriteLine("\t\t\tINHERITANCE (From External Class file), AS/IS, Virtual Methods, Abstract Classes");
            Dog tom = new Dog(12.23f, "Bob");
            Console.WriteLine(tom.Name);
            tom.Name = "Tom";
            string text = "New text for a 'Tom' file";
            // using (
            //File.WriteAllText(@"U:\C#-TRAINING\app\HAOK-master\ConsoleApp2\ConsoleApp1\Tom.txt", text);
            //File.WriteAllText(@"D:\C\ConsoleApp_Hanna\ConsoleApp_Hanna\ConsoleApp1\Tom.txt", text);
            File.WriteAllText(@"U:\C#-TRAINING\1\ConsoleApp_Hanna\ConsoleApp_Hanna\ConsoleApp1\Tom.txt", text);
            //)
            /* {
                 writer.WriteLine("Hello writer!");
             }*/
            //using (var reader = File.OpenText(@"U:\C#-TRAINING\app\HAOK-master\ConsoleApp2\ConsoleApp1\Tom.txt"))
            //using (var reader = File.OpenText(@"D:\C\ConsoleApp_Hanna\ConsoleApp_Hanna\ConsoleApp1\Tom.txt"))
            using (var reader = File.OpenText(@"U:\C#-TRAINING\1\ConsoleApp_Hanna\ConsoleApp_Hanna\ConsoleApp1\Tom.txt"))
            {
                var line = reader.ReadLine();
                Console.WriteLine(line);
            }

            //var writer = File.AppendText(@"U:\C#-TRAINING\app\HAOK-master\ConsoleApp2\ConsoleApp1\Tom.txt");
            //var writer = File.AppendText(@"D:\C\ConsoleApp_Hanna\ConsoleApp_Hanna\ConsoleApp1\Tom.txt");
            var writer = File.AppendText(@"U:\C#-TRAINING\1\ConsoleApp_Hanna\ConsoleApp_Hanna\ConsoleApp1\Tom.txt");
            writer.WriteLine(tom.Name);
            writer.Close();
            writer.Dispose();

            Console.WriteLine(tom.Name);
            Dog jerry = new Dog(22.22f, "Jerry");
            Console.WriteLine(jerry.Name);
            Console.WriteLine();
            jerry.Print();
            //Create Massive of pointers (objects) which point on the main Class. 
            //Type is name of Class - System.Collections.Generic
            List<Animal1> animals = new List<Animal1>();
            animals.Add(new Dog(11.11f, "Alex")); //This object can invoke only methods from main class
            animals.Add(new Dog(33.11f, "Helena"));
            animals.Add(new Cat(43.11f, "Mew"));
            Console.WriteLine("\t\t\tAS/IS");
            foreach (Animal1 animal in animals)//when we don;t now the number of elements, but can count
            {
                if (animal is Animal1)
                {
                    Console.WriteLine(animal.Name);
                    //IS - exception, AS - returns null
                    Console.WriteLine(animal is Dog); //Does element belong to class?
                }
                if (animal is Cat)
                {
                    Console.WriteLine("Check if cat");
                    Console.WriteLine(animal.Name);
                    (animal as Cat).Print();
                }
            }
            Console.WriteLine("\t\t\tVirtual methods"); //method which can be reinitialised
                                                        //Needed to be realized in main method, in childs - not obligatory
            //Abstract method is a virtual method that has no implementation
            foreach (Animal1 animal in animals) //Переопределение методов (small changes from method in main class)virtual - overwrite in inherited method
            {
                animal.Print();
            }
            Console.WriteLine("\t\t\tAbstract classes");
            //Abstract class - isn't needed to execute in main class, because very different in inherited classes
            //Is obligatory to mention in all inherited classes
            //We cannot create objects from abstract class
            //Abstract class can contain abstract or general methods
            //Inherited class can only contain 1 Abstract class
            List<Animal2> animals2 = new List<Animal2>();
            //This object can invoke only methods from main class
            animals2.Add(new Cat2(43.11f, "Mew"));
            foreach (Animal2 animal2 in animals2)
            {
                animal2.Print3();
            }
            Client client = new Client("Tom", 500);
            Employee employee = new Employee("Bob", "Apple");
            client.Display();
            employee.Display();
            Program.CheckReturnToContent();
        }
    }
}
