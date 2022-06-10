using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonEventTrigger : EventTrigger
{
    public override void OnPointerEnter(PointerEventData data)
    {
        transform.Translate(100, 0, 0);
    }
    public override void OnPointerExit(PointerEventData data)
    {
        transform.Translate(-100, 0, 0);
    }
}
