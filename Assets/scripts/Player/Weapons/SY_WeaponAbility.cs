using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SY_WeaponAbility : MonoBehaviour
{
    [SerializeField] private GameObject projectileA;

    public void ShootBullet(float speed = 10,int Ammount = 1, float Spread = 0)
    {
        GameObject bullet = Instantiate(projectileA,transform);
        Rigidbody bulletRB =  bullet.GetComponent<Rigidbody>();
        bulletRB.velocity = transform.up * speed;
    }
}
