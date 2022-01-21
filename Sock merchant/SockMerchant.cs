class Result
{

    /*
     * Complete the 'sockMerchant' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER_ARRAY ar
     */

    public static int sockMerchant(int n, List<int> ar)
    {
        var socCount = 0;
        var hashSet = new HashSet<int>();
        
        foreach(var item in ar)
        {
            if(!hashSet.Contains(item))
            {
                hashSet.Add(item);
            }
            else
            {
                socCount++;
                hashSet.Remove(item);
            }
        }
        return socCount;
    }

}