using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeSnakeWalk : MonoBehaviour {
    public GameObject snake;
    public float speed = 1f; 
   
    // Update is called once per frame
    void Update()
    {
        MoveSnake();
        Stop();    
    }

    void MoveSnake()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }


    void Stop()
    {
        if(transform.position.z <= 4.3f)
        {
            speed = 0f; 
        }
    }


}
