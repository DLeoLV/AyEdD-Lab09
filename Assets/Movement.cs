using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float velocidadMovimiento = 5f;

    void Update()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(movimientoHorizontal, movimientoVertical, 0f) * velocidadMovimiento * Time.deltaTime;

        transform.position += movimiento;
    }
}
