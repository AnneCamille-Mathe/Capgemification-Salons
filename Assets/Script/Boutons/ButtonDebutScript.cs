using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonDebutScript : MonoBehaviour
{
    //Variables
    public GameObject CanevasScore;
    public GameObject CanevasTimer;
    public GameObject CanevasDebut;

    //On regarde combien de fois l'utilisateur a cliqué
    public int count;
    //TODO - Message du début
    
    // Start is called before the first frame update
    void Start()
    {
        this.CanevasTimer.SetActive(false);
        this.CanevasScore.SetActive(false);
        this.count = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClic()
    {
        if (this.count == 1)
        {
            StartCoroutine(this.change());
            this.count = 2;
        }
        else
        {
            StartCoroutine(this.desepear());
        }
    }

    IEnumerator change()
    {
        GameObject.Find("Canvas_debut/Panel_debut/Text_debut").GetComponent<Text>().text = "Les codeurs vous ont parfois indique le chemin a suivre, regardez bien le sol … Votre mission est la suivante : penetrez les lieux, explorez, reparez les projets… Mais attention ! L’IA a verrouille les portes et bloque certaines issues, vous allez devoir dejouer ses plans pour reussir votre mission !";
        yield return new WaitForSeconds(1);
    }

    IEnumerator desepear()
    {
        yield return new WaitForSeconds(1);
        this.CanevasDebut.SetActive(false);
        this.CanevasTimer.SetActive(true);
        this.CanevasScore.SetActive(true);
    }

}
