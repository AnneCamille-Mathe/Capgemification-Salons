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
    private bool scene3;
    private bool scene4;
    private bool scene5;
    private bool scene6;
    private bool scene7;
    private bool scene8;
    private bool scene9;
    private bool scene10;
    
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
                if (!ES2.Exists("count"))
                {
                    this.AffichagePremiereFleche();
                }
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
                this.P4to5.SetActive(true);
                break;
            
            case 9 :
                this.P4to5.SetActive(true);
                this.P5to6.SetActive(true);
                break;
            
            case 10 :
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
        //Chargement des valeurs des scènes
        LoadValueScenes();

        if (ES2.Exists("numScenes"))
        {
            numScenes = ES2.LoadList<int>("numScenes");
            int range = ES2.Load<int>("count");
            
            if (numScenes.Count -1 >= range)
            {
                switch (ES2.Load<int>("count"))
                 {
                     //TODO - Check if function "effacement()" is necessary
                     case 1 :

                        if (scene3)
                        {
                            if (scene4)
                            {
                                chemin1to2();
                            }
                            else if (scene5)
                            {
                                chemin1to3();
                            }
                            else if (scene6)
                            {
                                chemin1to4();
                            }
                            else if (scene7)
                            {
                                chemin1to5();
                            }
                            else if (scene8)
                            {
                                chemin1to6();
                            }
                            else if (scene9)
                            {
                                chemin1to7();
                            }
                            else if (scene10)
                            {
                                chemin1to8();
                            }
 
                        }
                        else if (scene4)
                        {
                            if (scene5)
                            {
                                chemin2to3();
                            }
                            else if (scene6)
                            {
                                chemin2to4();
                            }
                            else if (scene7)
                            {
                                chemin2to5();
                            }
                            else if (scene8)
                            {
                                chemin2to6();
                            }
                            else if (scene9)
                            {
                                chemin2to7();
                            }
                            else if (scene10)
                            {
                                chemin2to8();
                            }
                        }
                        else if (scene5)
                        {
                            if (scene6)
                            {
                                chemin3to4();
                            }
                            else if (scene7)
                            {
                                chemin3to5();
                            }
                            else if (scene8)
                            {
                                chemin3to6();
                            }
                            else if (scene9)
                            {
                                chemin3to7();
                            }
                            else if (scene10)
                            {
                                chemin3to8();
                            }

                        }
                        else if (scene6)
                        {
                            if (scene7)
                            {
                                chemin4to5();
                            }
                            else if (scene8)
                            {
                                chemin4to6();
                            }
                            else if (scene9)
                            {
                                chemin4to7();
                            }
                            else if (scene10)
                            {
                                chemin4to8();
                            }

                        }
                        else if (scene7)
                        {
                            if (scene8)
                            {
                                chemin5to6();
                            }
                            else if (scene9)
                            {
                                chemin5to7();
                            }
                            else if (scene10)
                            {
                                chemin5to8();
                            }
                        }
                        else if (scene8)
                        {
                            if (scene9)
                            {
                                chemin6to7();
                            }
                            else if (scene10)
                            {
                                chemin6to8();
                            }

                        }
                        //TODO - Check 7 to 8
                        
                         break;
            
                    case 2 :
                        //TODO - Ajouter les cas
                        if (scene4)
                        {
                            
                        }
                        else if (scene5)
                        {
                            
                        }
                        else if (scene6)
                        {
                            
                        }
                        else if (scene7)
                        {
                            
                        }
                        else if (scene8)
                        {
                            
                        }
                        else if (scene9)
                        {
                            
                        }
                        else if (scene10)
                        {
                            
                        }
                        break;
            
                    case 3 :
                        //TODO - Check active scenes;
                        if (scene5)
                        {
                            
                        }
                        else if (scene6)
                        {
                            
                        }
                        else if (scene7)
                        {
                            
                        }
                        else if (scene8)
                        {
                            
                        }
                        else if (scene9)
                        {
                            
                        }
                        else if (scene10)
                        {
                            
                        }
                        break;
            
                    case 4 :
                        //TODO - Check active scenes;
                        if (scene6)
                        {
                            
                        }
                        else if (scene7)
                        {
                            
                        }
                        else if (scene8)
                        {
                            
                        }
                        else if (scene9)
                        {
                            
                        }
                        else if (scene10)
                        {
                            
                        }
                        break;
            
                    case 5 :
                        //TODO - Check active scenes;
                        if (scene7)
                        {
                            
                        }
                        else if (scene8)
                        {
                            
                        }
                        else if (scene9)
                        {
                            
                        }
                        else if (scene10)
                        {
                            
                        }
                        break;
            
                    case 6 :
                        //TODO - Check active scenes;
                        if (scene8)
                        {
                            
                        }
                        else if (scene9)
                        {
                            
                        }
                        else if (scene10)
                        {
                            
                        }
                        break;
            
                    case 7 :
                        //TODO - Check active scenes;
                        if (scene9)
                        {
                            
                        }
                        else if (scene10)
                        {
                            
                        }
                        break;
            
                    default: 
                        break;
                }
            }
            
        }
    }
    
}

    void chemin1to2()
    {
        this.P0to1.SetActive(true);
    }
    
    void chemin1to3(){
        chemin1to2();
        this.P1to2.SetActive(true);
    }
        
    void chemin1to4(){
        chemin1to3();
        this.P2to3.SetActive(true);
    }
    
    void chemin1to5(){
        chemin1to4();
        this.P3to4.SetActive(true);
    }
    
    void chemin1to6(){
        chemin1to5();
        this.P4to5.SetActive(true);
    }
    
    void chemin1to7(){
        chemin1to6();
        this.P5to6.SetActive(true);
    }

    void chemin1to8()
    {
        chemin1to7();
        this.P6to7.SetActive(true);
    }

    void chemin2to3()
    {
        this.P1to2.SetActive(true);
    }
            
    void chemin2to4(){
        chemin2to3();
        this.P2to3.SetActive(true);
    }
        
    void chemin2to5(){
        chemin2to4();
        this.P3to4.SetActive(true);
    }
        
    void chemin2to6(){
        chemin2to5();
        this.P4to5.SetActive(true);
    }
        
    void chemin2to7(){
        chemin2to6();
        this.P5to6.SetActive(true);
    }
    
    void chemin2to8(){
        chemin2to7();
        this.P6to7.SetActive(true);
    }
    
    void chemin3to4(){
        this.P2to3.SetActive(true);
    }
        
    void chemin3to5(){
        this.chemin3to4();
        this.P3to4.SetActive(true);
    }
        
    void chemin3to6(){
        chemin3to5();
        this.P4to5.SetActive(true);
    }
        
    void chemin3to7(){
        chemin3to6();
        this.P5to6.SetActive(true);
    }
    
    void chemin3to8(){
        chemin3to7();
        this.P6to7.SetActive(true);
    }
    
    void chemin4to5(){
        this.P3to4.SetActive(true);
    }
        
    void chemin4to6(){
        chemin4to5();
        this.P4to5.SetActive(true);
    }
        
    void chemin4to7(){
        chemin4to6();
        this.P5to6.SetActive(true);
    }
    
    void chemin4to8(){
        chemin4to7();
        this.P6to7.SetActive(true);
    }
    void chemin5to6(){
        this.P4to5.SetActive(true);
    }
        
    void chemin5to7(){
        this.chemin5to6();
        this.P5to6.SetActive(true);
    }
    
    void chemin5to8(){
        chemin5to7();
        this.P6to7.SetActive(true);
    }
        
    void chemin6to7()
    {
        this.P5to6.SetActive(true);
    }
    
    void chemin6to8(){
        chemin6to7();
        this.P6to7.SetActive(true);

    }
    
    //TODO - Check if nécessaire
    /*
    void chemin7to8()
    {
        
    }
    */
    void LoadValueScenes()
    {
        if (ES2.Exists("scene3"))
        {
            scene3 = ES2.Load<bool>("scene3");
        }
        if (ES2.Exists("scene4"))
        {
            scene4 = ES2.Load<bool>("scene4");
        }
        if (ES2.Exists("scene5"))
        {
            scene5 = ES2.Load<bool>("scene5");
        }
        if (ES2.Exists("scene6"))
        {
            scene6 = ES2.Load<bool>("scene6");
        }
        if (ES2.Exists("scene7"))
        {
            scene7 = ES2.Load<bool>("scene7");
        }
        if (ES2.Exists("scene8"))
        {
            scene8 = ES2.Load<bool>("scene8");
        }
        if (ES2.Exists("scene9"))
        {
            scene9 = ES2.Load<bool>("scene9");
        }
        if (ES2.Exists("scene10"))
        {
            scene10 = ES2.Load<bool>("scene10");
        }
    }

    void effacement()
    {
    P0to1.SetActive(false);
    P1to2.SetActive(false);
    P2to3.SetActive(false);
    P3to4.SetActive(false);
    P4to5.SetActive(false);
    P5to6.SetActive(false);
    P6to7.SetActive(false);
    }
}
