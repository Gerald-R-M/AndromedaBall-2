using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]

public class sfxManager : MonoBehaviour
{
    [SerializeField] private AudioSource srcRef;
    private static sfxManager _Instance;

    // Start is called before the first frame update
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (_Instance != null && _Instance != this)
            Destroy(gameObject);
        else
            _Instance = this;

    }
    private void Start()
    {
        srcRef = FindObjectOfType<AudioSource>();
    }
    public void PlaySfx(AudioClip effect)
    {
        srcRef.PlayOneShot(effect, 1.0f);
    }
}
