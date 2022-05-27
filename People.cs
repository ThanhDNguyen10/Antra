using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    /** 1. Write a program that demonstrates use of four basic principles of
    object-oriented programming /Abstraction/-, /Encapsulation/-, /Inheritance/- and
    /Polymorphism/-.
    */
    /** 3. Use /Encapsulation/ to keep many details private in each class.*/
    //Encapsulation
    public class People
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string gender;
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public int Age { get; set; }

        public People(String name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}



