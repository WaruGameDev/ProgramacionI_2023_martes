using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Fruta"))
        {
            GameManager.instance.AddPuntaje(10);
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Bomba"))
        {
            GameManager.instance.AddPuntaje(-10);
            Destroy(other.gameObject);
        }

    }
}
