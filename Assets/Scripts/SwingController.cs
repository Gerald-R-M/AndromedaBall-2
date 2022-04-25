using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingController : MonoBehaviour
{
    [SerializeField] private BoxCollider hitbox;

    [SerializeField] private float force = 50f;

    private float velRef;

    private Animator anim;
    private InputProcessor input;


    // Start is called before the first frame update
    void Start()
    {
        hitbox.enabled = false;
        anim = GetComponent<Animator>();
        input = GetComponent<InputProcessor>();
    }

    // Update is called once per frame
    void Update()
    {
        if (input.swing1)
        {
            anim.SetTrigger("hit");
        }
    }

    void EnableHitbox()
    {
        hitbox.enabled = true;
    }

    void DisableHitbox()
    {
        hitbox.enabled = false;
    }
}
