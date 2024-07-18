using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POConReflection.Models
{
    internal class Customer
    {
        static string CITY = "Thane";
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }=CITY;
        public double AccountNumber {  get; set; }

        public Customer() { }
        
        public void ShowCustomerDetails()
        {
            Console.WriteLine("It will print customer Details");
        }
        static void PrintAddress()
        {
            Console.WriteLine($"{CITY}");
        }
    }
}
