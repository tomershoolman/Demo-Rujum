using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float Rspeed;

    // Start is called before the first frame update
    // With that function, the 'Clicked' object can be rotate to x,y,z axis

    // Update is called once per frame
    void Update()
    {
      if (gameObject.tag == "Clicked")
      {
        if(Input.GetKey(KeyCode.H))
        {
          transform.Rotate(0.0f, Rspeed*Time.deltaTime, 0.0f,Space.World);
        }
        else if (Input.GetKey(KeyCode.K))
        {
          transform.Rotate(0.0f, -Rspeed*Time.deltaTime, 0.0f,Space.World);
        }
        else if (Input.GetKey(KeyCode.U))
        {
          transform.Rotate(Rspeed*Time.deltaTime, 0.0f, 0.0f,Space.World);
        }
        else if (Input.GetKey(KeyCode.J))
        {
          transform.Rotate(-Rspeed*Time.deltaTime, 0.0f, 0.0f,Space.World);
        }
        else if (Input.GetKey(KeyCode.N))
        {
          transform.Rotate(0.0f, 0.0f, Rspeed*Time.deltaTime,Space.World);
        }
        else if (Input.GetKey(KeyCode.M))
        {
          transform.Rotate(0.0f, 0.0f, -Rspeed*Time.deltaTime,Space.World);
        }
      }
      

    }
}
