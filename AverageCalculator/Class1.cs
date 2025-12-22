namespace AverageCalculator;

public class Average_Calculator
{
    private double[] intern_val = [];
    private double avg;
    
    /// <summary>
    /// Adds a double value to an array
    /// </summary>
    /// <param name="double_val">double value</param>
    public void Add(double val){
        intern_val = intern_val.Append(val).ToArray();
    }
    /// <summary>
    /// Adds multiple double values
    /// </summary>
    /// <param name="val">double value1, double value2...</param>
    public void Add(double[] val){
        if(val.Length == 0){
            Console.WriteLine("The Length of the Array is zero!");
        }
        else{
            for (int i = 0; i < val.Length; i++){
               intern_val = intern_val.Append(val[i]).ToArray();
            }
        }
    }

    public double GetAverage(){
        double sum = 0;
        if (intern_val.Length == 0){
            Console.WriteLine("The Length of the Array is zero!");
        }
        else{
            for(int i = 0; i < intern_val.Length; i++){
                sum += intern_val[i];
            }
            avg = sum/intern_val.Length;
        }
        return avg;
    }

    public double[] Get_Elements(){
        return intern_val;
    }

    public int count(){
        return intern_val.Length;
    }
}
