using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMovement : MonoBehaviour
{
    public void MovementOfButton(float units) {
        transform.Translate(units, 0, 0);
    }
}
