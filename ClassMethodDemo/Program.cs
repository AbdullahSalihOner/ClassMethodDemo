using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Asrın";
            customer1.Surname = "Asır";
            customer1.AccountType = "investment";
            customer1.MomSurname = "A";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Akman";
            customer2.Surname = "Arıkan";
            customer2.AccountType = "investment";
            customer2.MomSurname = "B";

            Customer[] customers = new Customer[] {customer1,customer2 };

            foreach (Customer customer in customers)
            {
                
            }

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add("Salih","Hacı",3,"student","C");
            Console.WriteLine("*******************");
            customerManager.Delete(customer2);
            Console.WriteLine("*******************");
            customerManager.List(customer1);
        }
    }
}
