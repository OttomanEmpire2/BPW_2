using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EndDemo : Interactable
{
    public override void Interact()
    {
        base.Interact();
        SceneManager.LoadScene(0, LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync(1);
        StartCoroutine(UnloadScene());
    }

    IEnumerator UnloadScene()
    {
        yield return new WaitForSeconds(2);
        Cursor.lockState = CursorLockMode.None;
        Destroy(PlayerCollectables.Instance.gameObject);
        SceneManager.UnloadSceneAsync(2);

    }
}

