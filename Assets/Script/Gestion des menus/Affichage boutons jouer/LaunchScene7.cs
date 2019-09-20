using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchScene7 : MonoBehaviour
{
    //Variables
    public GameObject CanvasCube7;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (ES2.Exists("scene10"))
            {
                if (ES2.Load<bool>("scene10"))
                {
                    Debug.Log(ES2.Load<bool>("scene10"));
                    CanvasCube7.SetActive(true);
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        CanvasCube7.SetActive(false);
    }
}