using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransparentNearByPlayer : MonoBehaviour
{
    [SerializeField] private SpriteRenderer sprite = null;
    [SerializeField] float minTransparency = .5f;
    [SerializeField] float transparentingTime = 10f;

    private float targetTransparency = 1f;

    public void Update() {
        Color color = sprite.color;
        color.a = Mathf.Lerp(color.a, targetTransparency, transparentingTime * Time.deltaTime);
        sprite.color = color;
    }

    public void MakeTransparent() {
        targetTransparency = minTransparency;
    }

    public void MakeOpaque() {
        targetTransparency = 1f;
    }
}
