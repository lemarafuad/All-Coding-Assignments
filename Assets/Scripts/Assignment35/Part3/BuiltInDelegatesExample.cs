using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment35
{
    public class BuiltInDelegatesExample : MonoBehaviour
    {
        Action logMessage = () => Debug.Log("Hi Iam an Action Hello from Action delegate!");
        Func<int, int> square = (int num) => num * num;
        Predicate<int> isEven = (int num) => num % 2 == 0;

        void Start()
        {
            logMessage();
            Debug.Log($"The Square of 10 is : {square(10)}");
            Debug.Log($"Is 10 even? {isEven(10)}");
        }
    }
}