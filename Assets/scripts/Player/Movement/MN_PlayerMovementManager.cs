using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MN_PlayerMovementManager : CL_Manger
{
    [SerializeField] private SY_PlayerMovement S_plMovement;
    [SerializeField] private SY_PlayerOrientation S_plOrientation;


    // Update is called once per frame
    void Update()
    {
        S_plMovement.MUpdate();
        S_plOrientation.MUpdate();
    }
}
