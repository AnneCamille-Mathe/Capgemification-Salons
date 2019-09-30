using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchMaisonColloc : MonoBehaviour
{
    //Variables
    public GameObject PanelMaison1;
    public GameObject PanelMaison2;
    public GameObject PanelMaison3;
    
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
        PanelMaison1.SetActive(false);
        PanelMaison2.SetActive(false);
        PanelMaison3.SetActive(true);
    }
}
