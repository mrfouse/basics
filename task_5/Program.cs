﻿internal class lulz
{
    static void Main(string[] args)
    {
        Console.WriteLine("введите число: ");
        double num = Convert.ToDouble(Console.ReadLine());
        if (num == 0)
        {
            Console.WriteLine("решение: y = " + num);
        }
        else if (num < 1)
        {
            double num2 = Math.Pow(Math.Pow(num, 2) - 1, 2);
            Console.WriteLine(num2);
        }
        else
        {
            double num2 = Math.Pow(num + 1, 2);
            double num3 = 1 / num2;
            Console.WriteLine(num3);
        }

    }
}