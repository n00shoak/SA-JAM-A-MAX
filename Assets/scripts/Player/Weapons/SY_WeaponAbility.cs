using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class SY_WeaponAbility : MonoBehaviour
{
    [SerializeField] private GameObject projectileA, MineA;
    [SerializeField] private ParticleSystem flame;
    [SerializeField] public List<UnityEvent> allAbility;
    private bool laserOn;

    public void ShootBullet()
    {
        GameObject bullet = Instantiate(projectileA,transform);
        bullet.transform.parent = null;
        Rigidbody2D bulletRB =  bullet.GetComponent<Rigidbody2D>();
        bulletRB.velocity = bulletRB.transform.right * 100;

        GameObject bulletb = Instantiate(projectileA, transform.position, transform.rotation * Quaternion.Euler(0, 0, 30));
        bulletb.transform.parent = null;
        Rigidbody2D bulletbRB = bulletb.GetComponent<Rigidbody2D>();
        bulletbRB.velocity = bulletbRB.transform.right * 100;
    }

    public void flameThrower()
    {
        flame.Play();
    }

    public void Mine()
    {
        GameObject mine = Instantiate(MineA, transform);
        mine.transform.parent = null;
    }
}
