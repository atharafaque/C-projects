internal class Program
{
    private static void Main(string[] args)
    {
        string textAge = "-23";

        var age = Convert.ToInt32(textAge);
        Console.WriteLine(age);
        // Console.WriteLine(int.MaxValue);
        // Console.WriteLine(int.MinValue);


        string textBigNumber = "-900000000";
        long bigNumber = Convert.ToInt64(textBigNumber);
        Console.WriteLine(bigNumber);
        // Console.WriteLine(long.MaxValue);
        // Console.WriteLine(long.MinValue);

        string textNegative = "-55.2";

        double negative = Convert.ToDouble(textNegative);

        Console.WriteLine(negative);
        // Console.WriteLine(double.MaxValue);
        // Console.WriteLine(double.MinValue);

        string textPrecision = "5.000001";
        float precision = Convert.ToSingle(textPrecision);
        Console.WriteLine(precision);
        // Console.WriteLine(float.MaxValue);
        // Console.WriteLine(float.MinValue);

        string textMoney = "14.99";
        decimal money = Convert.ToDecimal(textMoney);
        Console.WriteLine(money);
        // Console.WriteLine(decimal.MaxValue);
        // Console.WriteLine(decimal.MinValue);

        Console.ReadLine();
    }
}