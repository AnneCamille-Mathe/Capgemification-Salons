using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerSEngagerScript : MonoBehaviour
{
    //Variables
    public GameObject CanevasMission;
    public GameObject enemie1;
    public GameObject enemie2;
    public GameObject enemie3;
    public GameObject CanevasVictoire;
    
    // Start is called before the first frame update
    void Start()
    {
        //On affiche la mission au lancement du jeu
        this.CanevasMission.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        //Si tous les ennemis sont détruits, on affiche le canevas de victoire
        if (enemie1 == null && enemie2 == null && enemie3 == null)
        {
            CanevasVictoire.SetActive(true);
        }
    }
}
