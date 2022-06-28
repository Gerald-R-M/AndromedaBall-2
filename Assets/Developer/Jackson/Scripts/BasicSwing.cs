using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicSwing : MonoBehaviour
{
    [SerializeField] private BoxCollider hitbox;
    
    public float force = 5f;

    private InputProcessor input;
    private Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {
        input = GetComponent<InputProcessor>();
        anim = GetComponent<Animator>();
        hitbox.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (this.tag == "Player 1")
        {
            if (input.p1_swing)
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
