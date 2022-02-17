class Result
{

    /*
     * Complete the 'gradingStudents' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY grades as parameter.
     */

    public static List<int> gradingStudents(List<int> grades)
    {
        for(var i = 0; i < grades.Count; i++)
        {
            if(grades[i] >= 38)
            {
                var rest = 5 - (grades[i] % 5);
                if(rest < 3)
                {
                    grades[i] = grades[i] + rest;
                }
            }
        }
        return grades;
    }

}