using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchScene5 : MonoBehaviour
{
    //Variables
    public GameObject CanvasCube5;
    public GameObject button;
    public GameObject C4to5;
            
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
                    if(C4to5.activeSelf){
                        CanvasCube5.SetActive(true);
                        button.SetActive(true);
                    }
                }
            }
        }
    }
        
    private void OnTriggerExit(Collider other)
    {
        CanvasCube5.SetActive(false);
    }
}