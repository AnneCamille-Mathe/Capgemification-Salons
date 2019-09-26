///////////////////////////////////////////////////////////////////////////////////
/////////////////// Réalisé le 10/09/2019 -- MATHE ANNE CAMILLE ///////////////////
///////////////////////////////////////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    //Variables
    public float temps = 400;
    public Text timerText;
    public int minutes;
    public int secondes;
    
    // Start is called before the first frame update
    void Start()
    {
        if (this.temps > 0)
        {
            //On affiche une première fois le temps que l'on a décidé
            this.minutes = Mathf.FloorToInt(this.temps / 60f);
            this.secondes = Mathf.RoundToInt(this.temps % 59f);
            this.timerText.text = minutes + ":" + secondes;

            //Chaque seconde on appelle notre fonction
            InvokeRepeating("temps1s", 1f, 1f);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    void temps1s()
    {
        this.temps -= 1;
        this.minutes = Mathf.FloorToInt(this.temps / 60f);
        this.secondes = Mathf.RoundToInt(this.temps % 59f);
        
        //Pour un affichage plus joli
        if (this.secondes < 10)
        {
            this.timerText.text = (this.minutes + ":0" + this.secondes);  
        }

        else if (this.minutes < 10)
        {
            this.timerText.text = ("0" + this.minutes + ":" + this.secondes);  
        }
        else if (this.minutes < 10 && this.secondes < 10)
        {
            this.timerText.text = ("0" + this.minutes + ":0" + this.secondes);  
        }
        else
        {
            this.timerText.text = (this.minutes + ":" + this.secondes);
        }

        //On charge la scène finale quand le temps est fini
        if (temps == 0)
        {
            this.timerText.text = ("TIME OVER");
            SceneManager.LoadScene("GameOver");
        }
    }
}
