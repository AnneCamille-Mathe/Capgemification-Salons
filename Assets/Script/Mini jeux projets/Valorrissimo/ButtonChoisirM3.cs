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
        colloc = GameObject.Find("Manager").GetComponent<ManagerValorissimoScript>().tourCooloc;
        famille = GameObject.Find("Manager").GetComponent<ManagerValorissimoScript>().tourFamille;
        seul = GameObject.Find("Manager").GetComponent<ManagerValorissimoScript>().tourSeul;
        
    }

    public void onClic()
    {
        if (colloc && !famille && !seul)
        {
            Button.SetActive(false);   
            persoColloc.SetActive(true);
            PanelCollocation.SetActive(true);
            GameObject.Find("CanvasInfosPerso/PanelCollocation/Text").GetComponent<Text>().text = "C'est parfait, merci beaucoup !";
            GameObject.Find("CanvasSomme/Panel/Text").GetComponent<Text>().text = "Somme : " + 600000;
            PanelMaison3.SetActive(false);
        }
        
        
        if (colloc && famille && !seul)
        {
            StartCoroutine(Famille());
        }
        
        if (colloc && famille && seul)
        {
            StartCoroutine(Seul());
        }
    }
    
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
