using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Coin Touched");
    }

    private void Update()
    {
        transform.Rotate(0, 0, 50 * Time.deltaTime);
    }
}
