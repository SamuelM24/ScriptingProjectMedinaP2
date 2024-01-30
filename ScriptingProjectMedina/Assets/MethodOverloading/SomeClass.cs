using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeClass : MonoBehaviour
{
    public int Add(int num1, int num2)
    {
        int result = num1 + num2;
        Debug.Log("Result of adding integers: " + result);
        return result;
    }

    public string Add(string str1, string str2)
    {
        string result = str1 + str2;
        Debug.Log("Result of adding strings: " + result);
        return result;
    }
}
