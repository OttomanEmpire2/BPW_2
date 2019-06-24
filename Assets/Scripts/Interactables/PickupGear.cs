using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupGear : Interactable
{
    private void OnEnable()
    {
        if (PlayerCollectables.Instance.hasGearsRotating)
        {
            gameObject.SetActive(false);
        }
    }


    public override void Interact()
    {
        base.Interact();
        //transform.position = FindObjectOfType<PlayerInteract>().pickupPosition.position;
        transform.SetParent(FindObjectOfType<PlayerInteract>().pickupPosition);
        PlayerCollectables.Instance.hasGear = true;
        GetComponent<Collider>().enabled = false;
    }
}
