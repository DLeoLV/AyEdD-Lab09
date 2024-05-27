using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    public float speed;
    public float cooldown;
    private float step;
    public NodeControl currentNodeToMove;
    public float energy;
    // Start is called before the first frame update
    void Start()
    {
        energy = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        step = speed * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, currentNodeToMove.transform.position, step);
        if(energy <= 0)
        {
            speed = 0;
            cooldown = cooldown + Time.deltaTime;
        }
        if (cooldown > 3)
        {
            speed = 10f;
            cooldown = 0;
            energy = 10f;
        }
    }

    public void SelectNextNodePosition()
    {
        currentNodeToMove = currentNodeToMove.ChooseNextNode();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Node"))
        {
            SelectNextNodePosition();
        }
    }

    public void SetInitialNodeToMove(NodeControl initialNode)
    {
        currentNodeToMove = initialNode;
    }
    public void Cooldown(int weight)
    {
        energy = energy - weight;
    }
}
