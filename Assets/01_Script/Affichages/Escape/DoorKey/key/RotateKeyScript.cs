using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateKeyScript : MonoBehaviour
{
    //Variables
    public int speed = 300;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //On fait tourner la clef
        transform.Rotate(Vector3.up * this.speed * Time.deltaTime);
    }
}
