using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinDeJeu : MonoBehaviour
{
    //Variables
    private int countScenesActives;
    private int sceneACharger;
    public int sceneCount;
    public bool[] toggle;
    public bool once;
    public GameObject CanevasReussite;
    
    // Start is called before the first frame update
    void Start()
    {
        //On initialise les variables
        sceneACharger = 0;
        once = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (ES2.Exists("count"))
        {
            //on compte combien de scènes ont été activées
            countScenesActives = ES2.Load<int>("count");

            //On regarde le nombre de scènes à charger
            if (once)
            {
                if (ES2.Exists("scene3"))
                {
                    scenesAToggleTrue();
                }
            }
            
            //on déclanche la victoire si le joueur a accédé à tous les jeuxs
            if (countScenesActives > 0)
            {
                if (countScenesActives == sceneACharger)
                {
                    CanevasReussite.SetActive(true);
                }
            }
        }
    }

    
    void scenesAToggleTrue()
    {
        //on compte le nombre de scène dans les buildsSettings
        sceneCount = UnityEngine.SceneManagement.SceneManager.sceneCountInBuildSettings;
        //On enleve le menu, le coeur et le game Over
        sceneCount -= 3;
        toggle = new bool[sceneCount];

        //On enregistre les résultats du choix des Toggles
        for (int i = 0; i < sceneCount; i++)
        {
            //On regarde si au moins une scène a été chargée par l'ES2
            if (ES2.Exists("scene3"))
            {
                int compteur = i + 3;
                toggle[i] = ES2.Load<bool>("scene" + compteur);
            }
        }
        
        //On enregistre le nombre de scènes à true
        for (int i = 0; i < toggle.Length; i++)
        {
            if (toggle[i] == true)
            {
                sceneACharger += 1;
            }
        }
        //on ne veut pas que la fonction soit rappelée, on passe once à false
        once = false;
    }
    
}
