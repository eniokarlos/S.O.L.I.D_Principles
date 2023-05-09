namespace LSP.Violation;

public class Sum
{
    protected readonly int [] _numbers;

    public Sum(int[] numbers)
    {
        _numbers = numbers;
    }
    
    public int Calculate() => _numbers.Sum();
}