﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.SceneManagement;

public class ButtonCube1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClic()
    {
        //TODO - Save position
        int nbScenes = GameObject.Find("Manager").GetComponent<ManagerLevel1Script>().sceneCount;
        if (4 < nbScenes)
        {
            string[] scenes = new String[nbScenes];
            scenes = GameObject.Find("Manager").GetComponent<ManagerLevel1Script>().scenes;
            SceneManager.LoadScene(scenes[4]);
        }
    }
}