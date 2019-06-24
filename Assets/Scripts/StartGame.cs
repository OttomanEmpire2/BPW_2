using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    bool isClickedon;

    public void LoadScenes()
    {
        if (!isClickedon)
        {
            isClickedon = false;
            SceneManager.LoadScene(1, LoadSceneMode.Additive);
            SceneManager.LoadScene(2, LoadSceneMode.Additive);
            StartCoroutine(UnloadScene());
        }
    }

    IEnumerator UnloadScene()
    {
        yield return new WaitForSeconds(2);
        SceneManager.UnloadSceneAsync(0);

    }
}
