using System;
class dw
{
    public static void Main()
    {
      string[] names=new string[3];
      for(int i=0;i<=2;i++)
      {
      Console.WriteLine("Enter the  name at place " +i);
      names[i]=Console.ReadLine();
      }
      foreach (string x in names)
      {
        Console.WriteLine(x);
      }
      Console.WriteLine("ist place is {0} 2nd place {1} 3rd place {2}",names[0],names[1],names[2]);
    }
}