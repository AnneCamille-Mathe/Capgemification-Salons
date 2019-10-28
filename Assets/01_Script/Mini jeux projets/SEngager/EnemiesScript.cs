using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class EnemiesScript : MonoBehaviour
{
    //Variables
    public GameObject enemie;
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    //On regarde ce qui rentre dans le trigger de l'enemies, s'il s'agit de la balle, on détruit l'ennemi
    private void OnTriggerEnter2D(Collider2D other)
    {
        //La balle a été marquée avec le tag "bullet"
        if (other.gameObject.tag == "Bullet")
        {
            Destroy(enemie);
        }
    }
}
