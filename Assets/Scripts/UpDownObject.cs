using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDownObject : MonoBehaviour
{

    public float speed; //cube movement speed
    public float upLimit; // Max Y -position to move cube to the up
    public float downLimit; // Max Y- position to move cube to the down
    private bool up; // Boolean to determine if to move up or down

    // Use this for initialization
    void Start()
    {
        up = true; // Start with move to up

    }

    // Update is called once per frame
    void Update()
    {
        if (up)
        {
            // Move the object this script is hooked on, to left
            transform.Translate(Vector3.up * Time.deltaTime * speed);
            if (transform.position.y >= upLimit)
            {
                //Until we reach the Max X-left position, then change direction to right
                up = false;
            }
        }
        else
        {
            transform.Translate(Vector3.down * Time.deltaTime * speed);
            //Until we reach the Max X-right position, then change direction to left
            if (transform.position.y <= downLimit)
            {
                up = true;
            }
        }

    }
}
