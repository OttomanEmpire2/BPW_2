using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlowRockUp : Interactable
{
    public override void Interact()
    {
        base.Interact();
        if (PlayerCollectables.Instance.hasTNT)
        {
            PlayerCollectables.Instance.hasTNT = false;
            AudioManager.Instance.PlaySound(0);
            gameObject.SetActive(false);
        }

    }
}
