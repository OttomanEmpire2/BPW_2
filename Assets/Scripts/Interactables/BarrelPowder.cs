using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelPowder : Interactable
{
    public override void Interact()
    {
        base.Interact();
        //SetAnimation(GetComponent<Animator>());
        PlayerCollectables.Instance.hasPowder = true;
    }
}
