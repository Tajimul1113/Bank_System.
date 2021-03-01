using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System
{
    class Account
    {
        Random rand = new Random();
        private int accountNumber;
        private string accountName;
        private double balance;
        private Address address;

        public Account(string accountName, double balance, string roadNo, string houseNo, string city, string country)
        {
            this.accountNumber = rand.Next(100, 999);
            this.accountName = accountName;
            this.balance = balance;
            address = new Address(roadNo, houseNo, city, country);
        }
        public int getAccountNumber() { return accountNumber; }
        public void Withdraw(double amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("You Dont Have Enough Balance to Withdraw");
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"{amount}TK Withdrawn\nCurrent Balance: {balance}");
            }
        }
        public void Deposit(double amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Invalied Ammount");
            }
            else
            {
                balance += amount;
                Console.WriteLine("Money Added: " + amount + "\nCurrent Balance: " + balance);
            }
        }
        public void Transfer(Account reciver, double amount)
        {
            reciver.Deposit(amount);
            Console.WriteLine($"Money {amount}TK sent succesfully\nCurrent Balance {balance}");
        }
        public void ShowAccountInformation()
        {
            Console.WriteLine($"\nACCOUNT INFORMATION\nName: {accountName}\nAccount Number: {accountNumber}\nBalance: {balance}\nAddress: {address.getAddress()}\n");
        }
    }
}
