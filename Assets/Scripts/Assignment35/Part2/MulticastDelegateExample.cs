using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment35
{
    delegate void MathOperation(int number);
    public class MulticastDelegateExample : MonoBehaviour
    {
        public void DoubleNumber(int number) => Debug.Log(2 * number);
        public void SquareNumber(int number) => Debug.Log(number * number);
        public void CubeNumber(int number) => Debug.Log(number * number * number);
        MathOperation mathOperation;
        void Start()
        {
            mathOperation += DoubleNumber;
            mathOperation += SquareNumber;
            mathOperation += CubeNumber;
            mathOperation?.Invoke(10);
        }
    }
}