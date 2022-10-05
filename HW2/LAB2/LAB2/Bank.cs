using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    public class Bank
    {
        public Bank(string name, string swift, List<Account> accounts)
        {
            Name = name;
            Swift = swift;
            Accounts = accounts;
        }
        
        public string Name { get; private set; }
        public string Swift { get; private set; }
        public List<Account> Accounts { get; private set; }

        public void OpenAccount(Account newAccount)
        {
            Accounts.Add(newAccount);
        }

        public Account FindAccount(string iban)
        {
            return Accounts.SingleOrDefault(account => account.Iban == iban);
        }

        public void DepositMoneyAccount(string iban, double amountDeposit)
        {
            Account account = FindAccount(iban);
            account.DepositMoney(amountDeposit);
        }

        public void WithdrawMoneyAccount(string iban, double amountWithdraw)
        {
            Account account = FindAccount(iban);
            account.WithdrawMoney(amountWithdraw);
        }

        public void TransferMoney(string iban1, string iban2, double sum)
        {
            Account account1 = FindAccount(iban1);
            Account account2 = FindAccount(iban2);

            account1.WithdrawMoney(sum);
            account2.DepositMoney(sum);
        }
    }
}
