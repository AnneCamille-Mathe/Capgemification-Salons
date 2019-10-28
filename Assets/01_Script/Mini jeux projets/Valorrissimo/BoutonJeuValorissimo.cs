using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoutonJeuValorissimo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    //Si l'utilisateur clique sur le bouton de lancement, on lance la scène de Valorissimo
    public void LoadLevel()
    {
        SceneManager.LoadScene("MiniJeuValorissimo");
    }
}
