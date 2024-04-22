using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MN_WeaponManager : CL_Manger
{
    [SerializeField] private DT_WeaponStorage storage;
    [SerializeField] private List<float> coolDowns, currentCoolDowns;

    private void Start()
    {
        for(int i =0; i< storage.availableWeapon.Count; i++)
        {
            coolDowns.Add(storage.availableWeapon[i].coolDown);
        }
        currentCoolDowns = coolDowns;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) && currentCoolDowns[0] <= 0)
        {
            currentCoolDowns[0] = coolDowns[0];
            StartCoroutine(CD(0));
            Debug.Log("PIOU");
            storage.availableWeapon[0].procedure.Invoke();
        }
    }

    private IEnumerator CD(int wichCD)
    {
        if(currentCoolDowns[wichCD] > 0)
        {
            yield return new WaitForSeconds(0.1f);
            currentCoolDowns[wichCD] -= 0.1f;
            StartCoroutine(CD(wichCD));
        }
    }
}
