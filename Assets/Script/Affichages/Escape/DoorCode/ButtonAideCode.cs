using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonAideCode : MonoBehaviour
{
    //Variables
    //permet de compter le nombre de clics sur le bouton d'aide
    private int count;
    public GameObject TextAide;
    
    // Start is called before the first frame update
    void Start()
    {
        //L'utilisateur n'a pas encore cliqué
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClic()
    {
        //L'utilisateur clique une première fois sur l'aide, le premier message d'aide est affiché
        if (count == 0)
        {
            StartCoroutine(premierAffichage());
            count += 1;
        }
        //L'utilisateur clique une seconde fois sur l'aide, le second message d'aide est affiché
        else if (count == 1)
        {
            StartCoroutine(secondAffichage());
            count += 1;
        }
        //L'utilisateur clique une troisième fois sur l'aide, ou plus, le troisième message d'aide est affiché
        else if (count >= 2)
        {
            StartCoroutine(troisiemeAffichage());
            count += 1;
        }
    }

    IEnumerator premierAffichage()
    {
        //On affiche le premier message d'aide pendant 2 secondes
        TextAide.SetActive(true);
        yield return new WaitForSeconds(2f);
        TextAide.SetActive(false);
    }
    
    IEnumerator secondAffichage()
    {
        //On affiche un second message d'aide pendant 2 secondes
        TextAide.SetActive(true);
        TextAide.GetComponent<Text>().text = "Regadez la pendule à droite de la porte";
        yield return new WaitForSeconds(2f);
        TextAide.SetActive(false);
    }
    
    IEnumerator troisiemeAffichage()
    {
        //On donne la solution pendant 2 secondes
        TextAide.SetActive(true);
        TextAide.GetComponent<Text>().text = "Le code est : 1015";
        yield return new WaitForSeconds(2f);
        TextAide.SetActive(false);
    }
}
