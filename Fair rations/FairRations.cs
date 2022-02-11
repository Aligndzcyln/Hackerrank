class Result
{

    /*
     * Complete the 'fairRations' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts INTEGER_ARRAY B as parameter.
     */

    public static string fairRations(List<int> B)
    {
       var total = 0;
       for(var i = 0; i < B.Count - 1; i++)
       {
           if(B[i] % 2 != 0)
           {
               B[i] += 1;
               B[i + 1] += 1;
               total += 2;
            }
            while(i < B.Count - 1 && B[i + 1] % 2 == 0)
            {
                i++;
            }
        }
        if(B[B.Count - 1] % 2 == 1)
        {
            return "NO";
        }
        else
        {
            return total.ToString();
        }
    }
}