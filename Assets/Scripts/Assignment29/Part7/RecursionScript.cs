using UnityEngine;

namespace Part7
{
    public class RecursionScript : MonoBehaviour
    {
        void Start()
        {
            Debug.Log($"The Result Of Fibonacci (10) Using Recursive Function is {FibonacciRecursive(10)}");
            Debug.Log($"The Result Of Fibonacci (10) Using Iterative Function is {FibonacciIterative(10)}");
            Debug.Log($"The Result Of Fibonacci (30) Using Recursive Function is {FibonacciRecursive(30)}");
            Debug.Log($"The Result Of Fibonacci (30) Using Iterative Function is {FibonacciIterative(30)}");
        }

        int FibonacciRecursive(int n)
        {
            if (n == 0) return 0;
            else if (n == 1) return 1;
            else if (n < 0) return -1;
            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }

        int FibonacciIterative(int n)
        {
            int[] fiboArray = new int[n + 1];

            for (int i = 0; i <= n; i++)
            {
                if (i == 0) fiboArray[0] = 0;
                else if (i == 1) fiboArray[1] = 1;
                else fiboArray[i] = fiboArray[i - 1] + fiboArray[i - 2];

            }
            return fiboArray[n];
        }
    }
}