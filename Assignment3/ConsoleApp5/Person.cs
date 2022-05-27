using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    /** 2. Use /Abstraction/ to define different classes for each person type such as Student
    and Instructor. These classes should have behavior for that type of person.*/
    /**4. Use /Inheritance/ by leveraging the implementation already created in the Person
    class to save code in Student and Instructor classes.*/
    /**5. Use /Polymorphism/ to create virtual methods that derived classes could override to
    create specific behavior such as salary calculations.*/
    public abstract class Person
    {
        public Person()
        {

        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public String Phone { get; set; }

        public virtual void VirtualMethodDemo() {
            Console.WriteLine("Virtual method");
        }

        public abstract void PerformWork();
    }
    public class Instructor : Person 
    {
        public decimal WorkHour { get; set; }

        public Instructor ()
        {

        }

        public override void VirtualMethodDemo()
        {
            Console.WriteLine("Full time");
        }
        public override void PerformWork()
        {
            Console.WriteLine("Instructor teaches.");
        }
    }
    //Sealed keyword: cannot derived from a sealed class
    public sealed class Student : Person
    {
        public decimal HStudyHoury { get; set; }

        public override void PerformWork()
        {
            Console.WriteLine("Student studies.");
        }
    }

    //Manager class inherited from FullTimeEmployee class
    public class Manager : Instructor
    {
        public decimal ExtraBonus { get; set; }
        public void AttendMeeting()
        {
            Console.WriteLine("Manager attends meetings");
        }
    }
}
