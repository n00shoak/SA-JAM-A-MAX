using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MN_WeaponManager : CL_Manager
{
    [SerializeField] private DT_WeaponStorage storage;
    [SerializeField] private List<float> coolDowns, currentCoolDowns;
    [SerializeField] public int selectedWeapon ;

    private void Start()
    {
        for (int i = 0; i < storage.availableWeapon.Count; i++)
        {
            coolDowns.Add(storage.availableWeapon[i].coolDown);
            currentCoolDowns.Add(0);
        }
        StartCoroutine(CD(0));
    }


    private void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) && currentCoolDowns[selectedWeapon] <= 0)
        {
            currentCoolDowns[selectedWeapon] = coolDowns[selectedWeapon];
            StartCoroutine(CD(selectedWeapon));
            storage.availableWeapon[selectedWeapon].procedure.Invoke();
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

    private IEnumerator autoWeaponChange(int wichCD)
    {
        selectedWeapon = Random.Range(0, 3);
        yield return new WaitForSeconds(10);
    }

}
