static int findLonely(List<int> arr)
{
    var result = 0;
    foreach (var item in arr)
    {
        result = result ^ item;
    }
    return result;
}