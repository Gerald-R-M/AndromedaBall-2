using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiveWireMine : MonoBehaviour
{
    /// <summary>
    /// Inspector Variables
    /// </summary>
    [SerializeField] private float MaxActiveTime = 10.0f;
    [SerializeField] private float ExplosionDuration = 0.2f; //This is likely placeholder until we have an animation to sync with this ability

    /// <summary>
    /// Private Variables
    /// </summary>
    private float timeActive;
    private SphereCollider ExplosionHitbox;
    
    // Start is called before the first frame update
    void Start()
    {
        ExplosionHitbox = GetComponentInChildren<SphereCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        timeActive += Time.deltaTime;
        if (timeActive > MaxActiveTime)
        {
            ExplodeMine();
        }
    }

    public void ExplodeMine()
    {
        ExplosionHitbox.enabled = true;
        Destroy(gameObject,ExplosionDuration);
    }
}
