using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    private void OnEnable()
    {
        TouchBehaviour.OnLeftPressed += left;
        TouchBehaviour.OnRightPressed += right;
    }
    private void OnDisable()
    {
        TouchBehaviour.OnLeftPressed -= left;
        TouchBehaviour.OnRightPressed -= right;
    }
    private void left()
    {
        Debug.Log(" Pip WTF");
    }
    private void right()
    {
        Debug.Log(" Pip !WTF");
    }
}
