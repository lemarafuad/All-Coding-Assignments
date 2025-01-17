using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment35
{
    public class ListMethodsExample : MonoBehaviour
    {
        List<int> numbers0 = new List<int> { 3, 1, 4, 1, 5, 9 };
        List<int> numbers1 = new List<int> { 3, 1, 4, 1, 5, 9, 2, 6 };
        List<int> filteredNumbers = new List<int>();

        void Start()
        {
            ReverseSorting();
            FindEven();
        }
        void ReverseSorting()
        {
            numbers0.Sort((int x, int y) => y.CompareTo(x));
            Debug.Log(string.Join(", ", numbers0));
        }
        void FindEven()
        {
            foreach (var num in numbers1.FindAll((int eveNum) => eveNum % 2 == 0))
            {
                filteredNumbers.Add(num);
            }
            Debug.Log(string.Join(", ", filteredNumbers));
        }
    }
}