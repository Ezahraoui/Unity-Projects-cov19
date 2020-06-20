using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ControlMonnaie : MonoBehaviour
{
    public int score = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        score = score + 1;
        Debug.Log(score);
    }
}
