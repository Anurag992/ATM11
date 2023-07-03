using System;
 

      class program
    {
        static double balance=0;
    
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the Account Name");
        string acc = Console.ReadLine();
        while (true)
        {
           
            Console.WriteLine("Welcome To ATM Dashboard:" + acc.ToUpper());
            Console.WriteLine("1.Check Balance\n2.Deposit Fund\n3.Withdraw Cash\n4.Exit");
            int choose = int.Parse(Console.ReadLine());

            switch (choose)
            {
                case 1:
                    checkBalance();
                    break;
                case 2:
                    DepositFund();
                    break;
                case 3:
                    WithdrawCash();
                    break;
                case 4:
                    Console.WriteLine("Exiting the ATM Dashboard");
                    return;

            }
            Console.WriteLine();
        }        
    }
           static void checkBalance()
            {
                Console.WriteLine("Your current balance is:"+balance);
            }
            static void DepositFund()
            {
                Console.WriteLine("Enter the Amount to be Deposite");
                double amount = double.Parse(Console.ReadLine());
                 balance += amount;
                 Console.WriteLine("Your Amount added scucssfully\nCurrent balance is:" + balance);
            }
            static void WithdrawCash()
            {
                Console.WriteLine("Enter the amount to Withdraw");
                double m = double.Parse(Console.ReadLine());
        
                if (m > balance) 
                {
                    Console.WriteLine("You have insufficient balance");
                }
                else
                {
            balance -= m; 
            Console.WriteLine("you have Sucuessfuly withdrwa $:" + balance);
                }
            }

    }   

