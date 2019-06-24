using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeTNT : Interactable
{
    public override void Interact()
    {
        base.Interact();
        if (PlayerCollectables.Instance.hasGunPowder)
        {
            PlayerCollectables.Instance.hasGunPowder = false;
            PlayerCollectables.Instance.hasTNT = true;
        }
        
    }

}
