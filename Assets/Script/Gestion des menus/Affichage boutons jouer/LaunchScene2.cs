using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchScene2 : MonoBehaviour
{
    //Variables
    public GameObject CanvasCube2;
    
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
            if (ES2.Exists("scene5"))
            {
                if (ES2.Load<bool>("scene5"))
                {
                    Debug.Log(ES2.Load<bool>("scene5"));
                    CanvasCube2.SetActive(true);
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        CanvasCube2.SetActive(false);
    }
}