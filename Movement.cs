using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float forceValue;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
      rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
      if (gameObject.tag == "Clicked")
      {
        //rb.AddForce(new Vector3(Input.GetAxis("Horizontal"),
        //                        0,
        //                        Input.GetAxis("Vertical"))*forceValue);
        if (Input.GetKey(KeyCode.Q))  
        {  
            transform.Translate(0.0f, -0.005f*forceValue, 0.0f,Space.World);  
        }  
        if (Input.GetKey(KeyCode.E))  
        {  
            transform.Translate(0.0f, 0.005f*forceValue, 0.0f,Space.World);  
        } 
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))  
        {  
            transform.Translate(0.0f, 0.0f, 0.005f*forceValue,Space.World);  
        }  
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))  
        {  
            transform.Translate(0.0f, 0.0f, -0.005f*forceValue,Space.World);  
        } 
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))  
        {  
            transform.Translate(-0.005f*forceValue, 0.0f, 0.0f,Space.World);  
        }  
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))  
        {  
            transform.Translate(0.005f*forceValue, 0.0f, 0.0f,Space.World);  
        } 
      }
    }
}
