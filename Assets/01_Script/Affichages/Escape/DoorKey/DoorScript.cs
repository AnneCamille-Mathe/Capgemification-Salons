using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    //Variables
    private Animator anim;
    public GameObject CanvasPorteFermee;
    
    // Start is called before the first frame update
    void Start()
    {
        //On récupère l'animator
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    //On regarde si l'utilisateur est entré dans la zone
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //Si le code est trouvé on ouvre la porte
            if (ES2.Exists("trouve"))
            {
                anim.SetTrigger("OpenDoor");
            }
            //Sinon, on lance la coroutine
            else
            {
                StartCoroutine(this.PorteFermee());
            }
        }
    }
    
    //On regarde si l'utilisateur sort de la zone
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //Si le code est trouvé on referme la porte
            if (ES2.Exists("trouve"))
            {
                anim.enabled = true;
            }
        }
    }

    //On modifie le trigger de l'animator
    public void PauseAnimationEvent()
    {
        anim.enabled = false;
    }
    
    //On affiche le message de la porte fermée pendant 2 secondes
    IEnumerator PorteFermee()
    {
        this.CanvasPorteFermee.SetActive(true);
        yield return new WaitForSeconds(2f);
        this.CanvasPorteFermee.SetActive(false);
    }
}
