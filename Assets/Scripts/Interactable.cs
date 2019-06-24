using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public class Interactable : MonoBehaviour
{
    public virtual void Interact()
    {
        
    }

    public void SetAnimation(Animator animator)
    {
        //animator.SetBool("IsInteracting", true);
        animator.SetTrigger("Interact");
    }
}
