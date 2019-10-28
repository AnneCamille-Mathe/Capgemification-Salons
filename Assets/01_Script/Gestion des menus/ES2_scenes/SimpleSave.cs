using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;


public class SimpleSave : MonoBehaviour
{
    //Variables
    public GameObject player;
    public GameObject boutonJouer;
    public int marqueur;
    public GameObject CanevasSynopsis;
    public GameObject CanevasChoix;
    public Position positon;
    public int count;
    bool once;
        

    // Start is called before the first frame update
    void Start()
    {
        //on charge le marqueur grâce à l'ES2
        marqueur = GameObject.Find("Manager").GetComponent<ManagerLevel1Script>().marqueur;
        //Si le marqueur est à 1, l'application vient d'être lancée
        if (ES2.Load<int>("marqueur") == 1)
        {
            //On sauvegarde le nombre de mini jeux lancés (count) à 0
            count = 0;
            ES2.Save(count, "count");
        }
        //Si l'application ne vient pas d'être lancée
        if (ES2.Load<int>("marqueur") != 1)
        {
            //On n'affiche pas le synopsis ni le choix, et on récupère la sauvegarde des éléments
            this.CanevasSynopsis.SetActive(false);
            this.CanevasChoix.SetActive(false);
            Load();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    
    //Si l'utilisateur entre dans la zone de sauvegarde
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //on sauvegarde les valeurs
            once = true;
            ES2.Save(once, "bool");
            //Emplacement du joueur
            ES2.Save(player.transform.position, "position");
            ES2.Save(player.transform.rotation, "rotation");
            //Score
            float score = GameObject.Find("SpawnFPSController/Canvas_Score").GetComponent<ScoreScript>().Score;
            ES2.Save(score, "score");
            //temps
            float temps = GameObject.Find("Canvas_Timer").GetComponent<TimerScript>().temps;
            ES2.Save(temps, "temps");
            //nom de la scène (du coeur)
            ES2.Save(SceneManager.GetActiveScene().name, "savedScene");
            //On incrémente le marqueur (sécurité)
            this.marqueur += 1;
            ES2.Save(this.marqueur, "marqueur");

        }
    }

    public void Load()
    {
        //TODO - IMPLEMENTER LE SCORE
        
        //On incrémente le marqueur (sécurité)
        this.marqueur += 1;
        ES2.Save(this.marqueur, "marqueur");
        
        //on vérifie que l'on ne lance qu'une seule fois cette récupération sinon (à cause de +1)
        //le nombre de mini jeux lancés est faussé
        if (ES2.Load<bool>("bool"))
        {
            //on augmente le nombre de mini jeu lancé de 1 et on sauvegarde la valeur
            count = ES2.Load<int>("count");
            count += 1;
            ES2.Save(count, "count");
            //On repasse once à faux et on l'enregistre
            //il sera modifié lors du prochain lancement de jeu
            once = false;
            ES2.Save(once, "bool");
        }
        
        //on rétablie l'emplacement du joueur
        if (ES2.Exists("position"))
        {
            player.transform.position = ES2.Load<Vector3>("position");
        }
        if (ES2.Exists("rotation"))
        {
            player.transform.rotation = ES2.Load<Quaternion>("rotation");
        }
        
        /*
        if (ES2.Exists("rotation"))
        {
            GameObject.Find("Manager").GetComponent<ManagerLevel1Script>().marqueur = ES2.Load<int>("marqueur");
        }
        */
        
        //on rétablie le score
        if (ES2.Exists("score"))
        {
            GameObject.Find("SpawnFPSController/Canvas_Score").GetComponent<ScoreScript>().Score = ES2.Load<float>("score");
        }

        //on rétablie le temps
        if (ES2.Exists("temps"))
        {
            GameObject.Find("Canvas_Timer").GetComponent<TimerScript>().temps = ES2.Load<float>("temps");
        }

    }

    //Si l'utilisateur sort de la zone, le bouton est désactivé
    //Il ne peut lancer le jeu que dans la zone
    private void OnTriggerExit(Collider other)
    {
        this.boutonJouer.SetActive(false);
    }
}
