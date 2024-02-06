using System;
class dw
{
    public static void Main()
    {
      string[] names=new string[3];
      names[0]="saquib";
      names[1]="amir";
      names[2]="nasib";
      foreach (string x in names)
      {

          Console.WriteLine(x);
      }
      Console.WriteLine("ist place is {0} 2nd place {1} 3rd place {2}",names[0],names[1],names[2]);
    }
}