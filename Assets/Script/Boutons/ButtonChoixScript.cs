﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonChoixScript : MonoBehaviour
{
    //Variables
    public GameObject CanvasChoix;

    public GameObject CanvasSynopsis;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void onClic(){
        //On enregistre les valeurs des toggles grâce à l'ES2
        bool [] toggles = GameObject.Find("Manager").GetComponent<ManagerLevel1Script>().toggles;
        for (int i = toggles.Length -1 ; i >2  ; i--)
        {
            ES2.Save(toggles[i], "scene" + i);
        }
        StartCoroutine(lancement());
    }

    IEnumerator lancement()
    {
        yield return new WaitForSeconds(0.5f);
        GameObject.Find("Manager").GetComponent<ManagerLevel1Script>().premierAffichage = false;
        CanvasChoix.SetActive(false);
        CanvasSynopsis.SetActive(true);
    }
}