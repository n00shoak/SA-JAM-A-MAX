using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SY_BulletScript : MonoBehaviour
{

    void Start()
    {
        StartCoroutine(lifeTime());
    }

    IEnumerator lifeTime()
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }
}
