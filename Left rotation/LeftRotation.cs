class Result
{

    /*
     * Complete the 'rotLeft' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER d
     */

    public static List<int> rotLeft(List<int> a, int d)
    {
        var rotatedList = new List<int>();
        var index = d;
        while(index < a.Count)
        {
            rotatedList.Add(a[index]);
            index++;
        }
        index = 0;
        
        while(index < d)
        {
            rotatedList.Add(a[index]);
            index++;
        }
        return rotatedList;
    }
}