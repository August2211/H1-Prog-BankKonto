using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankKonto
{
    public class BankAccount
    {
        private int Balance { get; set; }

        public int GetBalance()
        {
            return Balance;
        }

        public int withdraw(int amount)
        {
            if(amount > Balance) return 0;
            if (amount < 0) return 0;
            Balance -= amount;            
            return amount;         
        }

        public void deposit(int amount)
        {
            if (amount < 0) return;
            Balance += amount;
            return;
        }
    }
}
