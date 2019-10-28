///////////////////////////////////////////////////////////////////////////////////
/////////////////// Réalisé le 10/09/2019 -- MATHE ANNE CAMILLE ///////////////////
///////////////////////////////////////////////////////////////////////////////////


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValiderButton : MonoBehaviour
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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Si l'utilisateur clique sur le bouton
    public void onClic()
    {
        //On affiche le synopsis après validation des choix
        this.CanvasScore.SetActive(false);
        this.CanvasTimer.SetActive(false);
        this.CanvasJoystick.SetActive(false);
        this.CanvasChoix.SetActive(false);
        this.CanvasSynopsis.SetActive(true);

    }
}
