using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Spinner : MonoBehaviour
{

    [SerializeField] float xRotate = 0f;
    [SerializeField] float yRotate = 1f;
    [SerializeField] float zRotate = 0f;

    void Update()
    {
        transform.Rotate(xRotate * Time.deltaTime, yRotate, zRotate * Time.deltaTime);
    }
}
