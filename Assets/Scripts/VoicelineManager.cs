using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Random = UnityEngine.Random;

public class VoicelineManager : MonoBehaviour
{
    [SerializeField] private Text subtitleRef;
    [SerializeField] private Voiceclip[] firstLines;
    [SerializeField] private Voiceclip[] secondLines;
    [SerializeField] private Voiceclip finalLine;
    private FinalClip _fullClip;
    private bool _firstPlayed;
    private bool _secondPlayed;
    private bool _finalPlayed;
    private AudioSource _sourceRef;
    private float _timePassed;
    [Tooltip("The amount of time (in seconds) that should pass between each line"),SerializeField] private float delay;

    // Start is called before the first frame update
    void Start()
    {
        //TODO prevent all gameplay while voicelines are being played
        _fullClip = new FinalClip(ClipSelector(firstLines), ClipSelector(secondLines), finalLine);
        _sourceRef = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!_sourceRef.isPlaying && _timePassed >= delay)
        {
            if(!_firstPlayed)
            {
                PlayClip(_fullClip.firstLine);
                _firstPlayed = true;
            }
            else if (_firstPlayed && !_secondPlayed)
            {
                PlayClip(_fullClip.secondLine);
                _secondPlayed = true;
            }
            else if (_firstPlayed && _secondPlayed && !_finalPlayed)
            {
                PlayClip(_fullClip.finalLine);
                _finalPlayed = true;
            }
            _timePassed += Time.deltaTime;
        }
        else
        {
            _timePassed = 0;
        }
    }

    private void PlayClip(Voiceclip clip)
    {
        subtitleRef.text = clip.subtitle;
        _sourceRef.PlayOneShot(clip.voiceline, clip.volumeScale);
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
        public float volumeScale;
    }

    [Serializable]
    class FinalClip
    {
        public Voiceclip firstLine;
        public Voiceclip secondLine;
        public Voiceclip finalLine;

        public FinalClip(Voiceclip first, Voiceclip second, Voiceclip final)
        {
            firstLine = first;
            secondLine = second;
            finalLine = final;
        }
    }
    
}
