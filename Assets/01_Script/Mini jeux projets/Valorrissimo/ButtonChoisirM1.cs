using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonChoisirM1 : MonoBehaviour
{
    //Variables
    public GameObject persoFamille;
    public GameObject PanelFamille;
    public GameObject Button;
    public GameObject PanelMaison1;
    public GameObject TextPanelMaison1;
    

    private bool colloc;
    private bool famille;
    private bool seul;

    public GameObject persoSeul;
    public GameObject PanelSeul;
    public GameObject ButtonSeul;
    public GameObject persoColloc;
    public GameObject PanelColloc;
    public GameObject ButtonColloc;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //On enregistre les booléens
        seul = GameObject.Find("Manager").GetComponent<ManagerValorissimoScript>().tourSeul;
        colloc = GameObject.Find("Manager").GetComponent<ManagerValorissimoScript>().tourCooloc;
        famille = GameObject.Find("Manager").GetComponent<ManagerValorissimoScript>().tourFamille;
    }
    
    //Fonction appelée si l'utilisateur clique sur le bouton
    public void onClic()
    {
        //On regarde quels tours ont été activés
        
        //Si le tour de la colloc et de la famille sont effectués, l'utilisateur a cliqué sur la bonne maison
        if (colloc && famille && !seul)
        {
            Button.SetActive(false);   
            persoFamille.SetActive(true);
            PanelFamille.SetActive(true);
            GameObject.Find("CanvasInfosPerso/PanelFamille/Text").GetComponent<Text>().text = "C'est parfait, ma famille et moi allons être très bien ici, merci beaucoup !";
            GameObject.Find("CanvasSomme/Panel/Text").GetComponent<Text>().text = "Somme : " + 1000000;
            PanelMaison1.SetActive(false);
        }
        
        //Sinon l'utilisateur s'est trompé de maison et on affiche le message d'echec
        if (colloc && !famille && !seul)
        {
            StartCoroutine(Colloc());
        }
        
        if (colloc && famille && seul)
        {
            StartCoroutine(Seul());
        }
    }

    //L'utilisateur s'est trompé lors du tour du colloc
    IEnumerator Colloc()
    {
        PanelMaison1.SetActive(false);
        persoColloc.SetActive(true);
        PanelColloc.SetActive(true);
        GameObject.Find("CanvasInfosPerso/PanelCollocation/Text").GetComponent<Text>().text =
            "Mais ce n'est pas du tout ce que je recherche !";
        yield return  new WaitForSeconds(1f);
        ButtonColloc.SetActive(false);
    }

    //L'utilisateur s'est trompé lors du tour de l'homme seul
    IEnumerator Seul()
    {
        PanelMaison1.SetActive(false);
        persoSeul.SetActive(true);
        PanelSeul.SetActive(true);
        GameObject.Find("CanvasInfosPerso/PanelSeul/Text").GetComponent<Text>().text =
            "Mais ce n'est pas du tout ce que je recherche !";
        yield return  new WaitForSeconds(1f);
        ButtonSeul.SetActive(false);
    }

}
