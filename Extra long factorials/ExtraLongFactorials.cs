class Result
{

    /*
     * Complete the 'extraLongFactorials' function below.
     *
     * The function accepts INTEGER n as parameter.
     */

    public static void extraLongFactorials(int n)
    {
        var result = BigInteger.One;
        for(var i = 2; i <= n; i++)
        {
            result *= i;
        }
        Console.WriteLine(result);
    }

}