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
        StartCoroutine(LoadMenu());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator LoadMenu()
    {
        yield return  new  WaitForSeconds(this.TimeToLoadMenu);
        ES2.Save(SceneManager.GetActiveScene().name, "gameOver");
        SceneManager.LoadScene("Menu");
    }
}
