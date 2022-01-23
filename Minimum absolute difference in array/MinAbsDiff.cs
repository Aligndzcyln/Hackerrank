class Result
{

    /*
     * Complete the 'minimumAbsoluteDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int minimumAbsoluteDifference(List<int> arr)
    {
        var n = arr.Count();
        var min = int.MaxValue;
        var curr = 0;
        for(var i = 0; i < n; i++)
        {
            for(var j = 0; j < n; j++)
            {
                if(i != j)
                {
                    curr = Math.Abs(arr[i] - arr[j]);
                    if(min > curr && curr >= 0 )
                    {
                        min = curr;
                    }
                }
            }
        }
        return min;
    }

}