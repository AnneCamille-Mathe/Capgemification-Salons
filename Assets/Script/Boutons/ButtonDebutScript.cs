using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonDebutScript : MonoBehaviour
{
    //Variables
    public GameObject CanevasScore;
    public GameObject CanevasTimer;
    public GameObject CanvasJoystick;
    public GameObject CanvasSynospis;
    public GameObject CanvasPause;

    //On regarde combien de fois l'utilisateur a cliqué
    public int count;
    
    // Start is called before the first frame update
    void Start()
    {
        //On laisse apparant uniquement le synopsis
        this.CanevasTimer.SetActive(false);
        this.CanevasScore.SetActive(false);
        this.CanvasJoystick.SetActive(false);
        this.CanvasPause.SetActive(false);
        this.CanvasSynospis.SetActive(true);
        //L'utilisateur clique la première fois
        this.count = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClic()
    {
        //L'utilisateur a cliqué une fois --> la suite du message s'affiche
        if (this.count == 1)
        {
            StartCoroutine(this.change());
            this.count = 2;
        }
        //L'utilisateur a cliqué une deuxième fois --> le canvas disparait
        else
        {
            StartCoroutine(this.desepear());
        }
    }

    IEnumerator change()
    {
        //On change l'affichage du Canvas
        GameObject.Find("CanvasSynopsis/Panel/Text").GetComponent<Text>().text = "Les codeurs vous ont parfois indique le chemin a suivre, regardez bien le sol … Votre mission est la suivante : penetrez les lieux, explorez, reparez les projets… Mais attention ! L’IA a verrouille les portes et bloque certaines issues, vous allez devoir dejouer ses plans pour reussir votre mission !";
        yield return new WaitForSeconds(1);
    }

    IEnumerator desepear()
    {
        //On enlève le canvas du synopsis et on affiche la scène principale avec timer, score et joystick
        yield return new WaitForSeconds(1);
        this.CanevasScore.SetActive(true);
        this.CanvasJoystick.SetActive(true);
        this.CanevasTimer.SetActive(true);
        this.CanvasPause.SetActive(true);
        this.CanvasSynospis.SetActive(false);
    }

}
