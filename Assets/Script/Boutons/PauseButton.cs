using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class PauseButton : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    //variables
    [HideInInspector]
    public bool Pressed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    //On regarde si l'utilisateur a cliqué sur le bouton, si oui on passe la variable à true
    public void OnPointerDown(PointerEventData eventData)
    {
        //on évite un petit soucis qui faisait "allumer et éteindre" le Canvas
        GameObject.Find("CanvasPause").GetComponent<MenuPause>().testBug = true;
        Pressed = true;
    }

    //On regarde si l'utilisateur a relaché sur le bouton, si oui on repasse la variable à false
    public void OnPointerUp(PointerEventData eventData)
    {
        Pressed = false;
    }
    
}
