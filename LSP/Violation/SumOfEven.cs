namespace LSP.Violation;

public class SumOfEven : Sum
{
    public SumOfEven(int[] numbers)
    :base(numbers)
    {}

    // LSP Violation
    public new int Calculate() =>
        _numbers.Where(x => x % 2 == 0).Sum();
}