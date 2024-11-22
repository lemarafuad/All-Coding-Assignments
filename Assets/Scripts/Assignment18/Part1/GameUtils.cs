using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment18
{
    public class GameUtils
    {
        static public string DescribeItem<T>(T something)
        {
            string response = "This item is " + something;
            return response;
        }
    }
}