using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public float shootingRange = 10;
    public Transform pickupPosition;


    private void Update()
    {
        RayInput();
    }

    private void RayInput()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            ShootRay();
        }
    }

    private void ShootRay()
    {
        Debug.Log("shot ray");

        RaycastHit hit;
        Ray ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out hit, shootingRange)){
            if (hit.transform.GetComponent<Interactable>() != null)
            {
                hit.transform.GetComponent<Interactable>().Interact();
            }
        }


    }

    public IEnumerator SetControllerActive()
    {
        yield return new WaitForSeconds(0.2f);
        transform.parent.GetComponent<CharacterController>().enabled = true;
    }

}
