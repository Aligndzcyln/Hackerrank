public static int chocolateFeast(int n, int c, int m)
    {
        var sum = 0;
        var totalWrapperCount = n / c;
        sum = totalWrapperCount;
        
        while(totalWrapperCount >= m)
        {
            var barCount = totalWrapperCount / m;
            var currentWrapperLeft = totalWrapperCount % m;
            sum += barCount;
            totalWrapperCount = barCount + currentWrapperLeft;
        }
        return sum;
    }