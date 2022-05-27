using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public interface IPersonService
    {
        public abstract void Service();
    }


    public interface IStudentService : IPersonService 
    {
        public abstract void Service();
    }
    public interface IInstructorService : IPersonService 
    {
        public abstract void Service();
    }



    public abstract class Person : IPersonService
    {
        private int age;
        public int Age 
        {
            get {return age; }
            set {
                if (age < 0)
                {
                    throw new ArgumentException("Age cannot be negative.");
                }
                age = value; } 
        }

        private decimal salary;
        public decimal Salary { get{ return salary; }
            set {
                if (salary < 0M)
                {
                    throw new ArgumentException("Salary cannot be negative.");
                }
                salary = value; }
        }

        private string address;
        public string Address { get; set; }

        public abstract void Service();
    }
    public class Instructor : Person 
    {
        private string dep;
        public string Dep { get; set; }
        private string join;
        public string Join { get; set; }
        private string exp;
        public string Exp
        {
            get { return exp; }
            set { exp = value; }
        }
        private int bonus;
        public int Bonus { get; set; }

        public override void Service(){}
    }

    public class Student : Person
    {
        private int numCourse;
        public int NumCourse { get { return numCourse; } set { numCourse = value; } }
        private decimal gpa;
        public decimal Gpa { get { return gpa;  }
            set {
                if (gpa < 0M || gpa > 4M) throw new ArgumentException("Age cannot be negative.");
                gpa = value; 
            } }
        public override void Service() {}
    }

    public class Course 
    {
        private string enrolled;
        public string Enrolled { get; set; }
    }
    public class Department
    {
        private string depHead;
        public string DepHead { get; set; }
        private int budget;
        public int Budget { get; set; }
        private string course;
        public string Course { get; set; }
    }
}
