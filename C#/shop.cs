using System;
class menu
{
    public static void Main()
    {
        int total=0;
       string choice="yes";
        
        int count=0;
        while(choice=="yes")
        {
        count++;
        int trou=550;
        int tshirt=400;
        int pant=999;
        int jacket=1700;
        int packof3ts=750;
        int sweater=600;
        int sweatshirt=650;
        
        Console.WriteLine("Shopping list");
        Console.WriteLine("Press 1 for Trouser                 Rs-550");
        Console.WriteLine("Press 2 for T-shirt                 Rs-400");
        Console.WriteLine("Press 3 for Pant                    Rs-999");
        Console.WriteLine("Press 4 for Jacket                  Rs-1700");
        Console.WriteLine("Press 5 for Pack of 3 T-shirts      Rs-750");
        Console.WriteLine("Press 6 for Sweater                 Rs-600");
        Console.WriteLine("Press 7 for Sweatshirt              Rs-650");
        Console.WriteLine("Press 0 to exit");

        int press=Convert.ToInt32(Console.ReadLine());
        switch(press)
        {
            case 1:
            Console.WriteLine("Enter the quantity you want to buy");
            int q1=Convert.ToInt32(Console.ReadLine());
            int bill = q1*trou;
            total+=bill;
            Console.WriteLine("your bill is "+ total);
            
            break;
            case 2:
            Console.WriteLine("Enter the quantity you want to buy");
            int q2=Convert.ToInt32(Console.ReadLine());
            int bil=q2*tshirt;
            total+=bil;
            Console.WriteLine("your bill is "+ total);
           
            break;
            case 3:
            Console.WriteLine("Enter the quantity you want to buy");
            int q3=Convert.ToInt32(Console.ReadLine());
            int bi=q3*pant;
            total+=bi;
            Console.WriteLine("your bill is "+ total);
           
            break;
            case 4:
            Console.WriteLine("Enter the quantity you want to buy");
            int q4=Convert.ToInt32(Console.ReadLine());
            int b4=q4*jacket;
            total+=b4;
            Console.WriteLine("your bill is "+ total);

            break;
            case 5:
            Console.WriteLine("Enter the quantity you want to buy");
            int q5=Convert.ToInt32(Console.ReadLine());
            int b5=q5*packof3ts;
            total+=b5;
            Console.WriteLine("your bill is "+ total);

            break;
            case 6:
            Console.WriteLine("Enter the quantity you want to buy");
            int q6=Convert.ToInt32(Console.ReadLine());
            int b6 = q6*sweater;
            total+=b6;
            Console.WriteLine("your bill is "+ total);
            break;

            case 7:
            Console.WriteLine("Enter the quantity you want to buy");
            int q7=Convert.ToInt32(Console.ReadLine());
            int b7 = q7*sweatshirt;
            total+=b7;
            Console.WriteLine("your bill is "+ total);
           
            break;
            case 0:
            break;
            default:
            Console.WriteLine("Invalid item");
            
            break;
        }
        Console.WriteLine("Do you want to order anything else,please type yes or no");
        string option=Console.ReadLine();
         if (option=="no")
        {
            
            Console.WriteLine("Number of times you saw shopping list   "+count);
            break;
        }
       
       
        }
        
        Console.WriteLine("your bill is "+ total);
        Console.WriteLine("Thank you for using our service ");


    }
}