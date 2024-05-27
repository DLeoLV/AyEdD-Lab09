using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeControl : MonoBehaviour
{
    public int weight;
    public NodeControl[] nextNode;

    public NodeControl ChooseNextNode()
    {
        int nextPosition = 0;
        return nextNode[nextPosition];
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<EnemyControl>().Cooldown(weight);
        }
    }
}
