using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchMaisonFamille : MonoBehaviour
{
    //Variables
    public GameObject PanelMaison2;
    public GameObject PanelMaison3;
    public GameObject PanelMaison1;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        PanelMaison2.SetActive(false);
        PanelMaison3.SetActive(false);
        PanelMaison1.SetActive(true);
    }
}
