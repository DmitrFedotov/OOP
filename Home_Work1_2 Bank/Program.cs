using System;

namespace Home_Work1_2_Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Account account1 = new Account();
            Account account2 = new Account();
            Account account3 = new Account();

            account1.FillTypeAccount(TypeOfBankAccount.DEBIT);
            account2.FillTypeAccount(TypeOfBankAccount.DEBIT);
            account3.FillTypeAccount(TypeOfBankAccount.DEBIT);

            account2.FillTypeAccount(TypeOfBankAccount.DEBIT);
            account2.FillNumber(random.Next(1, 99999999));
            account2.FillBalance(4356400);

            account3.FillTypeAccount(TypeOfBankAccount.DEBIT);
            account3.FillNumber(random.Next(1, 99999999));
            account3.FillBalance(175345345);

            account1.FillTypeAccount(TypeOfBankAccount.DEBIT);
            account1.FillNumber(random.Next(1, 99999999));
            account1.FillBalance(2656565);


            account1.FullInfo();
            account2.FullInfo();
            account3.FullInfo();
        }
    }
}
