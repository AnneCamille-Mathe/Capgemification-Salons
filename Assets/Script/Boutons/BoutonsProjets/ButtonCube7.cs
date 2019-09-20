using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.SceneManagement;

public class ButtonCube7 : MonoBehaviour
{
    //Variables
    private int nbScenes;
    private String LevelToLoad;
    
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
        if (ES2.Exists("sceneACharger10"))
        {
            LevelToLoad = ES2.Load<string>("sceneACharger10");
            SceneManager.LoadScene(LevelToLoad); }

    }
}