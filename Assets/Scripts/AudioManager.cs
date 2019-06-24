using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private static AudioManager instance;
    public static AudioManager Instance
    {
        get { return instance; }
        private set { instance = value; }
    }

    public AudioSource audioSource;
    [Header("Put sounds here")]
    public AudioClip[] audioClips;

    private void Awake()
    {
        Instance = null;
        if(Instance == null)
        {
            Instance = this;
        } else
        {
            Destroy(gameObject);
        }

        audioSource = GetComponent<AudioSource>();
    }

    public void PlaySound(int soundIndex)
    {
        audioSource.clip = audioClips[soundIndex];
        audioSource.Play();
    }


}
