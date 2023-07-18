using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int score;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Hit")
            score++;
    }
}
