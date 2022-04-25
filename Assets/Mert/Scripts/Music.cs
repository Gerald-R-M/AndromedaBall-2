using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioListener))]
[RequireComponent(typeof(AudioSource))]
class Music : MonoBehaviour
{
    private static Music instance = null;

    private AudioSource srcRef;
    [SerializeField] public AudioClip[] music = new AudioClip[1];
    private bool firstPlay;
    private bool looping = false;

    public static Music Instance
    {
        get
        {
            if (instance == null)
            {
                instance = (Music)FindObjectOfType(typeof(Music));
            }
            return instance;
            
        }
    }

    void Awake()
    {
        if (Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
            srcRef = gameObject.GetComponent<AudioSource>();
            srcRef.clip = music[0];
            srcRef.Play(0);
            Debug.Log("File being played is: " + srcRef.clip.name);
            firstPlay = true;
        }
    }

    private void Update()
    {
        if(!srcRef.isPlaying)
        {
            Debug.Log("First song playthrough finished");
            firstPlay = false;

        }
        if(!firstPlay && !looping)
        {
            Debug.Log("Looping should start here current file being played is: " + srcRef.clip.name);
            srcRef.loop = true;
            srcRef.clip = music[1];
            srcRef.Play(0);
            looping = true;
        }
    }
}