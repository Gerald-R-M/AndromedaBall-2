using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerBase))]
public class Movement : MonoBehaviour
{
    private PlayerBase pb;
    // Start is called before the first frame update
    void Start()
    {
        pb = this.GetComponent<PlayerBase>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void Move()
    {
        pb.controller.Move
            (pb.dir.normalized * pb.baseSpeed * Time.deltaTime);
        Vector3 dirRotation = pb.dir.normalized;
        float targetAngle = Mathf.Atan2(dirRotation.x, pb.dir.z) * Mathf.Rad2Deg;

        pb.controller.transform.rotation = Quaternion.Euler(0f, targetAngle, 0f);
    }
}
