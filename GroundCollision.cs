using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCollision : MonoBehaviour
{
    public GameObject b1;
    public GameObject b2;
    public GameObject b3;
    public GameObject b4;
    public GameObject b5;

   
    int block1 = 0;
    int block2 = 0;
    int block3 = 0;
    int block4 = 0;
    int block5 = 0;
    int enter = 0;
    int sum =1;
    int valueToReturn =0;

    private void OnCollisionEnter(Collision other)
    {
        
        enter = 1;
        if (other.gameObject.name == b1.gameObject.name)
        {
            block1 = 1;
        }
        if (other.gameObject.name ==b2.gameObject.name)
        {
            block2 = 1;
        }
        if (other.gameObject.name ==b3.gameObject.name)
        {
            block3 = 1;
        }
        if (other.gameObject.name ==b4.gameObject.name)
        {
            block4 = 1;
        }
        if (other.gameObject.name ==b5.gameObject.name)
        {
            block5 = 1;
        }
        sum = block1 + block2 +block3 + block4+block5;
        //print(block1+" "+block2+" "+block3+block4+" "+block5+ " Enter:"+enter +"sum: " +sum);


    }
    /*private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.name == "Cube")
        {
            block = 2;
        }
        if (other.gameObject.name == "Cube 1")
        {
            block1 = 2;
        }
        if (other.gameObject.name == "Cube 2")
        {
            block2 = 2;
        }


    }*/
    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.name == b1.gameObject.name)
        {
            block1 = 0;
        }
        if (other.gameObject.name == b2.gameObject.name)
        {
            block2 = 0;
        }
        if (other.gameObject.name == b3.gameObject.name)
        {
            block3 = 0;
        }
        if (other.gameObject.name == b4.gameObject.name)
        {
            block4 = 0;
        }
        if (other.gameObject.name == b5.gameObject.name)
        {
            block5 = 0;
        }
        sum = block1 + block2 +block3 +block4+block5;
        //print(block1+" "+block2+" "+block3+block4+" "+block5+ " Enter:"+enter +"sum: " +sum);

    }


    public int ReturnValue()
    {
        if (enter==1 && sum==0)
        {
            valueToReturn = 1;
        }   
        else
        {
            valueToReturn = 0;
        }  
        return valueToReturn;

    }
    
}
