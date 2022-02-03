class Result
{

    /*
     * Complete the 'primality' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts INTEGER n as parameter.
     */

    public static string primality(int n)
    {
        return isPrime(n) ? "Prime" : "Not prime";
    }
    
    public static bool isPrime(int n)
    {
        if(n < 2) return false;
        if(n == 2) return true;
        if(n % 2 == 0) return false;
        
        var sqrt = (int)Math.Sqrt(n);
        for(var i = 3; i <= sqrt; i += 2)
        {
            if(n % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}