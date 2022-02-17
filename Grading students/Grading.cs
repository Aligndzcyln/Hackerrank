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
                var rest = grades[i] % 5;
                if((5 - rest) < 3)
                {
                    grades[i] = grades[i] + (5 - rest);
                }
            }
        }
        return grades;
    }

}