using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoutonValiderCode : MonoBehaviour
{
    //Variables
    public GameObject CanvasCode;
    public GameObject TextAide;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Si l'utilisateur clique sur le bouton
    public void onClic()
    {
        //L'utilisateur a trouvé le code
        if (ES2.Exists("code"))
        {
            CanvasCode.SetActive(false);
        }
        //L'utilisateur n'a pas trouvé le code (il s'est trompé)
        else if (!ES2.Exists("code"))
        {
            //On affiche le texte ci dessous
            TextAide.SetActive(true);
            TextAide.GetComponent<Text>().text = "Ce n'est pas ça ... Vous pouvez demander de l'aide (?)";
        }
    }
}
