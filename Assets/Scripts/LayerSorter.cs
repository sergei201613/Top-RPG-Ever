using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerSorter : MonoBehaviour
{
    [SerializeField] private SpriteRenderer sprite = null;
    [SerializeField] private bool updateRuntime = false;

    private void OnEnable() {
        UpdateSortingOrder();
    }

    private void FixedUpdate() {
        UpdateSortingOrder();
        enabled = updateRuntime;
    }

    private void UpdateSortingOrder() {
        sprite.sortingOrder = Mathf.RoundToInt((1 - transform.position.y) * 10);
    }
}
