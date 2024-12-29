using UnityEngine;

namespace Part3
{
    public static class Utilities
    {

        public static void Add(params int[] numbers)
        {
            int result = 0;
            if (numbers.Length > 0)
            {
                foreach (int number in numbers)
                {
                    result += number;
                }
            }

            Debug.Log(result);
        }

        public static string RepeatString(this string word, int repeatesNum)
        {
            if (repeatesNum > 0)
            {
                string repeatedString = " ";
                for (int i = 0; i < repeatesNum; i++)
                {
                    repeatedString += word;
                }

                return repeatedString;

            }
            else return "Error";

        }

    }
}