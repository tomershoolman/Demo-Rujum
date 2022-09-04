using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCameras : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Camera1;
    public GameObject Camera2;
    public GameObject Camera3;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKey(KeyCode.Alpha1))
      {
        CameraOne();
      }
      if(Input.GetKey(KeyCode.Alpha2))
      {
        CameraTwo();
      }
      if (Input.GetKey(KeyCode.Alpha3))
      {
        CameraThree();
      }
    }
    void CameraOne()
    {
      Camera1.SetActive(true);
      Camera2.SetActive(false);
      Camera3.SetActive(false);
    }
    void CameraTwo()
    {
      Camera1.SetActive(false);
      Camera2.SetActive(true);
      Camera3.SetActive(false);
    }
    void CameraThree()
    {
      Camera1.SetActive(false);
      Camera2.SetActive(false);
      Camera3.SetActive(true);
    }
}
