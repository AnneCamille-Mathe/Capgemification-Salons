using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerHermesScript : MonoBehaviour
{
    //Variables
    public GameObject horse1;
    public GameObject horse2;
    public GameObject horse3;
    public GameObject CanevasFin;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (horse1 == null && horse2 == null && horse3 == null)
        {
            CanevasFin.SetActive(true);
        }
    }
}
