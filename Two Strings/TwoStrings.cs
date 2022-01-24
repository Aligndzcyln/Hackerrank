class Result
{

    /*
     * Complete the 'twoStrings' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. STRING s1
     *  2. STRING s2
     */

    public static string twoStrings(string s1, string s2)
    {
        var s1Set = new HashSet<char>();
        foreach(var item in s1)
        {
            s1Set.Add(item);
        }
        foreach(var item in s2)
        {
            if(s1Set.Contains(item))
            {
                return "YES";
            }
        }
        return "NO";
    }

}