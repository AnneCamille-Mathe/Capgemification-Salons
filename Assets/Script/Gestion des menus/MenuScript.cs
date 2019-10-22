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
        //L'application vient d'être lancée, on l'identifie grâce à un marqueur égal à 1
        //On pourra ainsi supprimer les sauvegardes
        this.marqueur = 1;
        ES2.Save(this.marqueur, "marqueur");
        //Count est à 0, aucun mini jeu n'a encore été lancé
        count = 0;
        ES2.Save(count, "count");
        //On lance le coeur du jeu
        SceneManager.LoadScene(1);
    }
}
