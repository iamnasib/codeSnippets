using System;
class b3
{
    public static void Main()
    { 
          string m1="1234";
    string m2="0000";
    
        double balance=250000;
        
        Console.WriteLine("Press 1 for withdrawl");
        Console.WriteLine("Press 2 to check current balance");
        string o1=Console.ReadLine();
       switch (o1)
       
        
        {
            case "1":
             Console.WriteLine("Enter your Login Pin");
              string p1=Console.ReadLine();
             if (p1 == m1)
            {
          
            Console.WriteLine("Welcome");
            Console.WriteLine("Enter your Withdrawl amount ");
            double wa=Convert.ToDouble(Console.ReadLine());
            double rb=balance-wa;
            Console.WriteLine("Enter withdrawl pin");
            string p2=Console.ReadLine();
            if (p2 == m2)
            {
                if ( wa < balance || wa == balance )
                {
                
                
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
       
        break;
        
        
        
        case "2":

        
            Console.WriteLine("Your current balance is " +balance);
            break;
        
        
        default:
        
            Console.WriteLine("Invalid entry");
            break;
            
        
       
       
        }
         Console.WriteLine("Thank you for using our service");
            
       
        
        
    }
}