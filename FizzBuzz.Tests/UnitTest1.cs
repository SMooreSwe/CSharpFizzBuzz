using Xunit;

namespace FizzBuzz;

public class UnitTest1
{
    private bool MethodExists(string methodName) 
    {
        var type = typeof(Class1);
        var methodInfo = type.GetMethod(methodName);
        return methodInfo != null;
    }

    [Fact]
    public void program_has_method()
    {        
        Assert.True(MethodExists("FizzBuzz"));
    }
    [Fact]
    public void program_prints()
    {
        Class1 test = new Class1();
        StringWriter output = new StringWriter();
        Console.SetOut(output);
        test.FizzBuzz(new int[] {1, 2, 3, 4, 5});
        string console = output.ToString();
        Assert.NotEqual(console.Length, 0);
    }
    [Fact]
    public void program_prints_Fizz_and_Buzz()
    {
        Class1 test = new Class1();
        StringWriter output = new StringWriter();
        Console.SetOut(output);
        test.FizzBuzz(new int[] {1, 2, 3, 4, 5});
        string console = output.ToString();
        Assert.Equal(string.Format("1{0}2{0}Fizz{0}4{0}Buzz{0}", Environment.NewLine), console);
    }
    [Fact]
    public void program_prints_FizzBuzz()
    {
        Class1 test = new Class1();
        StringWriter output = new StringWriter();
        Console.SetOut(output);
        test.FizzBuzz(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15});
        string console = output.ToString();
        Assert.Equal(string.Format("1{0}2{0}Fizz{0}4{0}Buzz{0}Fizz{0}7{0}8{0}Fizz{0}Buzz{0}11{0}Fizz{0}13{0}14{0}FizzBuzz{0}", Environment.NewLine), console);
    }
}