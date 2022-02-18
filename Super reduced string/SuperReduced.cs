class Result
{

    /*
     * Complete the 'superReducedString' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string superReducedString(string s)
    {
        var stack = new Stack<char>();
        for(var i = 0; i < s.Length; i++)
        {
            if(stack.Count > 0 && s[i] == stack.Peek())
            {
                stack.Pop();
            }
            else
            {
                stack.Push(s[i]);
            }
        }
        if(stack.Count == 0)
        {
            return "Empty String";
        }
        else
        {
            var str = "";
            while(stack.Count > 0)
            {
                str = stack.Pop() + str;
            }
            return str;
        }

    }

}