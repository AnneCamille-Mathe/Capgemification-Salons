using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    //Variables
    public bool jeuLance;

    public int marqueur;
    
    //Codage du bouton quitter
    public void Quitter ()
    {
        this.jeuLance = false;
        ES2.Save(this.jeuLance, "jeuLance");
        Application.Quit();
    }
    
    //Codage du bouton Jouer
    public void Jouer()
    {
        this.marqueur = 1;
        ES2.Save(this.marqueur, "marqueur");
        this.jeuLance = true;
        ES2.Save(this.jeuLance, "jeuLance");
        SceneManager.LoadScene(1);
    }
}
