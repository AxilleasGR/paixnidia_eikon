using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TalkingMaleB : MonoBehaviour
{
    
    public Canvas canvas;
    public TMP_Text text;
    private bool inTrigger=false;
    private bool pressedE=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        inTrigger = true;
        pressedE = false;
        canvas.gameObject.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        inTrigger = false;
        pressedE = false;
        canvas.gameObject.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (inTrigger)
        {
            if (Input.GetKey(KeyCode.E))
                pressedE = true;
            text.text = pressedE ? "Your goal is to kill 4 paladins. Good Luck" : "\t Press E to interact";
        }
    }
}
