using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : Interactable
{
    public int thisSide, otherSide;
    public Transform otherPos;
    PlayerInteract playerObject;

    private void Start()
    {
        playerObject = FindObjectOfType<PlayerInteract>();
    }

    public override void Interact()
    {
        base.Interact();
        //if (isOutside)
        //{
        //isOutside = false;
        AudioManager.Instance.PlaySound(0);
        playerObject.transform.parent.GetComponent<CharacterController>().enabled = false;
        playerObject.transform.parent.transform.position = otherPos.position;
        playerObject.StartCoroutine(playerObject.SetControllerActive());
        SceneManager.LoadScene(otherSide, LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync(thisSide);
        //}
        //else
        //{
        //    isOutside = true;
        //    SceneManager.LoadScene(outside, LoadSceneMode.Additive);
        //    SceneManager.UnloadSceneAsync(inside);
        //}
    }

}
