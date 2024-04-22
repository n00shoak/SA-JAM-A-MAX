using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class SY_WeaponAbility : MonoBehaviour
{
    [SerializeField] private GameObject projectileA;
    [SerializeField] public List<UnityEvent> allAbility;

    public void ShootBullet()
    {
        Debug.Log("caca");
        GameObject bullet = Instantiate(projectileA,transform);
        bullet.transform.parent = null;
        Rigidbody2D bulletRB =  bullet.GetComponent<Rigidbody2D>();
        bulletRB.velocity = transform.right * 10;
    }
}
