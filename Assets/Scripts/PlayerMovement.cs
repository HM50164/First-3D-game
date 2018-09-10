using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    // This is a reference to the Ridgidbody componet called "rb"
    public Rigidbody rb;

    public float fowardForce = 2000f;
    public float sidewaysForce = 500f;


	// We marked this as "Fixed"Update becuase we
    // are using it to mess with physics.
	// Update is called once per frame
	void FixedUpdate () {

        // Add a forward force
        rb.AddForce(0, 0, fowardForce * Time.deltaTime);

        if ( Input.GetKey ("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
