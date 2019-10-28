using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanevasVictoireSEngager : MonoBehaviour
{
    //Variables
    public GameObject ImageScript;
    public GameObject ImageSite;
    public GameObject PanelText;
    public bool once = true;
    public GameObject buttonLoad;
    public GameObject CanevasControl;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //On exécute une seule fois la coroutine
        if (once)
        {
            StartCoroutine(affichage());
            once = false;
        }
    }

    IEnumerator affichage()
    {
        //On désactive le canvas avec les joystick
        CanevasControl.SetActive(false);
        //On affiche l'image du code pendant 0.5 secondes
        ImageScript.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        ImageScript.SetActive(false);
        //On affiche un visuel du site pendant 1 seconde
        ImageSite.SetActive(true);
        yield return new  WaitForSeconds(1f);
        ImageSite.SetActive(false);
        //On affiche la victoire et le bouton de retour
        PanelText.SetActive(true);
        buttonLoad.SetActive(true);
    }
}
