using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horsesScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Si l'utilisateur clique sur l'objet, il est détruit
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
    
}
