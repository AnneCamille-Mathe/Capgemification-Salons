using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleLoad : MonoBehaviour
{
    
    //Variables
    public  GameObject managerScript;
    public GameObject player;
    public bool debutJeu = true;
    
    // Start is called before the first frame update
    void Start()
    {
        Load();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Load()
    {    
        player.transform.position = ES2.Load<Vector3>("position");
    }
}
