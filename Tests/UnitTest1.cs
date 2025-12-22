using System.Net.Http.Headers;
using System.Reflection;
using AverageCalculator;
using NuGet.Frameworks;
namespace Tests;

public class UnitTest1
{
    [Fact]
    public void Add_Single_Element()
    {
        Average_Calculator calculator = new Average_Calculator();
        calculator.Add(2);
        calculator.Add(1);
        double[] original = {2, 1};
        for(int i = 0; i <original.Length; i++){
            Assert.Equal(original[i], calculator.Get_Elements()[i], precision: 4);
        }
    }

    [Fact]
    public void Add_Multiple_Elements(){
        Average_Calculator calculator = new Average_Calculator();
        double[] expected = {2, 1};
        calculator.Add(expected);
            Assert.Equal(expected, calculator.Get_Elements());
    }

    [Fact]
    public void Add_Array_with_Zero_Elements(){
        var calculator = new Average_Calculator();
        double[] arr = {};
        double[] arr_expected = {};
        calculator.Add(arr);
        Assert.Equal(calculator.Get_Elements(), arr_expected);
    }

    [Fact]
    public void Get_Average(){
        var calc = new Average_Calculator();
        double[] arr = {2, 2, 2};
        calc.Add(arr);
        double avg = calc.GetAverage();
        Assert.Equal(2, avg);
    }

    [Fact]
    public void Get_Average_With_No_Elements(){
        var calc = new Average_Calculator();
        double[] arr = {};
        calc.Add(arr);
        double avg = calc.GetAverage();
        Assert.Equal(0, avg);
    }

    [Fact]
    public void Get_Average_Add_elements_after(){
        var calc = new Average_Calculator();
        calc.Add(5);
        calc.Add(6);
        double avg = calc.GetAverage();
        Assert.Equal(5.5, avg);
        calc.Add(5);
        avg = calc.GetAverage();
        Assert.Equal(5.33, Math.Round(avg, 2));
    }

    [Fact]
    public void Count_With_No_Elements(){
        var calc = new Average_Calculator();
        int count_elements = calc.count();
        Assert.Equal(0, count_elements);
    }

    [Fact]
    public void Count_Negative_Elements(){
        var calc = new Average_Calculator();
        double[] arr = {-2.5, -1, 3};
        calc.Add(arr);
        int count_elements = calc.count();
        Assert.Equal(3, count_elements);
    }

    [Fact]
    public void Get_Elements(){
        var calc = new Average_Calculator();
        double[] arr = {1, 2, 3};
        double[] arr_expected = {1, 2, 3};
        calc.Add(arr);
        double[] arr_get = calc.Get_Elements();
        Assert.Equal(arr_expected, arr_get);
    }

    [Fact]
    public void Get_Elements_No_Elements(){
        var calc = new Average_Calculator();
        double[] arr = {};
        double[] arr_expected = {};
        calc.Add(arr);
        double[] arr_get = calc.Get_Elements();
        Assert.Equal(arr_expected, arr_get);
    }

    [Fact]
    public void Get_Elements_With_One_Element(){
        var calc = new Average_Calculator();
        double[] arr = {2.5};
        double[] arr_expected = {2.5};
        calc.Add(arr);
        double[] arr_get = calc.Get_Elements();
        Assert.Equal(arr_expected, arr_get);
    }
}