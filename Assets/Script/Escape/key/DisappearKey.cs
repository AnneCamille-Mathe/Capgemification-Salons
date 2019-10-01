using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearKey : MonoBehaviour
{
    //Variables
    bool trouve;
    
    // Start is called before the first frame update
    void Start()
    {
       if(ES2.Exists("trouve")){
           Destroy(gameObject);
       }    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
            trouve = true;
            ES2.Save(trouve, "trouve");
        }
    }
}
