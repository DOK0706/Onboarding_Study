using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Vector3 deltaPosition;
    // public Vector3 deltaRotation;
    public GameObject playerObject;

    private void Awake()
    {
        deltaPosition = new Vector3(0, 7, -10);
        // deltaRotation = playerObject.transform.rotation = transform.rotation;
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerObject.transform.position = deltaPosition;
        // transform.localEulerAngles = playerObject.transform.localEulerAngles = deltaRotation;
    }
}