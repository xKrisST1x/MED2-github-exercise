using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ExerciseCode : MonoBehaviour
{
    int myVariable = 0;

    private void Start() {
        Debug.Log("myVariable value: " + myVariable);
        
        // PassByValue(myVariable);
        PassByReference(ref myVariable);
        
        Debug.Log("myVariable value: " + myVariable);
    }

    public void PassByValue(int var)
    {
        var = var + 10;
        Debug.Log("Value inside function: " + var);
    }

    public void PassByReference(ref int var)
    {
        var = var + 10;
        Debug.Log("Value inside function: " + var);
    }
    
}
