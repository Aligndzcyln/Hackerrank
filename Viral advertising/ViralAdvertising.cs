class Result
{

    /*
     * Complete the 'viralAdvertising' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER n as parameter.
     */

    public static int viralAdvertising(int n)
    {
        var people = 2;
        var likeCount = 2;
        for(var i = 2; i <= n; i++)
        {
            people = (people * 3) / 2;
            likeCount += people;  
        }
        return likeCount;
    }

}