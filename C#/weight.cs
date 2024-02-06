using System;
class weight
{
    public static void Main()
    {   
        Console.WriteLine("Enter the unit in which you want to convert kgs or lbs");
        string w=Console.ReadLine();
        if (w == "lbs")
        {
            Console.WriteLine("Enter the weight in kgs");
            double kg=Convert.ToDouble(Console.ReadLine());
            double cw=kg/0.45;
            Console.WriteLine("Weight in lbs is "+cw);
        }
        else if (w=="kgs")
        {
             Console.WriteLine("Enter the weight in lbs");
            double kg=Convert.ToDouble(Console.ReadLine());
            double cw=kg*0.45;
            Console.WriteLine("Weight in kgs is "+cw);
        }
        else
        {
            Console.WriteLine("Invalid Unit");
        }
    }
}