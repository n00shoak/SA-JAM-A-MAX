using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MN_PlayerMovementManager : CL_Manager
{
    [SerializeField] private SY_PlayerMovement S_plMovement;
    [SerializeField] private SY_PlayerOrientation S_plOrientation;


    // Update is called once per frame
    void Update()
    {
        S_plMovement.MUpdate();
        S_plOrientation.MUpdate();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.layer == LayerMask.NameToLayer("WeaponReroll"))
        {
            Destroy(collision.collider.gameObject);
            MN_manager.GetManagerfromGeneral<MN_WeaponManager>().selectedWeapon = Random.Range(0, 2);
        }
    }
}
