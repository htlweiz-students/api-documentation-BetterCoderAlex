using AverageCalculator;
namespace Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Average_Calculator average = new();
        average.Add(2);
        average.Add(1);
        double[] original = {2, 1};
        for(int i = 0; i <original.Length; i++){
            Assert.Equal(original[i], average.Get_Elements()[i], precision: 4);
        }
        
    }
}