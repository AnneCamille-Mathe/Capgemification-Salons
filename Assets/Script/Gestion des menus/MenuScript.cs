using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    //Variables
    public int marqueur;
    
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
        ES2.Save(SceneManager.GetActiveScene().name, "menu");
        SceneManager.LoadScene(1);
    }
}
