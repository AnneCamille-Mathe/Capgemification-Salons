using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchScene3 : MonoBehaviour
{
    //Variables
    public GameObject CanvasCube3;
    public GameObject button;
    public GameObject C2to3;
            
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
        if (other.gameObject.tag == "Player")
        {
            //On affiche le bouton pour lancer le mini jeu correspondant si le chemin y menant est activé
            if (ES2.Exists("scene6")) 
            { 
                if (ES2.Load<bool>("scene6")) 
                { 
                    if(C2to3.activeSelf){
                        CanvasCube3.SetActive(true);
                        button.SetActive(true); 
                    } 
                }
            }
        }
    }
        
    //on efface le bouton de lancement si le joueur s'en va de la zone
    private void OnTriggerExit(Collider other)
    { 
        CanvasCube3.SetActive(false);
    }
}