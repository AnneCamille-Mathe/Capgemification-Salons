using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoutonContinueValorissimo : MonoBehaviour
{
    //Variables
    public int count;
    public GameObject CanvasTimer;
    public GameObject CanvasDebut;
    
    // Start is called before the first frame update
    void Start()
    {
        //on affiche le bouton pause
        this.CanvasTimer.SetActive(true);
        //L'utilisateur n'a pas encore appuyé sur le bouton
        this.count = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void onClic()
    {
        //L'utilisateur appuie une première fois sur le bouton
        if (this.count == 1)
        {
            //on lance la première coroutine et on incrémente le compteur
            StartCoroutine(this.change());
            this.count = 2;
        }
        //Sinon on lance la seconde coroutine
        else
        {
            StartCoroutine(this.desepear());
        }
    }

    IEnumerator change()
    {
        //On affiche la mission
        GameObject.Find("CanvasDebut/Text").GetComponent<Text>().text = "Vendez les maisons aux bonnes personnes, et obtenez la somme de 1 150 000 euros pour valider votre mission";
        yield return new WaitForSeconds(1);
    }

    IEnumerator desepear()
    {
        //On désactive la mission et on affiche le bouton pause
        yield return new WaitForSeconds(1);
        this.CanvasTimer.SetActive(true);
        this.CanvasDebut.SetActive(false);
    }
}
