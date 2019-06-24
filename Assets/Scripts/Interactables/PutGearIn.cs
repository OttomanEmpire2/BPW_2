using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutGearIn : Interactable
{
    public Animator[] allGears;

    public Animator[] pivotMolens;

    public override void Interact()
    {
        base.Interact();
        if (PlayerCollectables.Instance.hasGear)
        {
            PlayerCollectables.Instance.hasGear = false;
            Destroy(FindObjectOfType<PlayerInteract>().pickupPosition.transform.GetChild(0).gameObject);
            for (int i = 0; i < allGears.Length; i++)
            {
                SetAnimation(allGears[i]);
            }
            PlayerCollectables.Instance.AddGear();
            GetComponent<Renderer>().enabled = true;

            if (PlayerCollectables.Instance.hasGearsRotating)
            {
                for (int i = 0; i < pivotMolens.Length; i++)
                {
                    SetAnimation(pivotMolens[i]);
                }
            }
        }
    }
}
