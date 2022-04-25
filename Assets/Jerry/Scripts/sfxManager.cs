using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]

public class sfxManager : MonoBehaviour
{
    [SerializeField] [HideInInspector] public AudioSource srcRef;
    // Start is called before the first frame update
    private void Start()
    {
        srcRef = GetComponent<AudioSource>();
    }
    public void playSFX(AudioClip effect)
    {
        srcRef.clip = effect;
        srcRef.PlayOneShot(effect, 1.0f);

    }
}
