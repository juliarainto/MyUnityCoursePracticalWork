using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour {

    public float speed; //cube movement speed
    public float leftLimit; // Max X -position to move cube to the left
    public float rightLimit; // Max X- position to move cube to the right
    private bool left; // Boolean to determine if to move left or right

	// Use this for initialization
	void Start () {
        left = true; // Start with move to left
		
	}
	
	// Update is called once per frame
	void Update () {
        if (left)
        {
            // Move the object this script is hooked on, to left
            transform.Translate(Vector3.left * Time.deltaTime * speed);
            if (transform.position.x <= leftLimit)
            {
                //Until we reach the Max X-left position, then change direction to right
                left = false;
            }
        }
        else
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
            //Until we reach the Max X-right position, then change direction to left
            if (transform.position.x >= rightLimit)
            {
                left = true;
            }
        }
		
	}
}
