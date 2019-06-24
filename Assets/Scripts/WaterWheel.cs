using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterWheel : MonoBehaviour
{
    private void OnEnable()
    {
        if (PlayerCollectables.Instance.hasGearsRotating)
        {
            GetComponent<Animator>().SetTrigger("Interact");
        }
    }
}
