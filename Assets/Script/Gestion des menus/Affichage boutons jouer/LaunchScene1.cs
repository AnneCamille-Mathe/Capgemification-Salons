using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchScene1 : MonoBehaviour
{
    //Variables
    public GameObject CanvasCube1;
    
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
            if (ES2.Exists("scene4"))
            {
                if (ES2.Load<bool>("scene4"))
                {
                    Debug.Log(ES2.Load<bool>("scene4"));
                    CanvasCube1.SetActive(true);
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        CanvasCube1.SetActive(false);
    }
}