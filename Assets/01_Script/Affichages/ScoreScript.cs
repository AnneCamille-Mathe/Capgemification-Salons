///////////////////////////////////////////////////////////////////////////////////
/////////////////// Réalisé le 10/09/2019 -- MATHE ANNE CAMILLE ///////////////////
///////////////////////////////////////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    //VARIABLES
    //score
    public float Score = 0;
    //texte associé au score
    public Text Score_Info;
    
    // Start is called before the first frame update
    void Start()
    {
        //On affiche le score à 0
        this.Score_Info.text = "Score : " + this.Score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    //Si l'utilisateur rencontre notre zone de Spawn (= il est tombé)
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //on retranche 3 points au score
            this.Score -= 3;
            this.Score_Info.text = "Score : " + this.Score;
        }
    }
}
