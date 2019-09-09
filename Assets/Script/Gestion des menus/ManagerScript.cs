using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerScript : MonoBehaviour
{
    //Variables
    public GameObject CanevasDebut;
    public GameObject CanevasChoix;
    public int marqueur = 1;

    // Start is called before the first frame update
    void Start()
    {/*
        if (ES2.Load<bool>("jeuLance") == true & ES2.Load<int>("marqueur") == 1)
        {
            if (ES2.Exists("position"))
            {
                ES2.Delete("position");
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

            this.marqueur += 1;
            ES2.Save(this.marqueur, "marqueur");
        }
        else
        {
            this.CanevasDebut.SetActive(false);
            this.CanevasChoix.SetActive(false);
        }*/
    }

    // Update is called once per frame
    void Update()
    {

    }
}
