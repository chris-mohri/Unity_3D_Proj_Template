using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class DashAbility : Ability
{
    public float dashVelocity;

    public override void Activate (GameObject parent)
    {
        ThirdPersonMovementScript tpms = parent.GetComponent<ThirdPersonMovementScript>();
        tpms.sprintContinue=true;
        tpms.AddImpact(tpms.moveDir, dashVelocity);
        //Debug.Log("Hell yeah");
    }
}
