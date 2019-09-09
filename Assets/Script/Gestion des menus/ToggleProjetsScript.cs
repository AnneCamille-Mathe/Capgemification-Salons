using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleProjetsScript : MonoBehaviour
{
    //Variables
    public GameObject boutonProjet;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ToggleChanged(bool newValue)
    {
        bool Hermes = newValue;
        ES2.Save(Hermes, "Hermes");
     }
}
    
    
