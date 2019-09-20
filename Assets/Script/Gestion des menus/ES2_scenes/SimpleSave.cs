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
    //public GameObject ZoneSpawn;
    //public GameObject MainCamera;
    public int marqueur;
    public GameObject CanevasSynopsis;
    public GameObject CanevasChoix;

    public Position positon;
    
    //public GameObject CanvasJoystick;
        

    // Start is called before the first frame update
    void Start()
    {
        marqueur = GameObject.Find("Manager").GetComponent<ManagerLevel1Script>().marqueur;
        if (ES2.Load<int>("marqueur") != 1)
        {
            this.CanevasSynopsis.SetActive(false);
            this.CanevasChoix.SetActive(false);
            Load();
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ES2.Save(player.transform.position, "position");
            ES2.Save(player.transform.rotation, "rotation");
            //ES2.Save(this.ZoneSpawn.GetComponent<LifeScript>().Score, "score");
            
            //TODO - Calcul du temps
            //ES2.Save(this.MainCamera.GetComponent<Timer>().minutes, "minutes");
            //ES2.Save(this.MainCamera.GetComponent<Timer>().secondes, "secondes");
            //float temps = ES2.Load<int>("minutes") + ES2.Load<int>("secondes");
            //ES2.Save(temps, "temps");
            
            ES2.Save(SceneManager.GetActiveScene().name, "savedScene");
            
            //Si pas début de jeu = pas de panel explicatif à afficher
            this.marqueur += 1;
            ES2.Save(this.marqueur, "marqueur");

        }
    }
    
    public void Load()
    {   
        Debug.Log(marqueur);
        this.marqueur += 1;
        ES2.Save(this.marqueur, "marqueur");
        
        if (ES2.Exists("position"))
        {
            player.transform.position = ES2.Load<Vector3>("position");
        }
        if (ES2.Exists("rotation"))
        {
            player.transform.rotation = ES2.Load<Quaternion>("rotation");
        }
        
        if (ES2.Exists("rotation"))
        {
            GameObject.Find("Manager").GetComponent<ManagerLevel1Script>().marqueur = ES2.Load<int>("marqueur");
        }
        //this.ZoneSpawn.GetComponent<LifeScript>().Score = ES2.Load<float>("score");
        //Calcul du temps
        //this.MainCamera.GetComponent<Timer>().minutes = ES2.Load<int>("minutes");
        //this.MainCamera.GetComponent<Timer>().secondes = ES2.Load<int>("secondes");
        //this.MainCamera.GetComponent<Timer>().temps = ES2.Load<int>("temps");
    }

    private void OnTriggerExit(Collider other)
    {
        this.boutonJouer.SetActive(false);
    }
}
