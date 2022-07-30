using System.Collections;
using System.Collections.Generic;
using Developer.Jackson.PlayerRedo.Scripts;
using UnityEngine;

public class BasicSwing : MonoBehaviour
{
    [SerializeField] private BoxCollider hitbox;
    
    public float force = 5f;

    private InputProcessor input;
    private Animator anim;
    private PlayerBase pb;
    
    // Start is called before the first frame update
    void Start()
    {
        input = GetComponent<InputProcessor>();
        pb = GetComponent<PlayerBase>();
        anim = GetComponent<Animator>();
        hitbox.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (this.tag == "Player 1")
        {
            if (input.p1_swing_press)
            {
                //Actions for pressing down the swing button
                if (pb.GetState() == 0 || pb.GetState() == 1)
                {
                    SetSwingState(1);
                    pb.SetState(2);
                }
            }

            if (input.p1_swing_release)
            {
                if (pb.GetState() == 2)
                {
                    SetSwingState(2);
                    pb.SetState(3);
                }
            }
        }

        if (this.tag == "Player 2")
        {
            if (input.p2_swing)
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

    void SetSwingState(int newState)
    {
        anim.SetInteger("swingState", newState);
    }

}
