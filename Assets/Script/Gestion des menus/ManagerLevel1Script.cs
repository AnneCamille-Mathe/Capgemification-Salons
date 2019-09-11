///////////////////////////////////////////////////////////////////////////////////
/////////////////// Réalisé le 10/09/2019 -- MATHE ANNE CAMILLE ///////////////////
///////////////////////////////////////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerLevel1Script : MonoBehaviour
{
    //Variables
    public GameObject CanvasScore;
    public GameObject CanvasTimer;
    public GameObject CanvasJoystick;
    public GameObject CanvasSynopsis;
    public GameObject CanvasChoix;

    // Start is called before the first frame update
    void Start()
    {
        //On efface les sauvegardes ssi le jeu vient d'être lancé
        if (ES2.Load<int>("marqueur") == 1)
        {
            if (ES2.Exists("Hermes"))
            {
                ES2.Delete("Hermes");
            }
            
            if (ES2.Exists("Valorissimo"))
            {
                ES2.Delete("Valorissimo");
            }

            if (ES2.Exists("SEngager"))
            {
                ES2.Delete("SEngager");
            }
            ES2.Save(SceneManager.GetActiveScene().name, "level1");

        }
        
        //On prépare le premier visuel
        this.CanvasScore.SetActive(false);
        this.CanvasTimer.SetActive(false);
        this.CanvasJoystick.SetActive(false);
        this.CanvasSynopsis.SetActive(false);
        this.CanvasChoix.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
