using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCodeScript : MonoBehaviour
{
    //Variables
    private Animator anim;
    public GameObject CanvasCode;
    private bool collider;
    public bool code;
    public GameObject CanvasCodeAttendre;

    // Start is called before the first frame update
    void Start()
    {
        //On récupère l'animator
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //On regarde si l'utilisateur a trouvé le code
        code = ES2.Exists("code");
        //Si l'utilisateur a trouvé le code et est dans la zone on lance l'ouverture de la porte
        if (collider && code)
        {
            StartCoroutine(AttendreUnPeu());
        }
        //Si l'utilisateur est dans la zone mais n'a pas rouvé le code
        else if (collider && !code)
        {
            //Si la clef a été trouvée (il a déjà fait un parcours et peut ouvrir la porte)
            //on affiche la demande de code
            if (ES2.Exists("trouve"))
            {
                this.CanvasCode.SetActive(true);
            }
            //Sinon on lui dit d'attendre avant d'ouvrir cette porte
            else
            {
                CanvasCodeAttendre.SetActive(true);
            }
        }
        
        //Si le code est trouvé mais que l'utilisateur n'est pas dans la zone on modifie le trigger de l'animator
        else if (!collider && code)
        {
            anim.enabled = true;
        }
        
        //Sinon
        else
        {
            //Si l'utilisateur a trouvé la clef
            if (ES2.Exists("trouve"))
            {
                //on lui dit d'attendre un peu
                this.CanvasCode.SetActive(false);
            }
            else
            {
                //on n'affiche pas l'attente
                CanvasCodeAttendre.SetActive(false);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //Si l'utilisateur entre de la zone de trigger, on passe la variable à true
        if (other.gameObject.tag == "Player")
        {
            collider = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //Si l'utilisateur sort de la zone de trigger, on passe la variable à false
        if (other.gameObject.tag == "Player")
        {
            collider = false;
        }
    }

    //Utilisé dans l'animator
    public void PauseAnimationEvent()
    {
        anim.enabled = false;
    }

    IEnumerator AttendreUnPeu()
    {
        //On ouvre la porte au bout de 1.5 secondes grâce à l'animator
        yield return new WaitForSeconds(1.5f);
        anim.SetTrigger("OpenDoor");
        this.CanvasCode.SetActive(false);
    }
   
}