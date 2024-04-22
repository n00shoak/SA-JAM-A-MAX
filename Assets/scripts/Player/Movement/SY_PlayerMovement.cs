using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class SY_PlayerMovement : MonoBehaviour
{
    [SerializeField] private float acceleration;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private KeyCode forward = KeyCode.Mouse1;

    private void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    public void MUpdate()
    {
        if (Input.GetKey(forward))
        {
            rb.AddForce(transform.right * acceleration);
        }
    }
}
