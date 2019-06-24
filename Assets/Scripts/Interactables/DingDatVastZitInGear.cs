using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DingDatVastZitInGear : Interactable
{
    public Animator[] DeEersteTweeSchroeven;
    public Animator[] pivotMolens;

    private void OnEnable()
    {
        if (PlayerCollectables.Instance.hasGearsRotating)
        {
            for (int i = 0; i < pivotMolens.Length; i++)
            {
                SetAnimation(pivotMolens[i]);
            }
            gameObject.SetActive(false);
        }
    }

    public override void Interact()
    {
        base.Interact();
        for (int i = 0; i < DeEersteTweeSchroeven.Length; i++)
        {
            SetAnimation(DeEersteTweeSchroeven[i].GetComponent<Animator>());
        }
        PlayerCollectables.Instance.AddGear();

        if (PlayerCollectables.Instance.hasGearsRotating)
        {
            for (int i = 0; i < pivotMolens.Length; i++)
            {
                SetAnimation(pivotMolens[i]);
            }
        }
        Destroy(gameObject);
    }
}
