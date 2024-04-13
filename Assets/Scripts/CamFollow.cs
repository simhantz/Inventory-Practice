using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public Camera mainCamera;

    // Update is called once per frame
    void Update()
    {
        mainCamera.transform.position = new Vector3(gameObject.transform.position.x, mainCamera.transform.position.y, mainCamera.transform.position.z);
    }
}
