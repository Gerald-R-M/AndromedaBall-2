using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UIElements;
using Random = UnityEngine.Random;

public class VoicelineManager : MonoBehaviour
{
    [SerializeField] private Voiceclip[] firstLines;
    [SerializeField] private Voiceclip[] secondLines;
    [SerializeField] private Voiceclip finalLine;
    private finalClip _fullClip;
    private bool _firstPlayed;
    private bool _secondPlayed;
    private bool _finalPlayed;
    private AudioSource _sourceRef;
    
    [Tooltip("The amount of time (in seconds) that should pass between each line"),SerializeField] private float delay;

    // Start is called before the first frame update
    void Start()
    {
        _fullClip = new finalClip(ClipSelector(firstLines), ClipSelector(secondLines), finalLine);
        _sourceRef = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!_sourceRef.isPlaying && !_firstPlayed)
        {
            playClip(finalClip.firstLine);
        }
    }

    void playClip(Voiceclip clip)
    {
        //TODO pass string to UI
        _sourceRef.PlayOneShot(clip.voiceline, clip.VolumeScale);
    }
    Voiceclip ClipSelector(Voiceclip[] clips)
    {
        Voiceclip selected;
        int rand = Random.Range(0, clips.Length);
        selected = clips[rand];
        return selected;
    }
    [Serializable]
    private class Voiceclip
    {
        public AudioClip voiceline;
        public String subtitle;
        public float VolumeScale;
    }

    [Serializable]
    class finalClip
    {
        public Voiceclip firstLine;
        public Voiceclip secondLine;
        public Voiceclip finalLine;

        public finalClip(Voiceclip first, Voiceclip second, Voiceclip final)
        {
            firstLine = first;
            secondLine = second;
            finalLine = final;
        }
    }
    
}
