using ConsoleApp10.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Repository
{
    public class CustomerRepository : IRepository<Customer>
    {
        List<Customer> _list = new List<Customer>();
        public void Add(Customer item)
        {
            _list.Add(item);
        }

        public IEnumerable<Customer> GetAll()
        {
            return _list;
        }

        public Customer GetById(int id)
        {
            for (int i = 0; i < _list.Count; i++)
            {
                if (_list[i].Id == id)
                {
                    return _list[i];
                }
            }
            return null;
        }

        public void Remove(Customer item)
        {
            Customer c = GetById(item.Id);
            if (c != null)
            {
                if (c.Id == item.Id) { _list.Remove(c); }
            }
        }

        public void Save()
        {
            for (int i = 0; i < _list.Count; i++)
            {
                Customer c = _list[i];
            }
        }
    }
}
