using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProjetSEngager : MonoBehaviour
{
    //Variables
    public GameObject CanevasMission;
    public GameObject CanevasControl;
    //On regarde combien de fois l'utilisateur a cliqué
    public int count;
    
    // Start is called before the first frame update
    void Start()
    {
        //L'utilisateur n'a pas encore appuyé sur le bouton
        this.count = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //On lance la fonction si le joueur clique sur le bouton
    public void onClic()
    {
        //L'utilisateur clique une première fois
        if (this.count == 1) 
        { 
            //On lance la première coroutine et on incrémente le compteur
            StartCoroutine(this.change());
            this.count = 2;
        }
        //Sinon on lance la dernière coroutine
        else
        { 
            StartCoroutine(this.desepear());
        } 
    }

    IEnumerator change()
    {
        //On affiche la mission
        GameObject.Find("Canvas_Mission/Panel_Mission/Text_Mission").GetComponent<Text>().text = "Votre mission : detruisez les clones de l'IA avec les armes de l'armee et accedez au site";
        yield return new WaitForSeconds(1);
        
    }
    
    IEnumerator desepear(){
        //On efface la mission et on affiche les joystick
        yield return new WaitForSeconds(1);
        this.CanevasMission.SetActive(false);
        this.CanevasControl.SetActive(true);
    }
}
