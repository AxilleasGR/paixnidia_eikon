using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movemntAnmations : MonoBehaviour
{
    public Animator myanim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift) && (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)))
        {
            myanim.SetBool("walk", false);
            myanim.SetBool("run", true);
            myanim.SetBool("attack", false);
            myanim.SetBool("jump", false);
        }
        else if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            myanim.SetBool("walk", true);
            myanim.SetBool("run", false);
            myanim.SetBool("attack", false);
            myanim.SetBool("jump", false);

        }
        else if (Input.GetKey(KeyCode.Space) && (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)))
        {
            myanim.SetBool("jump", true);
            myanim.SetBool("walk", false);
            myanim.SetBool("run", false);
            myanim.SetBool("attack", false);
        }
        else
        {
            myanim.SetBool("walk", false);
            myanim.SetBool("run", false);
            myanim.SetBool("jump", false);
        }

        if (Input.GetMouseButtonDown(0)) //Left  click
        {
            
            myanim.SetBool("attack", true);
            myanim.SetBool("walk", false);
            myanim.SetBool("run", false);
            myanim.SetBool("jump", false);

        }
        else
        {
            myanim.SetBool("attack", false);
        } 
        
        if (Input.GetKey(KeyCode.Space))
        {
            
            myanim.SetBool("attack", false);
            myanim.SetBool("walk", false);
            myanim.SetBool("run", false);
            myanim.SetBool("jump", true);

        }
        else
        {
            myanim.SetBool("jump", false);
        }


    }
}
