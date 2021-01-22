using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Add(string name, string surname, int ıd, string accountType, string momSurname)
        {
            Console.WriteLine("Added to box :" +name);
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Deleted from box :" + customer.Name);
        }
        public void List(Customer customer)
        {
            Console.WriteLine("listed:");
            Console.WriteLine (customer.Name);
        }
    }
}
