using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnviromentClick : MonoBehaviour
{
    [SerializeField]
    private LayerMask ClickLabel;
    public GameObject block1;
    public GameObject block2;
    public GameObject block3;
    public GameObject block4;
    public GameObject block5;

    // Update is called once per frame

    void Update()
    {
      if(Input.GetMouseButtonDown(0)){
        RaycastHit rayHit;
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out rayHit, Mathf.Infinity, ClickLabel))
        {
            block1.gameObject.tag = "Block";
            block2.gameObject.tag = "Block";
            block3.gameObject.tag = "Block";
            block4.gameObject.tag = "Block";
            block5.gameObject.tag = "Block";

          }
          //rayHit.collider.GetComponent<ClicksOn>().ClickMe();
      }
    }
}
