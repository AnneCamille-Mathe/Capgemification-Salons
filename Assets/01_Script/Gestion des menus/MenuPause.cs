using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPause : MonoBehaviour
{
    //Variables
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public  bool  testBug;
  
    
    // Start is called before the first frame update
    void Start()
    {
        //Variable implémentée pour éviter les "allumer / éteindre" intempestifs qui peuvent arriver
        this.testBug = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Si le canvas timer est allumé (le jeu est lancé, les choix faits et le synopsis lu)
        if (GameObject.Find("Canvas_Timer") != null)
        {
            //Si l'utilisateur a appuyé sur le bouton pause
            //TestBug modifié par d'autres scripts
            if (GameObject.Find("Canvas_Timer/Panel/Button Pause").GetComponent<PauseButton>().Pressed
            && testBug)
            {
                if (GameIsPaused)
                {
                    Resume();
                }
                else
                {
                    Pause();
                }

                testBug = false;
            }
        }

    }

    public void Resume()
    {
        //On relance le jeu (on rétablit le temps)
        this.pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;        
    }

    public void Pause()
    {
        //On met en pause le temps de Unity
        this.pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        //On relance le temps de Unity et on lance la scène du menu
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        //On quitte l'application (non testable depuis la console Unity)
        Application.Quit();
    }

    

}
