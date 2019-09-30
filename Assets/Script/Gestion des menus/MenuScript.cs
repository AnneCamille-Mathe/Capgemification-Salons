using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    //Variables
    public int marqueur;
    private int count;
    
    //Codage du bouton quitter
    public void Quitter ()
    {
        Application.Quit();
    }
    
    //Codage du bouton Jouer
    public void Jouer()
    {
        this.marqueur = 1;
        ES2.Save(this.marqueur, "marqueur");
        count = 0;
        ES2.Save(count, "count");
        SceneManager.LoadScene(1);
    }
}
