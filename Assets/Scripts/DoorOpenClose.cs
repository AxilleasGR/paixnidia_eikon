using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.UI;

public class DoorOpenClose : MonoBehaviour
{
    public Animator animator;
    private bool inTrigger=false;
    public Text textElement;
    private void OnTriggerEnter(Collider other)
    {
        inTrigger = true;
        if (!animator.GetBool("DoorOpen"))
        {
            textElement.text = "PRESS E TO OPEN DOOR";
        }
        else
            textElement.text = "PRESS E TO CLOSE DOOR";
    }
    private void OnTriggerExit(Collider other)
    {
        inTrigger = false;
        textElement.text = "";
    }

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (inTrigger)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (!animator.GetBool("DoorOpen"))
                {
                    animator.SetBool("DoorOpen",true); 
                    textElement.text = "PRESS E TO CLOSE DOOR";
                }
                else
                {
                    animator.SetBool("DoorOpen",false); 
                    textElement.text = "PRESS E TO OPEN DOOR";
                }
            }
        }
    }
    
}
