using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAIN_NAM;
using PERSON_NAM;

namespace STRUCTURES_NAM
{
    public class STRUCTURES
    {
        public void STRUCTURES_M()
        {
            //STRUCTURES - take less memory, but cannot contain virtual methods, inheritance, ...
            Console.WriteLine("\t\t\tSTRUCTURES");
            Book b;
            b.author = "King";
            b.title = "Title name";
            b.name = "Name of structure";
            b.Print();
            Console.WriteLine();
            Book[] books = new Book[2]; //Massive of structures
            books[0] = new Book("First author", "Title 1", "Name 1"); //using constructor for structure
            books[1].author = "Second author";
            books[1].title = "Title 2";
            books[1].name = "Name 2";
            foreach (Book book in books)
            {
                book.Print();
            }
            Console.WriteLine();
            Book tom = new Book("Tom", "Tom1", "Tom2");//using constructor for structure
            tom.Print();
            User user1 = new User { name = "HANNA", age = 24 };//initialization of objects
                                                               //objects of STRUCTURE as parameter of method
            ChangeUser(user1); //doesn't change the initial values of user1
            Console.WriteLine($"{user1.name}, {user1.age}");
            ChangeUser_ref(ref user1);////change the initial values of user1
            Console.WriteLine($"{user1.name}, {user1.age}");

            User1 user2 = new User1 { name = "HANNA", age = 24 };
            //objects of CLASS as parameter of method
            ChangeUser(user2); //change the initial values of user2, but not via constructor in method
            Console.WriteLine($"{user2.name}, {user2.age}");
            ChangeUser1(ref user2);////change the initial values of user2 via constructor in method
            Console.WriteLine($"{user2.name}, {user2.age}");
            Program.CheckReturnToContent();
        }
        static void ChangeUser(User user)
        {
            user.name = "HELEN";
            user.age = 30;
        }
        static void ChangeUser_ref(ref User user)
        {
            user.name = "HELEN";
            user.age = 30;
        }
        static void ChangeUser(User1 user)
        {
            user.name = "HELEN";
            user.age = 30;
            //user = new User1 { name = "Ludmyla", age = 52 }; will not change initial values
        }
        static void ChangeUser1(ref User1 user)
        {
            user.name = "HELEN";
            user.age = 30;
            user = new User1 { name = "Ludmyla", age = 52 };//will change initial values
        }

        struct Book //STRUCTURE - outside from class
        {
            public string title;
            public string name;
            public string author;
            //public string name = "Sam";     // ! Ошибка
            //Constructor is Method with the name of Structure
            public Book(string title, string name, string author)
            {
                this.title = title; this.name = name; this.author = author;
            }
            public void Print()
            {
                Console.WriteLine("Structure Title - " + title);
                Console.WriteLine("Structure Name - " + name);
                Console.WriteLine("Structure Author - " + author);
            }
        }
        struct User
        {
            public int age;
            public string name;
        }
    }
}
