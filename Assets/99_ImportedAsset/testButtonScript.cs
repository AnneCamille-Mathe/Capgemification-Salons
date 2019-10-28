using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testButtonScript : MonoBehaviour
{ 
    //Variables
    public GameObject Text;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onCLic()
    {
        this.Text.SetActive(true);
    }
}
