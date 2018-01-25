using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
    public float jumpspeed;

    private Rigidbody rb;

    //private bool canDoubleJump;
    private int counter = 1;

    public AudioSource randomSound;
    public AudioClip[] audioSources;

    void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
        Vector3 jump= new Vector3(0.0f, jumpspeed, 0.0f);

        rb.AddForce (movement * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (counter <= 2)
            {
                rb.AddForce(jump);
                counter++;

                randomSound.clip = audioSources[Random.Range(0, audioSources.Length)];
                randomSound.Play();

            }
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            counter = 1;
        }
    }
    /*void OnCollisionEnter(Collision collision)
    {
        // Watered-down example for simple implementation.
        float simpleAxis = Vector3.Dot(collision.contacts[0].normal, -Physics.gravity.normalized);
        if (simpleAxis > 0.7f)
        {
            isGrounded = true;
            // Disallow double jump in case of walking off cliff
            canDoubleJump = false;
        }
    }
    void Jump()
    {
        if (isGrounded)
        {
            // Perform basic jump if grounded and allow double jump
            canDoubleJump = true;
        }
        else if (canDoubleJump)
        {
            // Double Jump Here
            canDoubleJump = false;
        }
    }*/

}