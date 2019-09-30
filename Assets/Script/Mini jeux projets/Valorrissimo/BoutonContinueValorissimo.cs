using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoutonContinueValorissimo : MonoBehaviour
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
        GameObject.Find("CanvasDebut/Text").GetComponent<Text>().text = "Vendez les maisons aux bonnes personnes, et obtenez la somme de 1 150 000 euros pour valider votre mission";
        yield return new WaitForSeconds(1);
    }

    IEnumerator desepear()
    {
        yield return new WaitForSeconds(1);
        this.CanvasTimer.SetActive(true);
        this.CanvasDebut.SetActive(false);
    }
}
