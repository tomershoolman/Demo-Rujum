using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if (gameObject.tag == "Clicked")
      {
        if(this.GetComponent<Rigidbody>().useGravity == true)
          {
            this.GetComponent<Rigidbody>().useGravity = false;
          }
        if (Input.GetKey(KeyCode.Space))
          {
            this.GetComponent<Rigidbody>().useGravity = true;
            gameObject.tag = "Block";
          }
      }
      else
      {
        this.GetComponent<Rigidbody>().useGravity = true;    
      }



    }
}
