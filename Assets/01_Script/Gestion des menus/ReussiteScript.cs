using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReussiteScript : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Si le canvas réussite est lancé, ona affiche un message puis on relance le menu
        if (gameObject.activeSelf)
        {
            StartCoroutine(LoadMenu());
        }
    }
    
    IEnumerator LoadMenu()
    {
        //On laisse affiché la réussite puis on lance le menu au bout de 3 secondes
        yield return  new  WaitForSeconds(3f);
        SceneManager.LoadScene("Menu");
    }
}
