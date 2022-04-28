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
        hitbox.gameObject.SetActive(false);
        anim = GetComponent<Animator>();
        input = GetComponent<InputProcessor>();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.tag == "Player 1")
        {
            if (input.swing1)
            {
                anim.SetTrigger("hit");
            }
        }

        if (this.tag == "PLayer 2")
        {
            if (input.swing2)
            {
                anim.SetTrigger("hit");
            }
        }
    }

    void EnableHitbox()
    {
        hitbox.gameObject.SetActive(true);
    }

    void DisableHitbox()
    {
        hitbox.gameObject.SetActive(false);
    }
}
