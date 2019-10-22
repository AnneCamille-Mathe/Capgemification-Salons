using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class VerifCodeScript : MonoBehaviour
{
    //Variables
    public InputField code;
    //public Text texte;
    public bool trouve;
    
    // Start is called before the first frame update
    void Start()
    {
        //Au début de la partie le code n'est pas trouvé
        trouve = false;
    }

    // Update is called once per frame
    void Update()
    {
            
    }

    //On vérifie le code
    public void Code()
    {
        //Si le code correspond à 1015 on passe la variable à true et on sauvegarde la réussite grâce à l'ES2
        if (code.text == "1015")
        {
            trouve = true;
            ES2.Save(trouve, "code");
        }
    }
}
