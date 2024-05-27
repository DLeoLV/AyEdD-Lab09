using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perseguir : MonoBehaviour
{
    public float speed = 10f;
    public float step;
    public GameObject enemy;

    void Update()
    {
        step = speed * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, enemy.transform.position, step);
    }
}
