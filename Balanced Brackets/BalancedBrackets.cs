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
     * Complete the 'isBalanced' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string isBalanced(string s)
    {
        var n = s.Length;
        var myStack = new Stack<char>();
        for(var i = 0; i < n; i++)
        {
            if(s[i] == '(' || s[i] == '[' || s[i] == '{')
            {
                myStack.Push(s[i]);
            }
            else
            {
                if(myStack.Count == 0)
                {
                    return "NO";
                }
                else
                {
                    var str = myStack.Pop();
                    if(s[i] == ')' && str != '(')
                    {
                        return "NO";
                    }
                    else if(s[i] == '}' && str != '{')
                    {
                        return "NO";
                    }
                    else if(s[i] == ']' && str != '[')
                    {
                        return "NO";
                    }
                }
                
            }
        }
        if(myStack.Count == 0)
        {
            return "YES";
        }
        else
        {
            return "NO";
        }
        
    }

}