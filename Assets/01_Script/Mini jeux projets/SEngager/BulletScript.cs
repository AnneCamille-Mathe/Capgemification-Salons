using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    
    //Variables
    public float speed = 15f;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        //On donne la vitesse à la balle (pour une véritable impression de balle lancée)
        rb.velocity = transform.right * speed;
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }

    //Si la balle entre en collision avec un ennemi
    private void OnTriggerEnter2D(Collider2D other)
    {
        //Marqueur "enemies" sur les ennemis
        if (other.gameObject.tag == "Enemies")
        {
            //On détruit la balle
            Destroy(gameObject);
        }
    }

}
