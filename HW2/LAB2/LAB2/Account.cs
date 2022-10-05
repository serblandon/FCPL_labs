using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    public class Account
    {
        public Account(string accountHolder, AccountType accountType, string iban, double amount)
        {
            AccountHolder = accountHolder;
            AccountType = accountType;
            Iban = iban;
            Amount = amount;
        }

        public string AccountHolder { get; private set; }
        public AccountType AccountType { get; private set; }
        public string Iban { get; private set; }
        public double Amount { get; private set; }

        public void DepositMoney(double amountDeposit)
        {
            Amount += amountDeposit;
        }

        public void WithdrawMoney(double amountWithdraw)
        {
            Amount -= amountWithdraw;
        }

        public override string ToString()
        {
            return $"AccountHolder: {AccountHolder}, AccountType: {AccountType}, IBAN: {Iban}, Amount: {Amount}";
        }
    }

    public enum AccountType { Person, Company}
}
