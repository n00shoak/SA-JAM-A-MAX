using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SY_ennemiSpawner : MonoBehaviour
{
    [SerializeField] private float randoom;
    [SerializeField] private GameObject foe,player;
    [SerializeField] private List<SY_FoeBehavior> fbh;

    void Start()
    {
        StartCoroutine(clock());
    }

    IEnumerator clock()
    {
        GameObject ennemi = Instantiate(foe,new Vector3(Random.Range(15,-15), Random.Range(8, -8),0),transform.rotation);
        SY_FoeBehavior foebh = ennemi.GetComponent<SY_FoeBehavior>();
        foebh.target = player.transform;
        fbh.Add(foebh);
        yield return new WaitForSeconds(Random.Range(5, randoom));
        StartCoroutine(clock());
    }

    private void Update()
    {
        for (int i = 0; i < fbh.Count; i++)
        {
            if(fbh[i] == null)
            {
                fbh.RemoveAt(i);
            }
        }

        for (int i = 0; i < fbh.Count; i++)
        {
            fbh[i].MUpdate();
        }
    }
}
