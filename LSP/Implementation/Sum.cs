namespace LSP.Implementation;

public class Sum : Calculator
{
    public Sum(int[] numbers)
    :base(numbers)
    {}

    public override int Calculate() 
        => _numbers.Sum();
}