using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System
{
    class Bank
    {
        private string bankName;
        private Account[] myBank;

        public Bank(string bankName)//constructor
        {
            this.bankName = bankName;
            myBank = new Account[400];
        }
        public void addAccount(Account account)
        {
            if (myBank[0] == null)
            {
                myBank[0] = account;
            }
            else
            {
                for (int i = 0; myBank[i] != null; i++)
                {
                    if (myBank[i + 1] == null)
                    {
                        myBank[i + 1] = account;
                        break;
                    }
                }
            }

        }
        public void deleteAccount(int accountNumber)
        {
            for (int i = 0; myBank[i] != null; i++)
            {
                if (myBank[i].getAccountNumber() == accountNumber)
                {
                    for (int j = i; myBank[j] != null; j++)
                    {
                        myBank[j] = myBank[j + 1];
                    }
                }
            }
        }
        public void Transaction(int transactionType, double amount, Account accOwner, Account reciver = null)
        {
            if (transactionType == 1)
            {
                accOwner.Deposit(amount);
            }
            else if (transactionType == 2)
            {
                accOwner.Withdraw(amount);
            }
            else if (transactionType == 3)
            {
                if (reciver == null)
                {
                    Console.WriteLine("Reciver not specified");
                }
                else
                {
                    accOwner.Transfer(reciver, amount);
                }
            }
        }
        public void PrintAccountDetails()
        {
            for (int i = 0; myBank[i] != null; i++)
            {
                myBank[i].ShowAccountInformation();
            }
        }
        static void Main(string[] args)
        {
            Bank b1 = new Bank("USSA");
            Account a1 = new Account("Tajimul", 500.0, "5", "145", "Dhaka", "Bangladesh");
            Account a2 = new Account("Tajimul", 500.0, "5", "145", "Dhaka", "Bangladesh");
            Account a3 = new Account("Tajimul", 500.0, "5", "145", "Dhaka", "Bangladesh");
            b1.addAccount(a1);
            b1.addAccount(a2);
            b1.addAccount(a3);
            b1.PrintAccountDetails();
            Console.WriteLine("Write Account number to delete");
            int x = Convert.ToInt32(Console.ReadLine());
            b1.deleteAccount(x);
            b1.PrintAccountDetails();
            b1.Transaction(1, 200.0, a1);
            b1.Transaction(2, 200.0, a3);
            b1.Transaction(3, 200, a1, a2);
            b1.Transaction(3, 200, a1);
            b1.PrintAccountDetails();

        }
    }
}


