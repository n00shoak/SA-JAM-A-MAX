using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SY_PlayerOrientation : MonoBehaviour
{
    [SerializeField]private float rotationSpeed = 5f;

    public void MUpdate()
    {
        // Get mouse position in screen coordinates
        Vector3 mousePos = Input.mousePosition;

        // Convert mouse position to world coordinates
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        // MATH
        Vector2 direction = (mousePos - transform.position).normalized;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        
        // Rotate player towards mouse
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.AngleAxis(angle, Vector3.forward), rotationSpeed * Time.deltaTime);
    }
}
