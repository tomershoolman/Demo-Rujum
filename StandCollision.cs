using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandCollision : MonoBehaviour
{
    // Start is called before the first frame update
    int valueToReturn=0;
    private void OnCollisionEnter(Collision other)
    {
        
        if (other.gameObject.tag == "Block")
        {
            valueToReturn = 1;
        }
        //print(valueToReturn);

    }
    private void OnCollisionExit(Collision other)
    {
        
        if (other.gameObject.tag == "Clicked")
        {
            valueToReturn = 0;
        }
        //print(valueToReturn);
    }
    public int ReturnValue() 
    {
        return valueToReturn;
    }
    public void printing()
    {
        print (valueToReturn);
    }
}
