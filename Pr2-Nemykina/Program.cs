// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


public class Functions
{
    public static int Factorial(int num)
    {
        int factorial = 1;
        for (int i = 1; i <= num; i++)
        {
            factorial *= i;
        }
        return factorial;
    }

    public static bool Parity(int num)
    {
        if (num % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static int MaxNumber(int[] nums)
    {
        return nums.Max();
    }

    public static double AverageNumber(double[] nums)
    {
        return nums.Average();
    }

}

