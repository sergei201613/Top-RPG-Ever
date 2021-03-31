using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private Rigidbody2D rb = null;
    [SerializeField] private Animator animator = null;
    private Vector2 movement;

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement.normalized * speed * Time.fixedDeltaTime);

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    private void OnTriggerStay2D(Collider2D other) {
        var transparent = other.GetComponent<TransparentNearByPlayer>();
        if (transparent != null) {
            transparent.MakeTransparent();
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        var transparent = other.GetComponent<TransparentNearByPlayer>();
        if (transparent != null) {
            transparent.MakeOpaque();
        }
    }
}
