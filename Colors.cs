using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colors : MonoBehaviour
{
    // Start is called before the first frame update
    //this function change the color of clicked object
    private MeshRenderer myRend;
    void Start()
    {
        myRend = GetComponent<MeshRenderer>();
        
    }
    private void Update() 
    {
        if (gameObject.tag == "Block")
        {
          myRend.material.color = Color.white;
        }
        else if (gameObject.tag == "Clicked")
        {
          myRend.material.color = Color.gray;

        }
    }
}
