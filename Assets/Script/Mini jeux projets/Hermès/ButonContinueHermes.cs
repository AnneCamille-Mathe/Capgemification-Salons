using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButonContinueHermes : MonoBehaviour
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
        //L'utilisateur n'a pas encore cliqué sur le bouton
        this.count = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    //Fonction appelée si l'utilisateur clique sur le bouton
    public void onClic()
    {
        //L'utilisateur appuie une première fois sur le bouton
        if (this.count == 1)
        {
            //On lance la coroutine
            StartCoroutine(this.change());
            //On incrémente le comptage
            this.count = 2;
        }
        //Sinon on lance la coroutine de disparition du panel
        else
        {
            StartCoroutine(this.desepear());
        }
    }

    IEnumerator change()
    {
        //On affiche le message
        GameObject.Find("CanvasDebut/PanelDebut/TextContinue").GetComponent<Text>().text = "Tous les chevaux d'Hermes se sont échappés, capturez les et les codeurs pourront retourner travailler !";
        yield return new WaitForSeconds(1);
    }

    IEnumerator desepear()
    {
        //l'utilisateur a de nouveau cliqué, on affiche le bouton pause et on efface le canvas précédent
        yield return new WaitForSeconds(1);
        this.CanvasTimer.SetActive(true);
        this.CanvasDebut.SetActive(false);
    }
}
