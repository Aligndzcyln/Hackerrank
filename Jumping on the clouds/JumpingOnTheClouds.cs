class Result
{

    /*
     * Complete the 'jumpingOnClouds' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY c as parameter.
     */

    public static int jumpingOnClouds(List<int> c)
    {
        var n = c.Count();
        var jump = 0;
        var i = 0;
        while(i < n - 1)
        {
            if(i + 2 == n || c[i + 2] == 1)
            {
                i++;
            }
            else
            {
                i += 2;
            }
            jump++;
        }
        return jump;
    }

}