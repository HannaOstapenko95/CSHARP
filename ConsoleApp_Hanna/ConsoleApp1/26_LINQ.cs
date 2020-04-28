using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAIN_NAM;

namespace LINQ_NAM
{
    public class LINQ //READ ONLY. It cannot modify data
    { //Treats collections as enumerables. Take, OrderBy, Where
        public void LINQ_M()
        {
                Console.WriteLine("\t\t\tLINQ - Language Integrated Query");
                var numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                /* Add new code here */
                var query = from number in numbers select number;
                Console.WriteLine($"Count numbers in INT ARRAY via LINQ:  {query.Count()}");

                var numbers1 = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                /* Add new code here */
                var query2 = from number in numbers where number > 6 select number;
                Console.WriteLine($"Count numbers > 6 = {query2.Count()}");

              IEnumerable<int> GetNumbers()
            {
                var numbers3 = new int[] { 9, 1, 5, 8, 6, 7, 3, 2, 0, 4 };

                var query3 = from number in numbers3
                            orderby number ascending
                            select number;

                return query3;
            }
            List<User> UserList = new List<User>();
            UserList.Add(new User("Mahesh",true));
            UserList.Add(new User("Bob", false));
            UserList.Add(new User("Mark", true));
            UserList.Add(new User("Paul", false));

            GetUsers(UserList);

            void GetUsers(List<User> users)
            {
                var userQuery = from user in users
                                group user by user.Active into userGroup
                                select userGroup;

                foreach (var userGroup in userQuery)
                {
                    Console.WriteLine("Active: {0}", userGroup.Key);
                    foreach (var user in userGroup)
                    {
                        Console.WriteLine(user.Name);
                    }

                }
            }

            Program.CheckReturnToContent();
        }
    }

    public class User
    {
        public bool Active;
        public string Name;
        public User(string Name, bool Active) { 
            this.Name = Name;
            this.Active = Active;
        }
    }
}
    

