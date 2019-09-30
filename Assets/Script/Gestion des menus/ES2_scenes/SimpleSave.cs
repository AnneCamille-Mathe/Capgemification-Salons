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
        marqueur = GameObject.Find("Manager").GetComponent<ManagerLevel1Script>().marqueur;
        if (ES2.Load<int>("marqueur") == 1)
        {
            count = 0;
            ES2.Save(count, "count");
        }
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
            once = true;
            ES2.Save(once, "bool");
            ES2.Save(player.transform.position, "position");
            ES2.Save(player.transform.rotation, "rotation");
            float score = GameObject.Find("SpawnFPSController/Canvas_Score").GetComponent<ScoreScript>().Score;
            ES2.Save(score, "score");
            float temps = GameObject.Find("Canvas_Timer").GetComponent<TimerScript>().temps;
            ES2.Save(temps, "temps");
            ES2.Save(SceneManager.GetActiveScene().name, "savedScene");
            
            this.marqueur += 1;
            ES2.Save(this.marqueur, "marqueur");

        }
    }

    public void Load()
    {
        this.marqueur += 1;
        ES2.Save(this.marqueur, "marqueur");
        
        if (ES2.Load<bool>("bool"))
        {
            count = ES2.Load<int>("count");
            count += 1;
            ES2.Save(count, "count");
            Debug.Log("apres : " + ES2.Load<int>("count"));
            once = false;
            ES2.Save(once, "bool");
        }
        

        
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
        
        if (ES2.Exists("score"))
        {
            GameObject.Find("SpawnFPSController/Canvas_Score").GetComponent<ScoreScript>().Score = ES2.Load<float>("score");
        }

        if (ES2.Exists("temps"))
        {
            GameObject.Find("Canvas_Timer").GetComponent<TimerScript>().temps = ES2.Load<float>("temps");
        }

    }

    private void OnTriggerExit(Collider other)
    {
        this.boutonJouer.SetActive(false);
    }
}
