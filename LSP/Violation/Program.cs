using LSP.Violation;

var numbers = new int[] {1,2,3,4,5,6,7};

Sum sum = new Sum(numbers);
System.Console.WriteLine("Sum:" + sum.Calculate());

SumOfEven evenSum = new SumOfEven(numbers);
System.Console.WriteLine("Even Sum: " + evenSum.Calculate());

Sum sum2 = new SumOfEven(numbers);
System.Console.WriteLine("Must be even sum:" + sum2.Calculate());