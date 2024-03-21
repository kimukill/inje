using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    Vector2 move;
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {  
        move = ball.transform.position; 
        transform.position = new Vector3(move.x, 0, -10);
    }
}
