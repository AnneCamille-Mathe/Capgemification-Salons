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
        //On désactive le panelMaison3 car non loin du bouton = activation par mégarde
        if (panelPerso.activeSelf == true)
        {
            PanelMaison3.SetActive(false);
        }
    }

    //Fonction appelée si l'utilisateur clique sur le bouton
    public void onClic()
    {
        //On désactive le personnage et son panel
        panelPerso.SetActive(false);
        perso.SetActive(false);
    }
}
