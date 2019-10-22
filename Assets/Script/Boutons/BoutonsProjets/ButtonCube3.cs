using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.SceneManagement;

public class ButtonCube3 : MonoBehaviour
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

    //Si l'utilisateur clique sur le bouton, on lance la scène correspondante
    public void onClic()
    {
        if (ES2.Exists("sceneACharger6"))
        {
            LevelToLoad = ES2.Load<string>("sceneACharger6");
            SceneManager.LoadScene(LevelToLoad); }

    }
}