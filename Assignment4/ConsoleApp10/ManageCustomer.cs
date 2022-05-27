// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
3. Implement a GenericRepository<T> class that implements IRepository<T> interface
that will have common /CRUD/ operations so that it can work with any data source
such as SQL Server, Oracle, In-Memory Data etc. Make sure you have a type constraint
on T were it should be of reference type and can be of type Entity which has one
property called Id. IRepository<T> should have following methods
1. void Add(T item)
2. void Remove(T item)
3. Void Save()
4. IEnumerable<T> GetAll()
5. T GetById(int id)*/

namespace ConsoleApp10.Repository
{
    public class ManageCustomer
    {
        CustomerRepository CustRepository = new CustomerRepository();
        private void AddCust()
        {
            Customer c = new Customer();
            Console.Write("ID: ");
            c.Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Name: ");
            c.Name = Console.ReadLine();
            Console.Write("Email: ");
            c.Email = Console.ReadLine();
        }
        private void PrintAll()
        {
            IEnumerable<Customer> allList = CustRepository.GetAll();
            foreach (var c in allList)
            {
                Console.WriteLine(c.Name);
            }
        }
        private void RemoveCust()
        {
            Console.WriteLine("ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
        }
        public void Run()
        {
            Console.Clear();
            Console.WriteLine("1 to add");
            Console.WriteLine("2 to print");
            Console.WriteLine("3 to remove");
            Console.WriteLine("0 to exit");

            Console.WriteLine("Enter choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            while (choice != 0)
            {
                switch (choice)
                {
                    case 1:
                        AddCust();
                        break;
                    case 2:
                        PrintAll();
                        break;
                    case 3:
                        RemoveCust();
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;
                }
                Console.WriteLine("Press a number to continue");
                choice = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}