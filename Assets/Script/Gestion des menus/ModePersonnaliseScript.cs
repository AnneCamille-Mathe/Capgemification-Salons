///////////////////////////////////////////////////////////////////////////////////
/////////////////// Réalisé le 11/09/2019 -- MATHE ANNE CAMILLE ///////////////////
///////////////////////////////////////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.SceneManagement;


public class ModePersonnaliseScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClic()
    {
        SceneManager.LoadScene("ModeDeveloppeur");
    }
}
