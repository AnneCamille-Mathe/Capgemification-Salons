///////////////////////////////////////////////////////////////////////////////////
/////////////////// Réalisé le 10/09/2019 -- MATHE ANNE CAMILLE ///////////////////
///////////////////////////////////////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerLevel1Script : MonoBehaviour
{
    //Variables
    public GameObject CanvasScore;
    public GameObject CanvasTimer;
    public GameObject CanvasJoystick;
    public GameObject CanvasSynopsis;
    //public GameObject CanvasChoix;
    public int sceneCount;
    public bool premierAffichage;
    public string[] scenes;
    public bool[] toggles;
    
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
            
            //On supprime les sauvegardes des scènes précédentes
            sceneCount = UnityEngine.SceneManagement.SceneManager.sceneCountInBuildSettings;
            for (int i = 1; i < sceneCount; i++)
            {
                if (ES2.Exists("scene" + i))
                {
                    ES2.Delete("scene" + i);
                }
            }
        
            //On regarde les scènes dans les buildSettings
            this.GetScenes();
        
            //On créé le nombre de Toggle en fonction du nombre de scène en plus de notre scène principale
            premierAffichage = true;

        }
        
        //On prépare le premier visuel
        this.CanvasScore.SetActive(false);
        this.CanvasTimer.SetActive(false);
        this.CanvasJoystick.SetActive(false);
        this.CanvasSynopsis.SetActive(false);
        //this.CanvasChoix.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    
    void GetScenes()
    {
        scenes = new string[sceneCount];
        toggles = new bool[sceneCount];
        
        for( int i = 0; i < sceneCount; i++ )
        {
            scenes[i] = System.IO.Path.GetFileNameWithoutExtension( UnityEngine.SceneManagement.SceneUtility.GetScenePathByBuildIndex( i ) );
            toggles[i] = false;
        }

    }

    void OnGUI()
    {
        //La fonction OnGui étant appelée en continu, on ne veut pas que les affichages / enregistrement soient
        //réalisés plusieurs fois, on utilise donc un booléen
        if (premierAffichage)
        {
            int placement = 500;
            for( int i = 0; i < sceneCount; i++ )
            {
                if (scenes[i] != "GameOver" && scenes[i] != "Menu" && scenes[i] != "Level1")
                {
                    GUIStyle myStyle = new GUIStyle();
                    myStyle.fontSize = 80;
                    myStyle.normal.textColor = Color.white;
                    toggles[i] = GUI.Toggle(new Rect(340, placement, 600, 100), toggles[i], " " + scenes[i], myStyle);
                    toggles[i] = GUI.Toggle(new Rect(300, placement+50, 600, 100), toggles[i], "");
                    if (toggles[i])
                    {
                        myStyle.normal.textColor = Color.gray;
                        toggles[i] = GUI.Toggle(new Rect(340, placement, 600, 100), toggles[i], " " + scenes[i], myStyle);
                    }
                    placement += 150;
                }
            }
        }
    }
}
