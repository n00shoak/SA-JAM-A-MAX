using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SY_FoeBehavior : MonoBehaviour
{
    [SerializeField] private float speed, rotationSpeed;
    [SerializeField] private GameObject loot;
    [SerializeField] public Transform target;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private int pv = 3;

    private void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    public void MUpdate()
    {
        rb.AddForce(transform.right * speed);
      
        // MATH
        Vector2 direction = (target.position - transform.position).normalized;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // Rotate player towards mouse
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.AngleAxis(angle, Vector3.forward), rotationSpeed * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        pv--; 
        if(pv <= 0)
        {
            if(Random.Range(0,2) == 1)
            {
                Instantiate(loot, transform);
            }

            Destroy(gameObject);
        }
    }
}

