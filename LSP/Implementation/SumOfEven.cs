namespace LSP.Implementation;

public class SumOfEven : Calculator
{
    public SumOfEven(int[] numbers)
    :base(numbers)
    {}

    public override int Calculate()
        => _numbers.Where(x => x % 2 == 0).Sum();
}