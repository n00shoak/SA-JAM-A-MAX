using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "Weapon", menuName = "Weapon", order = 0)]
public class CL_SO_Weapons : ScriptableObject
{
    [SerializeField] public float rateOfFire, range, MultiShot,coolDown;
    [SerializeField] public Color color;
    [SerializeField] public int Level,SelectedEfect;
    [SerializeField] public UnityEvent procedure;
}
