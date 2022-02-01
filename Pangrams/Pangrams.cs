class Result
{

    /*
     * Complete the 'pangrams' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string pangrams(string s)
    {
        var hashSet = new HashSet<char>();
        foreach(var c in s.ToLower())
        {
            if(char.IsLetter(c))
            {
                hashSet.Add(c);
            }
        }
        return hashSet.Count == 26 ? "pangram" : "not pangram";
    }
}
