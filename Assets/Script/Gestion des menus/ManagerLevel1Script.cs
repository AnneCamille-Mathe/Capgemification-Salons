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
    public int marqueur = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(marqueur);
        
        //On efface les sauvegardes ssi le jeu vient d'être lancé
        if (ES2.Load<int>("marqueur") == 1)
        {
            //On supprime les sauvegardes des scènes précédentes
            if (ES2.Exists("position"))
            {
                ES2.Delete("position");
            }
            
            if (ES2.Exists("rotation"))
            {
                ES2.Delete("rotation");
            }
            
            if (ES2.Exists("minutes"))
            {
                ES2.Delete("minutes");
            }

            if (ES2.Exists("savedScene"))
            {
                ES2.Delete("savedScene");
            }
            
            if (ES2.Exists("score"))
            {
                ES2.Delete("score");
            }
            
            if (ES2.Exists("secondes"))
            {
                ES2.Delete("secondes");
            }

            sceneCount = UnityEngine.SceneManagement.SceneManager.sceneCountInBuildSettings;
            for (int i = 1; i < sceneCount; i++)
            {
                if (ES2.Exists("scene" + i))
                {
                    ES2.Delete("scene" + i);
                }
                
                if (ES2.Exists("sceneACharger" + i))
                {
                    ES2.Delete("sceneACharger" + i);
                }
            }
        
            //On regarde les scènes dans les buildSettings
            this.GetScenes();
        
            //On créé le nombre de Toggle en fonction du nombre de scène en plus de notre scène principale
            premierAffichage = true;
            
            this.marqueur += 1;
            ES2.Save(this.marqueur, "marqueur");
            
            //On prépare le premier visuel
            this.CanvasScore.SetActive(false);
            this.CanvasTimer.SetActive(false);
            this.CanvasJoystick.SetActive(false);
            this.CanvasSynopsis.SetActive(false);
            //this.CanvasChoix.SetActive(true);

        }

        else
        {
            premierAffichage = false;
            this.CanvasScore.SetActive(true);
            this.CanvasTimer.SetActive(true);
            this.CanvasJoystick.SetActive(true);
            this.CanvasSynopsis.SetActive(false);
        }
        
        

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
                    ES2.Save(scenes[i], "sceneACharger" + i);
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
