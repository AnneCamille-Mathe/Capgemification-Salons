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
        this.testBug = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Canvas_Timer") != null)
        {
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
        this.pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;        
    }

    public void Pause()
    {
        this.pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    

}
