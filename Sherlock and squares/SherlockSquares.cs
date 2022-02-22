class Result
{

    /*
     * Complete the 'squares' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER a
     *  2. INTEGER b
     */

    public static int squares(int a, int b)
    {
        var lower = Math.Ceiling(Math.Sqrt(a));
        var upper = Math.Floor(Math.Sqrt(b));
        
        return (int)(upper - lower + 1);
    }

}