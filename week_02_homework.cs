using System;
class week_02_homework
{
    static void Main()
    {
       Console.Write("enter 1st number : ");
       int a = int.Parse(Console.ReadLine());
       Console.Write("enter 2nd number : ");
       int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Sum (+) : " + (a+b));
        Console.WriteLine("Dif (-) : " + (a-b));
        Console.WriteLine("Product (x) : " + (a*b));

       if(b == 0) {
        Console.WriteLine("Div (/) : ERROR! ");
        Console.WriteLine("Rem (%) : ERROR!");
       }
       else
       {
        Console.WriteLine("Div (/) : " + (a/b));
        Console.WriteLine("Rem (%) : " + (a%b));
       }

    }
}
