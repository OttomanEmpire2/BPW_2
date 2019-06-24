using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollectables : MonoBehaviour
{
    private static PlayerCollectables instance;
    public static PlayerCollectables Instance
    {
        get { return instance; }
        private set { instance = value; }
    }

    [SerializeField] private AudioClip turningGears;

    public bool hasGearsRotating;
    public bool hasPowder;
    public bool hasGunPowder;
    public bool hasGear;
    public bool hasTNT;

    private int gearsRotating;

    private void Awake()
    {
        Instance = null;
        if (Instance == null)
        {
            Instance = this;
        } else
        {
            Destroy(gameObject);
        }
    }

    public void AddGear()
    {
        gearsRotating++;
        if(gearsRotating == 2)
        {
            hasGearsRotating = true;
            foreach (var audiosource in FindObjectsOfType<AudioSource>())
            {
                if(audiosource.clip == turningGears)
                {
                    audiosource.enabled = true;
                }
            }
        }
    }

}
