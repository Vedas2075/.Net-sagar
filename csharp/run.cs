using ABC;

public class program
{
    public static void Main()
    {

        BasicCalculator calculator1 = New(34.3,32.23);
        var y = BasicCalculator.brand;
        
        var s1 = calculator1.Sum();
        var d1 = calculator1.Subtract();
        var m1 = calculator1.Multiply();
        var di1 = calculator1.Divide();

    }
}