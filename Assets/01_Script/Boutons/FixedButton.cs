using UnityEngine;
using UnityEngine.EventSystems;

public class FixedButton : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    [HideInInspector]
    public bool Pressed;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //On regarde si l'utilisateur clique sur le bouton, si oui on passe la variable à true
    public void OnPointerDown(PointerEventData eventData)
    {
        Pressed = true;
    }

    //On regarde si l'utilisateur relache le bouton, on passe la variable à false
    public void OnPointerUp(PointerEventData eventData)
    {
        Pressed = false;
    }
}