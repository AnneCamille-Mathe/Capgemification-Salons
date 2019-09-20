using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchScene5 : MonoBehaviour
{
    //Variables
    public GameObject CanvasCube5;
    
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
            if (ES2.Exists("scene8"))
            {
                if (ES2.Load<bool>("scene8"))
                {
                    Debug.Log(ES2.Load<bool>("scene8"));
                    CanvasCube5.SetActive(true);
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        CanvasCube5.SetActive(false);
    }
}