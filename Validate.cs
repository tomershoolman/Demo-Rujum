using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;

public class Validate : MonoBehaviour
{
    // select all block to check gravity
    public GameObject Block1;
    public GameObject Block2;
    public GameObject Block3;
    public GameObject Block4;
    public GameObject Block5;

    // for gravity - bool parameter to get if each block has gravity
    bool g1, g2,g3, g4,g5;
    // for checking the gravity on all the blocks
    int valueToReturn = 0; // check if the value is true
    // parameter that will give values to no if the level is finish, if all of them true (=1) the level wiil end
    int gravity,stand,ground;

    public GroundCollision gr;
    public StandCollision st;
    //check if all values are true (equal to 1)
    int sum =0;
    int valFinish;

    //for timer, check if it passed 5 seconds
    float StartingTime = 5f;
    //public Text for - Finish Level;
    public GameObject completeLevelUI;

    private void Start() {
        StartingTime = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        gravity = GravityIsTrue(); // check if every block has gravity
        stand = st.ReturnValue(); // check if at least one block is on the stand
        ground=gr.ReturnValue(); // check if the game started and there are not blocks on the table/ground 
        sum = gravity+stand+ground;
        //print("gr: " + gravity + "st: "+stand + "ground: " + ground);

        /*if (sum==3)
        {
            print ("gr: "+ground+", st: "+stand+", grav: "+gravity);

        }*/
        if (sum==3) // add time counter!!!!!!
        {
            
            if (StartingTime>0f)
            {
                StartingTime -=1 * Time.deltaTime;
                print (StartingTime); 
            }
            else
            {

                if (sum==3)
                {
                    valFinish = 1;
                    
                    CompleteLevel();
                }
                else
                {
                    StartingTime = 5f;
                }
            }

        }
        
        if(sum!=3)
        {
            StartingTime = 5f;
        }
        

        
    }
    private int GravityIsTrue()
    {
       g1 = Block1.GetComponent<Rigidbody>().useGravity;
       g2 = Block2.GetComponent<Rigidbody>().useGravity;
       g3 = Block3.GetComponent<Rigidbody>().useGravity;
       g4 = Block4.GetComponent<Rigidbody>().useGravity;
       g5 = Block5.GetComponent<Rigidbody>().useGravity;
       if (g1&&g2&&g3 && g4&&g5)
       {
           valueToReturn = 1;
       }
       else
       {
           valueToReturn=0;

       }
       return valueToReturn;
    }

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }
 
}
