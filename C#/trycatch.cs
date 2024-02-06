using System;
class tryca
{
    public static void Main()
    {
        double n1=8082404133;
        double n2=7006523781;
        double n3=9797922294;
        double b1=399;
        double b2=655;
        double b3=150;
        try
        {
            Console.WriteLine("enter your phn nmbr");
            double nmbr=Convert.ToDouble(Console.ReadLine());
            if(nmbr==n1)
            {
                Console.WriteLine("Your bill is "+b1);
            }
            else if(nmbr==n2)
            {
                Console.WriteLine("Your bill is "+b2);
            }
             else if(nmbr==n3)
            {
                Console.WriteLine("Your bill is "+b3);
            }
            else
            {
            
                Console.WriteLine("Invalid nmbr");
            }
            
           
        }
        catch(Exception name)
        {
            Console.WriteLine(name.Message);
        }
    }
}