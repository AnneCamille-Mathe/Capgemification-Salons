using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchScene6 : MonoBehaviour
{
    //Variables
    public GameObject CanvasCube6;
    public GameObject button;
    public GameObject C5to6;
            
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
            if (ES2.Exists("scene9"))
            {
                if (ES2.Load<bool>("scene9"))
                {
                    if(C5to6.activeSelf){
                        CanvasCube6.SetActive(true);
                        button.SetActive(true);
                    }
                }
            }
        }
    }
        
    //on efface le bouton de lancement si le joueur s'en va de la zone
    private void OnTriggerExit(Collider other)
    {
        CanvasCube6.SetActive(false);
    }
}