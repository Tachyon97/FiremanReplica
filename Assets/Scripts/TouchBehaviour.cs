using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchBehaviour : MonoBehaviour
{
    public bool left = false;
    public delegate void ButtonPressed();
    public static event ButtonPressed OnLeftPressed;
    public static event ButtonPressed OnRightPressed;

    private void OnMouseDown()
    {
        if(OnLeftPressed != null && left)
        {

            OnLeftPressed();
        } else
        {
            OnRightPressed?.Invoke();
        }
    }

}
