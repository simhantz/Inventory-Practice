using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractSystem : MonoBehaviour
{
    public KeyCode interactKey = KeyCode.E;
    public UnityEvent UnityEvent;

    void Update()
    {
        if (UnityEvent != null && Input.GetKeyDown(interactKey))
            UnityEvent.Invoke();
    }
}
