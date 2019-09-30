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
        GameObject.Find("Canvas_Mission/Panel_Mission/Text_Mission").GetComponent<Text>().text = "Votre mission : detruisez les clones de l'IA avec les armes de l'armee et accedez au site";
        yield return new WaitForSeconds(1);
        
    }
    
    IEnumerator desepear(){
        yield return new WaitForSeconds(1);
        this.CanevasMission.SetActive(false);
        this.CanevasControl.SetActive(true);
    }
}
