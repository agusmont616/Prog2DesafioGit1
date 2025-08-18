Console.WriteLine(Addition.Add(7, 2));
Console.WriteLine(Substraction.Substract(10, 1));
Console.WriteLine(Multiplication.Multiply(3, 3));
Console.WriteLine(Division.Divide(18, 2));


// Esta clase implementa la operación suma
public class Addition
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
}

public class Power
{
    public static int Squared(int a)
    {
        return a * a;
    }
}