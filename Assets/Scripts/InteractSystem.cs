using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractSystem : MonoBehaviour
{
    public KeyCode interactKey = KeyCode.E;
    public UnityEvent UnityEvent;

    private bool inRange = false;
    private string comparedTag = "Player";
    void Update()
    {
        if (Input.GetKeyDown(interactKey) && inRange)
        {
            UnityEvent.Invoke();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == comparedTag)
        {
            inRange = false;
            Debug.Log("Outside");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == comparedTag)
        {
            inRange = true;
            Debug.Log("Inside");
        }
    }
}
