using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deteccion : MonoBehaviour
{
    public GameObject jugador;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemigo"))
        {
            EnemyControl quietoScript = jugador.GetComponent<EnemyControl>();
            Perseguir moverScript = jugador.GetComponent<Perseguir>();
            if (quietoScript != null && moverScript != null)
            {
                quietoScript.enabled = false;
                moverScript.enabled = true;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Enemigo"))
        {
            EnemyControl quietoScript = jugador.GetComponent<EnemyControl>();
            Perseguir moverScript = jugador.GetComponent<Perseguir>();
            if (quietoScript != null && moverScript != null)
            {
                quietoScript.enabled = true;
                moverScript.enabled = false;
            }
        }
    }
}