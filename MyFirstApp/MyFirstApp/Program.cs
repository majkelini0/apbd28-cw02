﻿// See https://aka.ms/new-console-template for more information

static double GetAverage(int[] numbers)
{
    double result = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        result += numbers[i];
    }

    return result / numbers.Length;
}

int[] numbers = { 1, 2, 3, 4};
double average = GetAverage(numbers);
Console.WriteLine(average);

Console.WriteLine("gowno gowno gowno");

Console.WriteLine("once again... gowno !");

Console.WriteLine("o jejkuuu");