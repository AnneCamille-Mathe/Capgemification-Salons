using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BoutonPersoContinue : MonoBehaviour
{
    //Variables
    public GameObject panelPerso;
    public GameObject perso;
    public GameObject PanelMaison3;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (panelPerso.activeSelf == true)
        {
            PanelMaison3.SetActive(false);
        }
    }

    public void onClic()
    {
        panelPerso.SetActive(false);
        perso.SetActive(false);
    }
}
