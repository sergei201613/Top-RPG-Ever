using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerSorter : MonoBehaviour
{
    [SerializeField] private SpriteRenderer sprite;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Obstacle")
        {
            if (transform.position.y > collision.transform.position.y)
                sprite.sortingOrder = collision.GetComponentInChildren<SpriteRenderer>().sortingOrder - 1;
            else
                sprite.sortingOrder = 200;
        }
    }
}
