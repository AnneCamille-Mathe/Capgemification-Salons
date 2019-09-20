using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchScene3 : MonoBehaviour
{
    //Variables
    public GameObject CanvasCube3;
    
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
            if (ES2.Exists("scene6"))
            {
                if (ES2.Load<bool>("scene6"))
                {
                    Debug.Log(ES2.Load<bool>("scene6"));
                    CanvasCube3.SetActive(true);
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        CanvasCube3.SetActive(false);
    }
}