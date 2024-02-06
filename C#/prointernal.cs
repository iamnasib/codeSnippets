using System;
class proint
{
    public static void Main()
    {
      proint obj= new proint();
      obj.name=Console.ReadLine();
      obj.print();
    }
    protected string name;
    public void print()
    {
        Console.WriteLine("name is "+ name);
    }
}
