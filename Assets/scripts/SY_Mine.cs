using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SY_Mine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Boom());
    }
    
    private IEnumerator Boom()
    {
        yield return new WaitForSeconds(3f);
        ParticleSystem ps = gameObject.GetComponent<ParticleSystem>();
        ps.Play();
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }
}
