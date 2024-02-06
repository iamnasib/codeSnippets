using System;
class bank
{
    public static void Main()
    {
        Console.WriteLine("Enter your pin");
        string p1=Console.ReadLine();
        if (p1 == "1234")
        {
            double balance=1000000;
            Console.WriteLine("Welcome");
            Console.WriteLine("Enter your Withdrawl amount ");
            double wa=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter withdrawl pin");
            string p2=Console.ReadLine();
            if (p2 == "0000")
            {
                if ( wa < balance )
                {
                
                double rb=balance-wa;
                Console.WriteLine("your transaction is successful");
                Console.WriteLine("Your remaining balance is "+ rb);
                }
                else
                {
                    Console.WriteLine("Insufficient Balance "+balance);
                }
            }
            else
            {
                Console.WriteLine("Incorrect withdrawl pin");
            }
        }
        else
        {
            Console.WriteLine("Incorrect Entry Pin");
        }
    }
}