using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchScene4 : MonoBehaviour
{
    //Variables
    public GameObject CanvasCube4;
    
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
            if (ES2.Exists("scene7"))
            {
                if (ES2.Load<bool>("scene7"))
                {
                    Debug.Log(ES2.Load<bool>("scene7"));
                    CanvasCube4.SetActive(true);
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        CanvasCube4.SetActive(false);
    }
}