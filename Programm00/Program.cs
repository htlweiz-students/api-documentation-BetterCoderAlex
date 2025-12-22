using AverageCalculator;
namespace Main;

public class Programm00{
    public static int Main(string[] args){
        Average_Calculator calc = new();
        calc.Add(5);
        double[] arr = {1, 2, 3};
        calc.Add(arr);
        Console.WriteLine(calc);
        return 0;
    }
}