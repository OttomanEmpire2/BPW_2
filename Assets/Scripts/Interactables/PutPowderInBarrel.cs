using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutPowderInBarrel : Interactable
{
    public Animator[] gunPowder;
    public Renderer[] cubes;
    bool hasGunpowder;

    public override void Interact()
    {
        base.Interact();
        if (PlayerCollectables.Instance.hasPowder && hasGunpowder == false && PlayerCollectables.Instance.hasGearsRotating)
        {
            PlayerCollectables.Instance.hasPowder = false;
            for (int i = 0; i < gunPowder.Length; i++)
            {
                gunPowder[i].GetComponentInChildren<Renderer>().enabled = true;
                SetAnimation(gunPowder[i]);
            }
            
        }

        if (hasGunpowder)
        {
            hasGunpowder = false;
            PlayerCollectables.Instance.hasGunPowder = true;
            for (int i = 0; i < cubes.Length; i++)
            {
                cubes[i].enabled = false;
            }
        }
    }

    public void DoneMakingGunpowder()
    {
        hasGunpowder = true;
        for (int i = 0; i < cubes.Length; i++)
        {
            gunPowder[i].GetComponentInChildren<Renderer>().enabled = false;
            cubes[i].enabled = true;
        }
    }

}
