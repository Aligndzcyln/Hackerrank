using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<List<int>> arr)
    {
        var n = arr.Count;
        var sum = 0;
        for(var i = 0; i < n; i++)
        {
            for(var j = 0; j < n; j++)
            {
                if(i == j)
                {
                    sum += arr[i][j];
                }
                if(i + j  == n - 1)
                {
                    sum -= arr[i][j];
                }
            }
        }
        return Math.Abs(sum);
    }

}