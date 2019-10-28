using UnityEngine;
using System.Collections;

public class ScriptFallDown : MonoBehaviour {

    //Déclarations des Variables

    public float SecToFall = 5; //Temporisation avant la Chute 
    private Rigidbody rb; //Composant rigidbody
    private Material plateformColor; // Composant color
    private Vector3 PositionDepart; //Stocke la position de départ;

    void Start ()
    {
        //Assignation des variables
        rb = GetComponent<Rigidbody>();
        PositionDepart =transform.position;
        plateformColor = GetComponent<Renderer> ().material;
    }

    void OnTriggerEnter (Collider Other) {
        //Le Player entre dans le Trigger
        if(Other.gameObject.tag=="Player") 
        {
            plateformColor.color = Color.red; //Change la couleur en rouge
            StartCoroutine(FallDown()); //Execute la courtine FallDown
        }

        //SpwanZone entre dans le Trigger
        if (Other.gameObject.tag=="ZoneSpawn")
        {
            plateformColor.color = Color.white; //Change la couleur en blanc
            rb.isKinematic=true; //Changement du IsKinematic
            transform.position=PositionDepart;//Changement de la position
        }
    }

    IEnumerator FallDown()
    {
        yield return new WaitForSeconds(SecToFall);//Pause en secondes
        rb.isKinematic=false;//Changement du IsKinematic
    }
       
}