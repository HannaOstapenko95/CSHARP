using System;
using System.Collections.Generic; //for Lists
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENUMS_NAM;

namespace ANIMALS_NAM
{
    //Inheritance
    public class Animal //we can create objects for class, object will inherit all properties of class
    { //Модификаторы доступа: public, protected, private. By default = private
        public string name = "Spotty";  //variables=fields
        private string surname = "Bob"; //only for this class
        public int age = 7; //we can get access from every class
        public const int T = 100; //cannot change constant in main method. Must be initialized on the top, not in constructor
        public readonly int R = 900; //we can  change value only in constructor, not in methods
        public const string CONSTANT_STR = "Const variable of class Animal"; //we cannot change const variable even in constructor
        protected float happiness = 9.99f; //only for subsidiary classes of this class (inheritance)
        public static int count = 0; //Static Field/Property/Method/Constructor - is the same for all objects of class. Static - general state for all objects
        //then we can invoke static method/property by Class.Method, but not object1.Method, object2.Method
        //Static - for ALL objects. We cannot create objects from static class.
        //Class is static if all his elements are static
        //Math. - static class
        //public string breed;
        public Breed breed; //from ENUM
        public delegate string WriteLogDelegate(string logMessage); //delegate creates a variable that points to different methods with the same structure
        public void WriteLogDelegateCanPointToMethod()
        {
            /*WriteLogDelegate log;
            log = ReturnMessage;*/
            WriteLogDelegate log = ReturnMessage;
            log += ReturnMessage;
            var result = log("Hello");
        }
        string ReturnMessage (string message) //method
        {
            return message;
        }
            
        public Animal() //Constructor has properties for all objects of this class. Like default
        {          
            name = "Bob";
            surname = "SurBob";
            age = 8;
            happiness = 10;
            R = 600;
            count++;
            Print();
        }
        //Constructors have to have the same name
        public Animal(string _name, string _surname, int _age, float _happiness) //Constructor has parameters for all objects of this class
        {
            name = _name;
            //this.name = name; this - Variable  of Class
            surname = _surname;
            age = _age;
            happiness = _happiness;
            count++;
            Print();
        }
        // public Animal(string breed)
        public Animal(Breed breed) //ENUM
        {
            this.breed = breed;
        }
        public void Print()
        {//create method for the class
            Console.WriteLine("Name = " + name);
            Console.WriteLine("Surname = " + surname);
            Console.WriteLine("Age = " + age);
            Console.WriteLine("Happiness = " + happiness);
            Console.WriteLine("Breed - " + breed);
        }
        public string Surname //PROPERTY - name as variable of class, but capitalised
        {
            get { return surname; }
            set {
                if (!String.IsNullOrEmpty(surname))
                {
                    surname = value;
                }
            }
        }
    }

    //public class Animal1 : System.Object - by default class has a base class
    public class Animal1
        {
            public string Name { get; set; } //auto-property
            public string Name0 { get; private set; } //readonly
            private string Name1 { get; set; } //Has no acces from other classes BY DEFAULT
            protected string Name2 { get; set; } //Has access only from this class or наследников
        //Constructor
        public Animal1(string name)
        {
            Name = name;
        }
        //Virtual Method
        public virtual void Print()
        {
            Console.WriteLine(Name);
        }
        }




    public class Dog : Animal1
        {
            public Dog(string name) : base(name) //access a constructor froma base class
            {
                Name = name;
            }
        public float speed;
        //Constructor
        public Dog (float speed, string name) : base (name) //we use basic constructor -place name in basic constructor
        {
            this.speed = speed;
            //Console.WriteLine("Speed" + speed);
        }
        // Method of наследник has access to protected variable
         void test()
            {
                Console.WriteLine(Name2.GetType());
            }
        //Virtual Method переопределение - method which can be reinitiated in inherited class from main class
        public override void Print()
        {
            base.Print(); //copy all lines from this method from base class
            Console.WriteLine("Dog Speed" + speed); //Name will not be shown if no base.Print();
        }
    }

    public class Cat : Animal1
    {
        public float speed;
        //Constructor
        public Cat(float speed, string name) : base(name)
        {
            this.speed = speed;
            //Console.WriteLine("Speed" + speed);
        }
        public override void Print()
        {
            base.Print(); //copy all lines from this method from base class
            Console.WriteLine("Cat Speed" + speed); //Name will not be shown if no base.Print();
        }
    }


    }


