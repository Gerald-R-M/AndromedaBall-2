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
    // Start is called before the first frame update
    void Start()
    {
        _fullClip = new finalClip(ClipSelector(firstLines), ClipSelector(secondLines), finalLine);

    }

    // Update is called once per frame
    void Update()
    {
        
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
        [SerializeField] private AudioClip voiceline;
        [SerializeField] private String subtitle;
        [SerializeField] private float VolumeScale;
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
