using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchScene0 : MonoBehaviour
{
    //Variables
    public GameObject CanvasCube;
    public GameObject button;
    public GameObject Pto0;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //On regarde si l'utilisateur entre dans la zone
    private void OnTriggerEnter(Collider other)
    {
        //On affiche le bouton pour lancer le mini jeu correspondant si le chemin y menant est activé
        if (other.gameObject.tag == "Player")
        {
            if (ES2.Exists("scene3"))
            {
                if (ES2.Load<bool>("scene3"))
                {
                    if(Pto0.activeSelf){
                        CanvasCube.SetActive(true);
                        button.SetActive(true);
                    }
                }
            }
        }
    }

    //on efface le bouton de lancement si le joueur s'en va de la zone
    private void OnTriggerExit(Collider other)
    {
        CanvasCube.SetActive(false);
    }
}

