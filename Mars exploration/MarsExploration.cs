class Result
{

    /*
     * Complete the 'marsExploration' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING s as parameter.
     */

    public static int marsExploration(string s)
    {
        // There is two method for the solution

        // var counter = 0;
        // var repeatCount = s.Count() / 3;
        // for(var i = 0; i < repeatCount; i++)
        // {
        //     if(s[3*i] != 'S')
        //     {
        //         Console.WriteLine(s[3*i]);
        //         counter++;
        //     }
        //     else if(s[3*i + 1] != 'O')
        //     {
        //         Console.WriteLine(s[3*i + 1]);
        //         counter++;
        //     }
        //     else if(s[3*i + 2] != 'S')
        //     {
        //         Console.WriteLine(s[3*i + 2]);
        //         counter++;
        //     }
        // }
        // return counter;
        
        var repeatCount = s.Count() / 3;
        var originalMessage = string.Empty;
        for(var i = 0; i < repeatCount; i++)
        {
            originalMessage += "SOS";
        }
        var diffCount = 0;
        for(var i = 0; i < s.Count(); i++)
        {
            if(originalMessage[i] != s[i])
            {
                diffCount++;
            }
        }
        return diffCount;
    }

}