using System;
class house
{
    public static void Main()
    {
        int balance=50000000;
        int h1=9000000;
        int h2=15000000;
        int h3=35000000;
        int h4=10000000;
        Console.WriteLine("House list");
        Console.WriteLine("Press 1 for house 1           Rs-9000000");
        Console.WriteLine("Press 2 for house 2    Rs-15000000");
        Console.WriteLine("Press 3 for house 3          Rs-35000000");
        Console.WriteLine("Press 4 for house 4            Rs-10000000");
        Console.WriteLine("Press 5 for exit");
        int press=Convert.ToInt32(Console.ReadLine());
        switch(press)
        {
            case 1:
            
            Console.WriteLine("your cost of house "+h1);
             Console.WriteLine("do you want to buy the house");
        string buy=Console.ReadLine();
        if (buy=="yes")
        {
            Console.WriteLine("Congratulations you have purchased the house");
            Console.WriteLine("amount transferred");
            int remb=balance-h1;
            Console.WriteLine("remaining bank balance "+remb);
        }
        else
        {
            break;
        }
            break;
            case 2:
            Console.WriteLine("your cost of house "+h2);
                Console.WriteLine("do you want to buy the house");
        string buy1=Console.ReadLine();
        if (buy1=="yes")
        {
            Console.WriteLine("Congratulations you have purchased the house");
            Console.WriteLine("amount transferred");
            int rem=balance-h2;
            Console.WriteLine("remaining bank balance "+rem);
        }
        else
        {
            break;
        }
            break;
            case 3:
            Console.WriteLine("your cost of house "+h3);
                Console.WriteLine("do you want to buy the house");
        string buy2=Console.ReadLine();
        if (buy2=="yes")
        {
            Console.WriteLine("Congratulations you have purchased the house");
            Console.WriteLine("amount transferred");
            int re=balance-h3;
            Console.WriteLine("remaining bank balance "+re);
        }
        else
        {
            break;
        }
            break;
            case 4:
            Console.WriteLine("your cost of house "+h4);
                Console.WriteLine("do you want to buy the house");
        string buy3=Console.ReadLine();
        if (buy3=="yes")
        {
            Console.WriteLine("Congratulations you have purchased the house");
            Console.WriteLine("amount transferred");
            int r=balance-h4;
            Console.WriteLine("remaining bank balance "+r);
        }
        else
        {
            break;
        }
            break;
            case 5:
            
            break;
            default:
            Console.WriteLine("Invalid");
            break;
        }
       

    }
}