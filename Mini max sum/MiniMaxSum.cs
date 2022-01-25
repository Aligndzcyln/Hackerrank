class Result
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        var n = arr.Count();
        long sum = 0;
        long min = long.MaxValue;
        long max = long.MinValue;
        for(var i = 0; i < n; i++)
        {
            sum += arr[i];
            min = Math.Min(min, arr[i]);
            max = Math.Max(max, arr[i]);
        }
        Console.WriteLine($"{sum - max} {sum - min}");
    }

}