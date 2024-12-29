using UnityEngine;

namespace Part1
{
    public class BasicsScript : MonoBehaviour
    {
        void Start()
        {
            VarFunction();
            DateTimeFunction();
        }

        void VarFunction()
        {
            var integarVar = 15;
            var stringVar = " ";
            var booleanVar = true;
            booleanVar = integarVar % 2 == 0 ? true : false;
            stringVar = booleanVar == true ? $"The number {integarVar} is Even" : $"The number {integarVar} is Odd";
            Debug.Log(stringVar);
        }

        void DateTimeFunction()
        {
            Debug.Log(System.DateTime.Now.Date);
            Debug.Log(System.DateTime.Now.TimeOfDay);
            Debug.Log(System.DateTime.Now.DayOfWeek);
        }

    }
}