using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearKey : MonoBehaviour
{
    //Variables
    bool trouve;
    public GameObject CanvasClefTrouvee;
    
    // Start is called before the first frame update
    void Start()
    {
        //Si la clef a été trouvée lors d'une sauvegarde ultérieure, la clef ne s'affiche pas
        if(ES2.Exists("trouve")){
           Destroy(gameObject);
        }    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Si l'utilisateur entre dans la zone de la clef on lance la coroutine
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(affichageMessage());
        }
    }

    IEnumerator affichageMessage()
    {
        //On affiche le message de réussite pendant 1.5 secondes
        this.CanvasClefTrouvee.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        this.CanvasClefTrouvee.SetActive(false);
        //On désactive l'objet
        gameObject.SetActive(false);
        //On enregistre grâce à l'ES2 la réussite
        trouve = true;
        ES2.Save(trouve, "trouve");
    }
}
