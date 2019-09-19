using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchScene0 : MonoBehaviour
{
    //Variables
    public GameObject CanvasCube;
    
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
            if (ES2.Exists("scene3"))
            {
                if (ES2.Load<bool>("scene3"))
                {
                    Debug.Log(ES2.Load<bool>("scene3"));
                    CanvasCube.SetActive(true);
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        CanvasCube.SetActive(false);
    }
}

