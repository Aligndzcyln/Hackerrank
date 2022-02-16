class Result
{

    /*
     * Complete the 'camelcase' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING s as parameter.
     */

    public static int camelcase(string s)
    {
        var count = 1;
        foreach(var c in s)
        {
            if(char.IsUpper(c)) count++;
        }
        return count;
    }

}