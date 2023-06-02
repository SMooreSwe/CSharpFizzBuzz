namespace FizzBuzz;

public class Class1
{
    public void FizzBuzz(int[] array)
    {
        foreach (int number in array)
        {
            Console.WriteLine(FiBuPrinter(number));
        }
    }
    private string FiBuPrinter(int number)
    {
        return (number % 3, number % 5) switch
        {
        (0, 0) => "FizzBuzz",
        (0, _) => "Fizz",
        (_, 0) => "Buzz",
        _ => number.ToString()
        };
    }
}
