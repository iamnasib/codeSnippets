using System;
class ord
{
    public static void Main()
    {
       
        Console.WriteLine("press 1 for pizza Rs300");
        Console.WriteLine("press 2 for burger Rs200");
        string y=Console.ReadLine();
     
        
        int bill1;
        int bill2;
        int total;
        int discount;
        
        ord obj=new ord();
        obj.bill(y,out bill1, out bill2,out total,out discount);
        Console.WriteLine("Your bill before discount " +total);
        Console.WriteLine("Your bill after discount " +discount);
       
    }
    public void bill(string y,out int bill1,out int bill2,out int total,out int discount)
    {
         int p=300;
        int b=200;
        bill1=0;
        bill2=0;
         switch(y)
       {
           case "1":
           Console.WriteLine("Enter the quantity you want to buy");
            int q1=Convert.ToInt32(Console.ReadLine());
            
             bill1=q1*p;
            break;
            case "2":
            Console.WriteLine("Enter the quantity you want to buy");
            int q2=Convert.ToInt32(Console.ReadLine());
    
            bill2=q2*b;
            break;
       }
       total=bill1+bill2;
       discount=total-10;
       
 
    }
}