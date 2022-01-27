class Result
{

    /*
     * Complete the 'caesarCipher' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. INTEGER k
     */

    public static string caesarCipher(string s, int k)
    {
        var sb = new StringBuilder();
        foreach(var c in s)
        {
            if(!char.IsLetter(c))
            {
                sb.Append(c);
            }
            else
            {
                var root = char.IsUpper(c) ? 'A' : 'a';
                var ascii = (c - root + k) % 26 + root;
                sb.Append((char)ascii); 
            }
        }
        return sb.ToString();
    }
}