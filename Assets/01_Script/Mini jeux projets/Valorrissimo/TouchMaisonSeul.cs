using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchMaisonSeul : MonoBehaviour
{
    //Variables
    public GameObject PanelMaison1;
    public GameObject PanelMaison3;
    public GameObject PanelMaison2;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    //Si l'utilisateur clique sur la maison on affiche son texte et on désactive celui des autres
    private void OnMouseDown()
    {
        PanelMaison1.SetActive(false);
        PanelMaison3.SetActive(false);
        PanelMaison2.SetActive(true);
    }
}
