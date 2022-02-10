public static int minimumLoss(List<long> price)
    {
        var map = new Dictionary<long, int>();
        for(var i = 0; i < price.Count; i++)
        {
            map.Add(price[i], i);
        }
        
        price.Sort();
        var minLoss = long.MaxValue;
        
        for(var i = price.Count - 1; i > 0; i--)
        {
            var current = price[i] - price[i - 1];
            if(current < minLoss && map[price[i]] < map[price[i - 1]] )
            {
                minLoss = current;
            }   
        }
        return (int)minLoss;
    }