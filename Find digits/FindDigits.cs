class Result
{

    /*
     * Complete the 'findDigits' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER n as parameter.
     */

    public static int findDigits(int n)
    {
        var count = 0;
        var temp = n;
        while(temp > 0)
        {
            var digit = temp % 10;
            if(digit != 0 && n % digit == 0)
            {
                count++;
            }
            temp = temp / 10;
        }
        return count;
    }

}