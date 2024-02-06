using System;
class press
{
    public static void Main()
    {
        double balance=1000000;
        Console.WriteLine("Press 1 for withdrawl or 2 to check balance");
        string p=Console.ReadLine();
        if (p=="1")
        {
             Console.WriteLine("Enter your Login Pin");
              string p1=Console.ReadLine();
             if (p1 == "1234")
            {
           
            Console.WriteLine("Welcome");
            Console.WriteLine("Enter your Withdrawl amount ");
            double wa=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter withdrawl pin");
            string p2=Console.ReadLine();
            if (p2 == "0000")
            {
                if ( wa < balance || wa == balance )
                {
                
                double rb=balance-wa;
                Console.WriteLine("your transaction is successful");
                Console.WriteLine("Your remaining balance is "+ rb);
                }
                else
                {
                    Console.WriteLine("Insufficient Balance, current balance is "+balance);
                }
            }
            else
            {
                Console.WriteLine("Incorrect withdrawl pin");
            }
        }
         else
        {
            Console.WriteLine("Incorrect Login Pin");
        }
        }
        else if (p=="2")
        {
            Console.WriteLine("Your current balance is " + balance);

        }
        else
        {
            Console.WriteLine("Invalid Entry");
        }
        Console.WriteLine("Thankyou for using our service");

    }
}