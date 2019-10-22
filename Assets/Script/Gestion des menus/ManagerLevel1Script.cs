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
    public GameObject CanvasChoix;
    public GameObject CanvasPause;
    public int sceneCount;
    public bool premierAffichage;
    public string[] scenes;
    public bool[] toggles;
    public int marqueur = 1;
    public bool bouton;
        
    // Start is called before the first frame update
    void Start()
    {
        bouton = false; 
        //Si le marqueur est à 1 --> c'est à dire que l'application vient juste d'être lancée
        if (ES2.Load<int>("marqueur") == 1){
            //On efface les sauvegardes ssi le jeu vient d'être lancé
            this.delete();
            
            //On regarde les scènes dans les buildSettings
            this.GetScenes();
                    
             //On créé le nombre de Toggle en fonction du nombre de scène en plus de notre scène principale
            premierAffichage = true;
                        
            //On incrémente le marqueur --> l'application a déjà été lancée, on ne refera pas ce qu'on a fait ici
            this.marqueur += 1;
            ES2.Save(this.marqueur, "marqueur");
                        
            //On prépare le premier visuel
            this.Affichage();
        }

        //L'application ne vient pas d'être lancée
        else
        {
            //On ne relance pas le premier affichage, on relance la scène comme l'utilisateur l'a quittée
            premierAffichage = false;
            this.CanvasScore.SetActive(true);
            this.CanvasJoystick.SetActive(true);
            this.CanvasTimer.SetActive(true);
            this.CanvasPause.SetActive(true);
            this.CanvasSynopsis.SetActive(false);
            this.CanvasChoix.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    void OnGUI()
    {
       
        //La fonction OnGui étant appelée en continu, on ne veut pas que les affichages / enregistrement soient
        //réalisés plusieurs fois, on utilise donc un booléen
        if (premierAffichage)
        {
            //On fixe l'endroit où les toggles apparaitront
            int placement = 300;
            
            //Pour chaque scène
            for( int i = 0; i < sceneCount; i++ )
            {
                //Si le nom est différent du gameOver, menu ou level 1 (on ne veut pas que l'utilisateur ait à les choisir
                //Il ne s'agit pas de mini jeux!
                if (scenes[i] != "GameOver" && scenes[i] != "Menu" && scenes[i] != "Level1")
                {
                    //On sauvegarde la scène à charger avec son numéro
                    ES2.Save(scenes[i], "sceneACharger" + i);
                    GUIStyle myStyle = new GUIStyle();
                    myStyle.fontSize = 80;
                    myStyle.normal.textColor = Color.white;
                    //On l'affiche avec le style définit ci dessus
                    toggles[i] = GUI.Toggle(new Rect(340, placement, 600, 100), toggles[i], " " + scenes[i], myStyle);
                    toggles[i] = GUI.Toggle(new Rect(300, placement+50, 600, 100), toggles[i], "");
                    //Si l'utilisateur sélectionne le toggle, on le redessine en gris pour marquer la sélection
                    if (toggles[i])
                    {
                        myStyle.normal.textColor = Color.gray;
                        toggles[i] = GUI.Toggle(new Rect(340, placement, 600, 100), toggles[i], " " + scenes[i], myStyle);
                    }
                    //On affichera le prochain toggle avec une différence de 150 pixels (pour éviter de les coller)
                    placement += 150;
                }
            }
        }
    }

    void delete()
    {
        //On supprime les sauvegardes de la partie précédente
        if (ES2.Exists("position"))
        {
            ES2.Delete("position");
        }
            
        if (ES2.Exists("rotation"))
        {
            ES2.Delete("rotation");
        }


        if (ES2.Exists("savedScene"))
        {
            ES2.Delete("savedScene");
        }
            
        if (ES2.Exists("score"))
        {
            ES2.Delete("score");
        }
            
        if (ES2.Exists("temps"))
        {
            ES2.Delete("temps");
        }
        
        if (ES2.Exists("bool"))
        {
            ES2.Delete("bool");
        }
        
        if (ES2.Exists("trouve"))
        {
             ES2.Delete("trouve");
        }
        
        if (ES2.Exists("code"))
        {
            ES2.Delete("code");
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
        
        
    }
    
    void GetScenes()
    {
        scenes = new string[sceneCount];
        toggles = new bool[sceneCount];
        
        for( int i = 0; i < sceneCount; i++ )
        {
            //On enregristre le nom de toutes les scènes
            scenes[i] = System.IO.Path.GetFileNameWithoutExtension( UnityEngine.SceneManagement.SceneUtility.GetScenePathByBuildIndex( i ) );
            //par défault on implémente les toggles à false, on changera leur valeur en fonction de leur sélection
            toggles[i] = false;
        }

    }

    void Affichage()
    {
        //On affiche notre canvas des choix uniquement
        this.CanvasScore.SetActive(false);
        this.CanvasTimer.SetActive(false);
        this.CanvasJoystick.SetActive(false);
        this.CanvasSynopsis.SetActive(false);
        this.CanvasPause.SetActive(true);
        this.CanvasChoix.SetActive(true);
    }


}
