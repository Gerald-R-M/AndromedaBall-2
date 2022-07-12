using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class DebugInputIcon : MonoBehaviour
{
    public Sprite active;

    public Sprite inactive;

    public InputAction inputAction;
    
    
    

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Image>().sprite = inactive;
    }

    // Update is called once per frame
    void Update()
    {
        if (inputAction.IsPressed() && this.GetComponent<Image>().sprite != active)
        {
            Activate();
        }
    
        else if (inputAction.WasReleasedThisFrame())
        {
            Deactivate();
        }
    }

    public void Activate()
    {
        this.GetComponent<Image>().sprite = active;
    }

    public void Deactivate()
    {
        this.GetComponent<Image>().sprite = inactive;
    }
}
