using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchScene6 : MonoBehaviour
{
    //Variables
    public GameObject CanvasCube6;
    
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
            if (ES2.Exists("scene9"))
            {
                if (ES2.Load<bool>("scene9"))
                {
                    Debug.Log(ES2.Load<bool>("scene9"));
                    CanvasCube6.SetActive(true);
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        CanvasCube6.SetActive(false);
    }
}