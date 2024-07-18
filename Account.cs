using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POConReflection.Models
{
    internal class Account
    {
        public int Id { get; set; }
        public string AccountType { get; set; }
        public double AccountNumber {  get; set; }
        public string OwnerName { get; set; }

        public Account() { }
        public Account(int id,double accountNumber,string ownerName ,string accountType)
        {
            Id = id; 
            AccountType = accountType; 
            AccountNumber = accountNumber;
            OwnerName = ownerName;
        }
        static void ShowDetailsOfAccount(int id)
        {
            Console.WriteLine("it will show details of account");
        }
    }
}
