using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    //Initialisationd des variables
    public float TimeToLoadMenu = 3f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        //Si la scène est chargée, on lance la coroutine
        StartCoroutine(LoadMenu());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator LoadMenu()
    {
        //Au bout de 3 secondes, on lance la scène Menu
        yield return  new  WaitForSeconds(this.TimeToLoadMenu);
        SceneManager.LoadScene("Menu");
    }
}
