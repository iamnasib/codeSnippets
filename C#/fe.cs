using System;
class dw
{
    public static void Main()
    {
      string[] names=new string[3];
      Console.WriteLine("Enter the first name");
      names[0]=Console.ReadLine();
      Console.WriteLine("Enter the 2nd name");
      names[1]=Console.ReadLine();
      Console.WriteLine("Enter the 3rd name");
      names[2]=Console.ReadLine();
      foreach (string x in names)
      {
        Console.WriteLine(x);
      }
      Console.WriteLine("ist place is {0} 2nd place {1} 3rd place {2}",names[0],names[1],names[2]);
    }
}