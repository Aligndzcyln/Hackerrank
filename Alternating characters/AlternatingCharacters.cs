class Result
{

    /*
     * Complete the 'alternatingCharacters' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING s as parameter.
     */

    public static int alternatingCharacters(string s)
    {
        var count = 0;
        for(var i = 0; i < s.Length - 1; i++)
        {
            if(s[i] == s[i + 1])
            {
                count++;
            }
        }
        return count;
    }

}