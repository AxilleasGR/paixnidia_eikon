using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paladinDie : MonoBehaviour
{
    public Animator MyaAnimator;
    private bool inTrigger=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        inTrigger = true;
    }
    private void OnTriggerExit(Collider other)
    {
        inTrigger = false;
    }
    private int i = 0;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)&& inTrigger)
        {
            i++;
            if (i == 3)
            {
                MyaAnimator.SetBool("dead", true);
                
            }
        }
    }
}
