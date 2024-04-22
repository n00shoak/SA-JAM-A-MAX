using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SY_FoeBehavior : MonoBehaviour
{
    [SerializeField] private float speed, rotationSpeed;
    [SerializeField] private Transform target;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private KeyCode forward = KeyCode.Mouse1;

    private void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    public void Update()
    {
        rb.AddForce(transform.right * speed);
      
        // MATH
        Vector2 direction = (target.position - transform.position).normalized;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // Rotate player towards mouse
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.AngleAxis(angle, Vector3.forward), rotationSpeed * Time.deltaTime);
    }
}

