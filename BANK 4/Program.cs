using System;

namespace BANK_4
{
    class Program
    {
        static void Main(string[] args)
        {

            Account account1 = new Account(10000);
            Account account2 = new Account(20000, TypeOfBankAccount.DEBIT);
            Account account3 = new Account(30000, TypeOfBankAccount.DEPOSIT);

            account1.FullInfo();
            account2.FullInfo();
            account3.FullInfo();
        }
    }
}
