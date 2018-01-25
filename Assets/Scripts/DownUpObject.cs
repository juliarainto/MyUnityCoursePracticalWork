using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownUpObject : MonoBehaviour
{

    public float speed; //cube movement speed
    public float upLimit; // Max Y -position to move cube to the up
    public float downLimit; // Max Y- position to move cube to the down
    private bool down; // Boolean to determine if to move up or down

    // Use this for initialization
    void Start()
    {
        down = true; // Start with move to down

    }

    // Update is called once per frame
    void Update()
    {
        if (down)
        {
            // Move the object this script is hooked on, to left
            transform.Translate(Vector3.down * Time.deltaTime * speed);
            if (transform.position.y <= downLimit)
            {
                //Until we reach the Max X-left position, then change direction to right
                down = false;
            }
        }
        else
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed);
            //Until we reach the Max X-right position, then change direction to left
            if (transform.position.y >= upLimit)
            {
                down = true;
            }
        }

    }
}
