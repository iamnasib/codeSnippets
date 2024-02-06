using System;
class pub
{
  public static void Main()
  {
    priv obj=new priv();
    obj.xyz();
  }
}
class priv
{
    private void abc()
    {
        Console.WriteLine("1");
    }
    public void xyz()
    {
        priv obj1=new priv();
       obj1.abc();
    }
}