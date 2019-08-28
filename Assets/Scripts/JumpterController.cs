using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpterController : MonoBehaviour
{
    [SerializeField]
    private List<Transform> positions = new List<Transform>();
    int currentPosition = 0;
    float lastMove;
    public float moveDelay = 1.0f;
    private void Start()
    {
        transform.position = positions[currentPosition].position;
        lastMove = Time.time;
        StartCoroutine(Move());
    }


    private void MoveToNextPosition()
    {
        Debug.Log("executed");
        currentPosition++;
        if(currentPosition >= positions.Count)
        {
            GameObject parent = transform.parent.gameObject;
            Destroy(parent);
        } else
        {
            transform.position = positions[currentPosition].position;
        }
    }
    
    //Coroutine
    IEnumerator Move()
    {
        while (true){
            yield return new WaitForSeconds(moveDelay);
            MoveToNextPosition();
        }
        
    }


}
