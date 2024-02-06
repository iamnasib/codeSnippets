using System;
class loan
{
    public static void Main()
    {
        int pay;
      int a= Convert.ToInt32(Console.ReadLine());
       for(int i=1;i<=6;i++)
       {
           pay=a/10;
        a=a-pay;
         Console.WriteLine(a);
       }
    }
}