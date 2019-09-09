using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasProjetsScript : MonoBehaviour
{
    //Variables
    public GameObject CanevasScore;
    public GameObject CanevasTimer;
    public GameObject CanevasChoix;
    public GameObject CanevasJoystick;
    public GameObject CanevasDebut;

    //On regarde combien de fois l'utilisateur a cliqué
    public int count;

    // Start is called before the first frame update
    void Start()
    {
        this.CanevasTimer.SetActive(false);
        this.CanevasScore.SetActive(false);
        this.CanevasJoystick.SetActive(false);
        this.CanevasDebut.SetActive(false);
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
            StartCoroutine(this.desepear());
            this.count = 2;
        }
    }


    IEnumerator desepear()
    {
        yield return new WaitForSeconds(1);
        this.CanevasTimer.SetActive(true);
        this.CanevasScore.SetActive(true);
        this.CanevasJoystick.SetActive(true);
        this.CanevasDebut.SetActive(true);
        this.CanevasChoix.SetActive(false);
    }
}
