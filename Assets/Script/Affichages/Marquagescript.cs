using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.SceneManagement;

public class Marquagescript : MonoBehaviour
{
    //Variables
    public bool once;
    private string[] scenes;
    public  GameObject Pto0;
    public  GameObject P0to1;
    public  GameObject P1to2;
    public  GameObject P2to3;
    public  GameObject P3to4;
    public  GameObject P4to5;
    public  GameObject P5to6;
    public  GameObject P6to7;
    private int test;
    private List<int> numScenes;
    
    
    // Start is called before the first frame update
    void Start()
    {
        once = true;
    }

    // Update is called once per frame
    void Update()
    {
        //On récupère les scènes sélectionnées par l'utilisateur et on affiche le premier chemin
        this.getChoice();
        
        //On affiche les autres chemins 
        this.AffichageAutomatique();
    }

    void getChoice()
    {
        int place = 0;
        if(GameObject.Find("CanvasChoix/Button") != null && once){
            if(GameObject.Find("Manager").GetComponent<ManagerLevel1Script>().bouton){
                scenes =  GameObject.Find("CanvasChoix/Button").GetComponent<ButtonChoixScript>().valeurs;
                numScenes = new List<int>();
                for (int i = 0; i < scenes.Length; i++)
                {
                    if (scenes[i] != null)
                    {
                        if (i >= 3)
                        {
                            numScenes.Add(i);
                            place += 1;
                        }
                    }
                }
                ES2.Save(numScenes, "numScenes");
                //Affichage du flèchage au sol
                this.AffichagePremiereFleche();
                once = false;
            }
        }
    }
    
    
    void AffichagePremiereFleche()
    {
        switch (numScenes[0])
        {
            case 3 :
                this.Pto0.SetActive(true);
                break;
            
            case 4 :
                this.Pto0.SetActive(true);
                this.P0to1.SetActive(true);
                break;
            
            case 5 :
                this.P1to2.SetActive(true);
                break;
            
            case 6 :
                this.P1to2.SetActive(true);
                this.P2to3.SetActive(true);
                break;
            
            case 7 :
                this.P1to2.SetActive(true);
                this.P2to3.SetActive(true);
                this.P3to4.SetActive(true);
                break;
            
            case 8 :
                this.P1to2.SetActive(true);
                this.P2to3.SetActive(true);
                this.P3to4.SetActive(true);
                this.P4to5.SetActive(true);
                break;
            
            case 9 :
                this.P1to2.SetActive(true);
                this.P2to3.SetActive(true);
                this.P3to4.SetActive(true);
                this.P4to5.SetActive(true);
                this.P5to6.SetActive(true);
                break;
            
            case 10 :
                this.P1to2.SetActive(true);
                this.P2to3.SetActive(true);
                this.P3to4.SetActive(true);
                this.P4to5.SetActive(true);
                this.P5to6.SetActive(true);
                this.P6to7.SetActive(true);
                break;
            
            default: 
                break;
        }
    }

    void AffichageAutomatique()
    {
        //Affichage des suites
        if (ES2.Exists("count"))
        {
            if (ES2.Exists("numScenes"))
            {
                numScenes = ES2.LoadList<int>("numScenes");
                Debug.Log(numScenes[ES2.Load<int>("count")]);
                switch (numScenes[ES2.Load<int>("count")])
                {
                    case 3 :
                        this.Pto0.SetActive(true);
                        break;
            
                    case 4 :
                        this.Pto0.SetActive(true);
                        this.P0to1.SetActive(true);
                        break;
            
                    case 5 :
                        this.Pto0.SetActive(false);
                        this.P0to1.SetActive(true);
                        this.P1to2.SetActive(true);
                        break;
            
                    case 6 :
                        this.P1to2.SetActive(true);
                        this.P2to3.SetActive(true);
                        break;
            
                    case 7 :
                        this.P1to2.SetActive(true);
                        this.P2to3.SetActive(true);
                        this.P3to4.SetActive(true);
                        break;
            
                    case 8 :
                        this.P1to2.SetActive(true);
                        this.P2to3.SetActive(true);
                        this.P3to4.SetActive(true);
                        this.P4to5.SetActive(true);
                        break;
            
                    case 9 :
                        this.P1to2.SetActive(true);
                        this.P2to3.SetActive(true);
                        this.P3to4.SetActive(true);
                        this.P4to5.SetActive(true);
                        this.P5to6.SetActive(true);
                        break;
            
                    case 10 :
                        this.P1to2.SetActive(true);
                        this.P2to3.SetActive(true);
                        this.P3to4.SetActive(true);
                        this.P4to5.SetActive(true);
                        this.P5to6.SetActive(true);
                        this.P6to7.SetActive(true);
                        break;
            
                    default: 
                        break;
                }
            }
        }
        
    }
    
}
