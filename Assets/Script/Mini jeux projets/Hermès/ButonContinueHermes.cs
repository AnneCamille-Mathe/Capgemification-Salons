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
        this.CanvasTimer.SetActive(true);
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
        GameObject.Find("CanvasDebut/PanelDebut/TextContinue").GetComponent<Text>().text = "Tous les chevaux d'Hermes se sont échappés, capturez les et les codeurs pourront retourner travailler !";
        yield return new WaitForSeconds(1);
    }

    IEnumerator desepear()
    {
        yield return new WaitForSeconds(1);
        this.CanvasTimer.SetActive(true);
        this.CanvasDebut.SetActive(false);
    }
}
