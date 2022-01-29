class Result
{

    /*
     * Complete the 'maximumToys' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY prices
     *  2. INTEGER k
     */

    public static int maximumToys(List<int> prices, int k)
    {
        prices.Sort();
        
        var count = 0;
        for(var i = 0; i < prices.Count(); i++)
        {
            k -= prices[i];
            if(k < 0)
            {
                break;
            }
            count++;
        }
        return count;
    }
}