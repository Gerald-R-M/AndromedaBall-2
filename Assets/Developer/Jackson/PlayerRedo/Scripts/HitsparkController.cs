using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitsparkController : MonoBehaviour
{
    [SerializeField] private ParticleSystem particle = null;

    public void Play(Vector3 rot)
    {
        //particle.gameObject.transform.rotation = Quaternion.Euler(rot);
        particle.Play();
    }
}
