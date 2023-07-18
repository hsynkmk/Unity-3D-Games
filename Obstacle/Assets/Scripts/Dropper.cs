using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] int timeToWait = 4;
    MeshRenderer meshRenderer;
    Rigidbody rigidBody;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.enabled = false;
        
        rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(Time.time >= timeToWait)
        {
            meshRenderer.enabled = true;
            rigidBody.useGravity = true;
        }
    }
}
