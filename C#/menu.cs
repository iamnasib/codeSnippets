using System;
class menu
{
    public static void Main()
    {
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
        int press=Convert.ToInt32(Console.ReadLine());
        switch(press)
        {
            case 1:
            Console.WriteLine("Enter the quantity you want to buy");
            int q1=Convert.ToInt32(Console.ReadLine());
            int bill=q1*p;
            Console.WriteLine("Your Bill is "+bill);
            Console.WriteLine("Order will be ready in few minutes");
            Console.WriteLine("Thank you for using our service");
            break;
            case 2:
            Console.WriteLine("Enter the quantity you want to buy");
            int q2=Convert.ToInt32(Console.ReadLine());
            int bil=q2*c;
            Console.WriteLine("Your Bill is "+bil);
            Console.WriteLine("Order will be ready in few minutes");
            Console.WriteLine("Thank you for using our service");
            break;
            case 3:
            Console.WriteLine("Enter the quantity you want to buy");
            int q3=Convert.ToInt32(Console.ReadLine());
            int bi=q3*b;
            Console.WriteLine("Your Bill is "+bi);
            Console.WriteLine("Order will be ready in few minutes");
            Console.WriteLine("Thank you for using our service");
            break;
            case 4:
            Console.WriteLine("Enter the quantity you want to buy");
            int q4=Convert.ToInt32(Console.ReadLine());
            int b4=q4*m;
            Console.WriteLine("Your Bill is "+b4);
            Console.WriteLine("Order will be ready in few minutes");
            Console.WriteLine("Thank you for using our service");
            break;
            case 5:
            Console.WriteLine("Enter the quantity you want to buy");
            int q5=Convert.ToInt32(Console.ReadLine());
            int b5=q5*offer;
            Console.WriteLine("Your Bill is "+b5);
            Console.WriteLine("Order will be ready in few minutes");
            Console.WriteLine("Thank you for using our service");
            break;;/
            default:
            Console.WriteLine("Invalid item");
            Console.WriteLine("Thank you for using our service");
            break;
        }


    }
}