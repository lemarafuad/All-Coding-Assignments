using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment35
{
    public class BoxingUnboxing : MonoBehaviour
    {
        void Start()
        {
            int health = 100;
            Debug.Log("The Original Value is : " + health);
            object boxing = health;
            Debug.Log("The Boxed Value is : " + boxing);
            int unboxing = (int)boxing;
            unboxing = unboxing + 14;
            Debug.Log("The Unboxed and Modified Value is : " + unboxing);
        }
    }
}