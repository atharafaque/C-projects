﻿using System;
using System.ComponentModel.DataAnnotations;

internal class Program
{
    private static void Main(string[] args)
    {
        int X;
        int y;
        int z;





        var age = -23;
        Console.WriteLine(age);
        Console.WriteLine(int.MaxValue);
        Console.WriteLine(int.MinValue);


        long bigNumber = -900000000L;
        Console.WriteLine(bigNumber);
        Console.WriteLine(long.MaxValue);
        Console.WriteLine(long.MinValue);

        double negative = -55.2D;
        Console.WriteLine(negative);
        Console.WriteLine(double.MaxValue);
        Console.WriteLine(double.MinValue);


        float precision = 5.000001F;
        Console.WriteLine(precision);
        Console.WriteLine(float.MaxValue);
        Console.WriteLine(float.MinValue);


        decimal money = 14.99M;
        Console.WriteLine(money);
        Console.WriteLine(decimal.MaxValue);
        Console.WriteLine(decimal.MinValue);

        Console.ReadLine();
    }
}