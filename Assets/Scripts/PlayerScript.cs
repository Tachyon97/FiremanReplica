using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    //Fireman Controller yehaw
    public List<Transform> fixedPositions = new List<Transform>();
    public int setPos = 0;

    private void Start()
    {
        UpdatePosition();
    }
    
    private void OnDisable()
    {
        TouchBehaviour.OnLeftPressed -= OnleftPressed;
        TouchBehaviour.OnRightPressed -= OnRightPressed;
    }

    private void OnEnable()
    {
        TouchBehaviour.OnLeftPressed += OnleftPressed;
        TouchBehaviour.OnRightPressed += OnRightPressed;
    }

    public void OnleftPressed()
    {
        Debug.Log("Left");
        if(DoLeft())
        {
            setPos++;
            UpdatePosition();
        }

    }
    public void OnRightPressed()
    {
        Debug.Log("Right");
        if(DoRight())
        {
            setPos--;
            UpdatePosition();
        }

    }
    private void UpdatePosition()
    {
        transform.position = fixedPositions[setPos].position;
    }

    private bool DoRight()
    {
        if(transform.position != fixedPositions[0].position)
        {
            return true;
        }
        return false;
    }
    private bool DoLeft()
    {
        if(transform.position != fixedPositions[2].position)
        {
            return true;
        }
        return false;
    }

}
