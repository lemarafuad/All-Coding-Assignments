using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment27
{


    public class Assignment27Script : MonoBehaviour
    {

        void Start()
        {
            int varA = 14;
            int varB = 7;
            ModifyNumByVal(varA);
            Debug.Log(varA);
            ModifyNumByRef(ref varB);
            Debug.Log(varB);
            ModifyNumByOut(out varA);
            Debug.Log(varA);

        }

        void ModifyNumByVal(int parameter)
        {
            parameter += 2;
        }

        void ModifyNumByRef(ref int parameter)
        {
            parameter += 2;
        }

        void ModifyNumByOut(out int parameter)
        {
            parameter = 99;
        }
    }
}