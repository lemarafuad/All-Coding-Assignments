using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplicationTable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for(int i=1;i<=10;i++){
            int output = Multiply(5,i);
            Debug.Log("5 * "+i+" = "+output);
        }
        
    }
    int Multiply(int number1,int number2){
        return number1*number2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
