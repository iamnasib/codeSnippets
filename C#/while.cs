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
        int p=280;
        int c=120;
        int b=180;
        int m=70;
        int offer=500;
        
        Console.WriteLine("MENU");
        Console.WriteLine("Press 1 for pizza           Rs-280(M)");
        Console.WriteLine("Press 2 for chicken roll    Rs-120");
        Console.WriteLine("Press 3 for burger          Rs-180");
        Console.WriteLine("Press 4 for momo            Rs-70 per plate");
        Console.WriteLine("Press 5 for all the items mentioned above     Rs-500(special offer)");
        Console.WriteLine("Press 0 to exit");
        int press=Convert.ToInt32(Console.ReadLine());
        switch(press)
        {
            case 1:
            Console.WriteLine("Enter the quantity you want to buy");
            int q1=Convert.ToInt32(Console.ReadLine());
            int bill = q1*p;
            total+=bill;
            Console.WriteLine("your bill is "+ total);
            
            break;
            case 2:
            Console.WriteLine("Enter the quantity you want to buy");
            int q2=Convert.ToInt32(Console.ReadLine());
            int bil=q2*c;
            total+=bil;
            Console.WriteLine("your bill is "+ total);
           
            break;
            case 3:
            Console.WriteLine("Enter the quantity you want to buy");
            int q3=Convert.ToInt32(Console.ReadLine());
            int bi=q3*b;
            total+=bi;
            Console.WriteLine("your bill is "+ total);
           
            break;
            case 4:
            Console.WriteLine("Enter the quantity you want to buy");
            int q4=Convert.ToInt32(Console.ReadLine());
            int b4=q4*m;
            total+=b4;
            Console.WriteLine("your bill is "+ total);

            break;
            case 5:
            Console.WriteLine("Enter the quantity you want to buy");
            int q5=Convert.ToInt32(Console.ReadLine());
            int b5=q5*offer;
            total+=b5;
            Console.WriteLine("your bill is "+ total);
           
            break;
            case 0:
            break;
            default:
            Console.WriteLine("Invalid item");
            
            
            break;
        }
        Console.WriteLine("Do you want to order anything else, please type yes or no");
        string option=Console.ReadLine();
        if (option=="no")
        {
            
           Console.WriteLine("Number of times you saw Menu   "+count);
            break;
        }
        
        }
        Console.WriteLine("your bill is "+ total);
        Console.WriteLine("Thank you for using our service");


    }
}