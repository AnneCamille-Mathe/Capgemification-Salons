﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScriptValorissimo : MonoBehaviour
{
    //Variables
    public int somme = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("CanvasSomme/Panel/Text").GetComponent<Text>().text = "Somme : " + somme;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
