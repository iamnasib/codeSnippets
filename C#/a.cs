using System;
class a
{
    public static void Main()
    {
      int[] num=new int[5];
      for (int i=0;i<=4;i++)
      {
          Console.WriteLine("Enter the number");
          num[i]=Convert.ToInt32(Console.ReadLine());
      }
      foreach(int x in num)
      {
          Console.WriteLine(x);
      }
    }
}