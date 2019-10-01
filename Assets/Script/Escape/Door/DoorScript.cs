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
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (ES2.Exists("trouve"))
            {
                anim.SetTrigger("OpenDoor");
            }
            else
            {
                StartCoroutine(this.PorteFermee());
            }
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            anim.enabled = true;
        }
    }

    public void PauseAnimationEvent()
    {
        anim.enabled = false;
    }

    IEnumerator PorteFermee()
    {
        this.CanvasPorteFermee.SetActive(true);
        yield return new WaitForSeconds(2f);
        this.CanvasPorteFermee.SetActive(false);
    }
}
