using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENTS_NAM
{
    public class Students
    {
        public class Student
        {
            public string name; //fields
            public int course;
            public bool step;
            //we can set a value to automatic property
            public int Course1 { get; set; } = 0;//Automatic Properties (here lice public field) - to simplify
                                                 //public int Course1 { private get; set; } - from Main we can only set value, not read
                                                 //Property: we can overwrite it
            public int Course //Accessors GET/SET instead of public field or methods (conditions in 1 place)
            {
                get
                {
                    return course;
                }
                set
                {
                    if (value < 1)
                        course = 1;
                    if (value > 5)
                        course = 5;
                    else
                        course = value;
                }
            }
            public Student()
            {
                name = "Hanna";
                course = 5;
                step = true;
                Print();
            }
            public Student(string name, int course, bool step) : this(name)
            {
                //this.name = name;
                this.course = course;
                this.step = step;
                Print();
            }
            public Student(string name)
            {
                this.name = name;
            }
            public void Print()
            {//create method for the class
                Console.WriteLine("Name = " + name);
                Console.WriteLine("Course = " + course);
                Console.WriteLine("Scholarship = " + step);
            }
        }
    }
}
