using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerValorissimoScript : MonoBehaviour
{
    //Variables
    private int count = 1;
    
    public bool tourCooloc;
    public bool tourFamille;
    public bool tourSeul;
    
    public GameObject persoColoc;
    public GameObject persoFamille;
    public GameObject persoSeul;

    public GameObject PanelColoc;
    public GameObject PanelFamille;
    public GameObject PanelSeul;

    public GameObject CanevasDebut;
    
    // Start is called before the first frame update
    void Start()
    {
        tourCooloc = false;
        tourFamille = false;
        tourSeul = false;
    }

    // Update is called once per frame
    
    void Update()
    {
        if (CanevasDebut.activeSelf == false & count == 1)
        {
            persoColoc.SetActive(true);
            PanelColoc.SetActive(true);
            count += 1;
        }

        if (persoColoc.activeSelf == true)
        {
            tourCooloc = true;
        }
        
        if (persoFamille.activeSelf == true)
        {
            tourFamille = true;
        }
        
        if (persoSeul.activeSelf == true)
        {
            tourSeul = true;
        }

        if (GameObject.Find("CanvasInfosPerso/PanelCollocation/Text") != null && tourCooloc && !tourFamille && !tourSeul)
        {
            if (GameObject.Find("CanvasInfosPerso/PanelCollocation/Text").GetComponent<Text>().text ==
                "C'est parfait, merci beaucoup !")
            {
                StartCoroutine(WaitFamille());
            }
        }
        
        if (GameObject.Find("CanvasInfosPerso/PanelFamille/Text") != null && tourCooloc && tourFamille && !tourSeul)
        {
            if (GameObject.Find("CanvasInfosPerso/PanelFamille/Text").GetComponent<Text>().text ==
                "C'est parfait, ma famille et moi allons être très bien ici, merci beaucoup !")
            {
                StartCoroutine(WaitSeul());
            }
        }

        if (GameObject.Find("CanvasInfosPerso/PanelSeul/Text") != null && tourCooloc && tourFamille && tourSeul)
        {
            if (GameObject.Find("CanvasInfosPerso/PanelSeul/Text").GetComponent<Text>().text ==
                "C'est parfait, je vais me plaire ici, merci beaucoup !")
            {
                StartCoroutine(WaitVictoire());
            }
        }
        
        //TODO - si message : effacer perso et message
        if (GameObject.Find("CanvasInfosPerso/PanelCollocation/Text") != null)
        {
            if (GameObject.Find("CanvasInfosPerso/PanelCollocation/Text").GetComponent<Text>().text ==  "Mais ce n'est pas du tout ce que je recherche !")
            {
                StartCoroutine(DesepearColloc());
            }
        }

        if (GameObject.Find("CanvasInfosPerso/PanelFamille/Text") != null)
        {
            if (GameObject.Find("CanvasInfosPerso/PanelFamille/Text").GetComponent<Text>().text ==  "Mais ce n'est pas du tout ce que je recherche !")
            {
                StartCoroutine(DesepearFamille());
            }
        }

        if (GameObject.Find("CanvasInfosPerso/PanelSeul/Text") != null)
        {
            if (GameObject.Find("CanvasInfosPerso/PanelSeul/Text").GetComponent<Text>().text ==  "Mais ce n'est pas du tout ce que je recherche !")
            {
                StartCoroutine(DesepearSeul());
            }
        }
    }

    IEnumerator WaitFamille()
    {
        yield return new WaitForSeconds(2f);
        PanelColoc.SetActive(false);
        persoColoc.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        persoFamille.SetActive(true);
        PanelFamille.SetActive(true);
    }

    IEnumerator WaitSeul()
    {
        yield return new WaitForSeconds(2f);
        PanelFamille.SetActive(false);
        persoFamille.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        persoSeul.SetActive(true);
        PanelSeul.SetActive(true);
    }

    IEnumerator WaitVictoire()
    {
        yield return new WaitForSeconds(2f);
        PanelSeul.SetActive(false);
        persoSeul.SetActive(false);
        yield return new WaitForSeconds(0.5f);
    }

    IEnumerator DesepearFamille()
    {
        yield return new WaitForSeconds(0.5f);
        persoFamille.SetActive(false);
        PanelFamille.SetActive(false);
        yield return new WaitForSeconds(0.5f);
    }

    IEnumerator DesepearSeul()
    {
        yield return new WaitForSeconds(0.5f);
        persoSeul.SetActive(false);
        PanelSeul.SetActive(false);
        yield return new WaitForSeconds(0.5f);
    }

    IEnumerator DesepearColloc()
    {
        yield return new WaitForSeconds(0.5f);
        persoColoc.SetActive(false);
        PanelColoc.SetActive(false);
        yield return new WaitForSeconds(0.5f);
    }
}
