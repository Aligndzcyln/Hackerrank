class Result
{

    /*
     * Complete the 'repeatedString' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. LONG_INTEGER n
     */

    public static long repeatedString(string s, long n)
    {
        var count = 0;
        for(var i = 0; i < s.Length; i++)
        {
            if(s[i] == 'a')
            {
                count++;
            }
        }
        
        var repeatCount = n / s.Length;
        var remainedCharCount = n % s.Length;
        long result = repeatCount * count;
        
        for(var i = 0; i < remainedCharCount; i++)
        {
            if(s[i] == 'a')
            {
                result++;
            }
        }
        return result;
    }

}