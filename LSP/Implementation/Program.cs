using LSP.Implementation;
using System;

var numbers = new int[] { 5, 7, 9, 8, 1, 6, 4 };

Calculator sum = new Sum(numbers);
Console.WriteLine($"\nSum: {sum.Calculate()}");

Calculator evenSum = new SumOfEven(numbers);
Console.WriteLine($"Even Sum : {evenSum.Calculate()}");
