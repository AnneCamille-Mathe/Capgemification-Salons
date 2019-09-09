using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoBackScript : MonoBehaviour
{
    //variables
    public string levelToLoad;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Load()
    {
        levelToLoad = ES2.Load<string>("savedScene");
        SceneManager.LoadScene(levelToLoad);
    }
}
