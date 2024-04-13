using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractSystem : MonoBehaviour
{
    public KeyCode mainInteractKey = KeyCode.E;
    public UnityEvent UnityEvent;
    public bool inRange = false;
    public GameObject Player;

    private string comparedTag = "Player";
    void Update()
    {
        Interact();
    }
    public virtual void Interact()
    {
        if (Input.GetKeyDown(mainInteractKey))
        {
            UnityEvent.Invoke();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == comparedTag)
        {
            inRange = false;
            //Debug.Log("Outside");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == comparedTag)
        {
            inRange = true;
            //Debug.Log("Inside");
        }
    }
}
