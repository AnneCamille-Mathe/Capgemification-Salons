using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonChoisirM3 : MonoBehaviour
{
    //Variables
    public GameObject persoColloc;
    public GameObject PanelCollocation;
    public GameObject Button;
    public GameObject PanelMaison3;
  
    private bool colloc;
    private bool famille;
    private bool seul;
    
    public GameObject persoFamille;
    public GameObject PanelFamille;
    public GameObject ButtonFamille;
    public GameObject persoSeul;
    public GameObject PanelSeul;
    public GameObject ButtonSeul;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //On enregistre les booléens
        colloc = GameObject.Find("Manager").GetComponent<ManagerValorissimoScript>().tourCooloc;
        famille = GameObject.Find("Manager").GetComponent<ManagerValorissimoScript>().tourFamille;
        seul = GameObject.Find("Manager").GetComponent<ManagerValorissimoScript>().tourSeul;
        
    }

    //Fonction appelée si l'utilisateur clique sur le bouton
    public void onClic()
    {
        //On regarde quels tours ont été activés
        
        //Si le tour de la colloc est effectué, l'utilisateur a cliqué sur la bonne maison
        if (colloc && !famille && !seul)
        {
            Button.SetActive(false);   
            persoColloc.SetActive(true);
            PanelCollocation.SetActive(true);
            GameObject.Find("CanvasInfosPerso/PanelCollocation/Text").GetComponent<Text>().text = "C'est parfait, merci beaucoup !";
            GameObject.Find("CanvasSomme/Panel/Text").GetComponent<Text>().text = "Somme : " + 600000;
            PanelMaison3.SetActive(false);
        }
        
        //Sinon l'utilisateur s'est trompé de maison et on affiche le message d'echec
        if (colloc && famille && !seul)
        {
            StartCoroutine(Famille());
        }
        
        if (colloc && famille && seul)
        {
            StartCoroutine(Seul());
        }
    }
    
    //L'utilisateur s'est trompé lors du tour de l'homme seul
    IEnumerator Seul()
    {
        PanelMaison3.SetActive(false);
        persoSeul.SetActive(true);
        PanelSeul.SetActive(true);
        GameObject.Find("CanvasInfosPerso/PanelSeul/Text").GetComponent<Text>().text =
            "Mais ce n'est pas du tout ce que je recherche !";
        yield return  new WaitForSeconds(1f);
        ButtonSeul.SetActive(false);
    }
    
    //L'utilisateur s'est trompé lors du tour de la famille
    IEnumerator Famille()
    {
        PanelMaison3.SetActive(false);
        persoFamille.SetActive(true);
        PanelFamille.SetActive(true);
        GameObject.Find("CanvasInfosPerso/PanelFamille/Text").GetComponent<Text>().text =
            "Mais ce n'est pas du tout ce que je recherche !";
        yield return  new WaitForSeconds(1f);
        ButtonFamille.SetActive(false);
    }
    
    
}
