using AverageCalculator;
namespace Main;

public class Programm00{
    public static int Main(string[] args){
        Average_Calculator calc = new();
        calc.Add(5);
        Console.WriteLine(calc.Get_Elements());
        return 0;
    }
}