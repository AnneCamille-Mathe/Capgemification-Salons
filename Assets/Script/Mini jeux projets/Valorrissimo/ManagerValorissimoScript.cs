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
        //On initialise tous les tours à false
        tourCooloc = false;
        tourFamille = false;
        tourSeul = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Si on est au début du tour, on affiche le premier personnage
        premierTour();

        //On marque le tour des personnages
        marquage();

        //On regarde si l'utilisateur a bien trouvé la bonne maison, si oui on déclanche la coroutine
        reussite();
        
        //Sinon, l'échec est affiché et on l'efface grace à la coroutine 
        echec();
    }

    void echec()
    {
        if (GameObject.Find("CanvasInfosPerso/PanelCollocation/Text") != null)
        {
            if (GameObject.Find("CanvasInfosPerso/PanelCollocation/Text").GetComponent<Text>().text ==  "Mais ce n'est pas du tout ce que je recherche !")
            {
                StartCoroutine(DesepearColloc());
            }
        }

        //Sinon, l'échec est affiché et on l'efface grace à la coroutine
        if (GameObject.Find("CanvasInfosPerso/PanelFamille/Text") != null)
        {
            if (GameObject.Find("CanvasInfosPerso/PanelFamille/Text").GetComponent<Text>().text ==  "Mais ce n'est pas du tout ce que je recherche !")
            {
                StartCoroutine(DesepearFamille());
            }
        }

        //Sinon, l'échec est affiché et on l'efface grace à la coroutine
        if (GameObject.Find("CanvasInfosPerso/PanelSeul/Text") != null)
        {
            if (GameObject.Find("CanvasInfosPerso/PanelSeul/Text").GetComponent<Text>().text ==  "Mais ce n'est pas du tout ce que je recherche !")
            {
                StartCoroutine(DesepearSeul());
            }
        }
    }
    void premierTour()
    {
        if (CanevasDebut.activeSelf == false & count == 1)
        {
            persoColoc.SetActive(true);
            PanelColoc.SetActive(true);
            //on incrémente le compteur
            count += 1;
        }
    }

    void marquage()
    {
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
    }

    void reussite()
    {
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
    }
    
    
    //On affiche le personnage de la famille après la collocation
    IEnumerator WaitFamille()
    {
        yield return new WaitForSeconds(2f);
        PanelColoc.SetActive(false);
        persoColoc.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        persoFamille.SetActive(true);
        PanelFamille.SetActive(true);
    }

    //On affiche le personnage seul après la famille
    IEnumerator WaitSeul()
    {
        yield return new WaitForSeconds(2f);
        PanelFamille.SetActive(false);
        persoFamille.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        persoSeul.SetActive(true);
        PanelSeul.SetActive(true);
    }

    //On désactive le derneir personnage
    IEnumerator WaitVictoire()
    {
        yield return new WaitForSeconds(2f);
        PanelSeul.SetActive(false);
        persoSeul.SetActive(false);
        yield return new WaitForSeconds(0.5f);
    }

    //On désactive le perso famille après l'échec
    IEnumerator DesepearFamille()
    {
        yield return new WaitForSeconds(0.5f);
        persoFamille.SetActive(false);
        PanelFamille.SetActive(false);
        yield return new WaitForSeconds(0.5f);
    }

    //On désactive le perso seul après l'échec
    IEnumerator DesepearSeul()
    {
        yield return new WaitForSeconds(0.5f);
        persoSeul.SetActive(false);
        PanelSeul.SetActive(false);
        yield return new WaitForSeconds(0.5f);
    }

    //On désactive le perso colloc après l'échec
    IEnumerator DesepearColloc()
    {
        yield return new WaitForSeconds(0.5f);
        persoColoc.SetActive(false);
        PanelColoc.SetActive(false);
        yield return new WaitForSeconds(0.5f);
    }
}
