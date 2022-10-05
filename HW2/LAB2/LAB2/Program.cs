using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    class Program
    {
        static void Main(string[] args)
        {
            var account1 = new Account(accountHolder: "Serban", accountType: AccountType.Person, iban: "1234", amount: 0);
            var account2 = new Account(accountHolder: "Bogdan", accountType: AccountType.Person, iban: "2345", amount: 0);

            var bank = new Bank(name: "BRD", swift: "123456", accounts: new List<Account>());

            bank.OpenAccount(account1);
            bank.OpenAccount(account2);

            bank.DepositMoneyAccount("1234", 20);
            bank.DepositMoneyAccount("2345", 5);

            Console.WriteLine(account1);
            Console.WriteLine(account2);

            bank.TransferMoney("1234", "2345", 10);

            Console.WriteLine(account1);
            Console.WriteLine(account2);
        }
    }
}
