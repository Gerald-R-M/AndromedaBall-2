using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Developer.Jackson.PlayerRedo.Scripts
{
    [RequireComponent(typeof(PlayerBase))]
    public class Movement : MonoBehaviour
    {
        private PlayerBase pb;
        private Animator anim;

        // Start is called before the first frame update
        void Start()
        {
            pb = this.GetComponent<PlayerBase>();
        }

        // Update is called once per frame
        void Update()
        {
            if (pb.dir.x != 0 || pb.dir.z != 0)
            {
                Move();
            }
            
            pb.anim.SetFloat("velocity", pb.dir.magnitude);
        }

        public void Move()
        {
            if (pb.GetState() < 2)
            {
                if (pb.GetState() != 1)
                {
                    pb.SetState(1);
                }

                pb.controller.Move
                    (pb.dir.normalized * pb.speed * Time.deltaTime);
            }

            Vector3 dirRotation = pb.dir.normalized;
            float targetAngle = Mathf.Atan2(dirRotation.x, pb.dir.z) * Mathf.Rad2Deg;

            if (pb.GetState() == 0 || pb.GetState() == 1)
            {
                pb.controller.transform.rotation = Quaternion.Euler(0f, targetAngle, 0f);
            }


        }
    }
}