using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DT_WeaponStorage : MonoBehaviour
{
    [SerializeField] public CL_SO_Weapons[] allWeapons;
    [SerializeField] public List<CL_SO_Weapons> availableWeapon;
    [SerializeField] private SY_WeaponAbility ability;

    private void Start()
    {
        for(int i = 0; i < allWeapons.Length ; i++)
        {
            availableWeapon.Add(new CL_SO_Weapons());
            availableWeapon[i].procedure = ability.allAbility[allWeapons[i].SelectedEfect];
        }
    }
}
