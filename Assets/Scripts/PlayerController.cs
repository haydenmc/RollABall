using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    public float MovementForce;
    private Rigidbody rigidBody;

	// Use this for initialization
	void Start ()
    {
        rigidBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    // Called every frame before physics calculations
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        var movementVector = new Vector3(moveHorizontal, 0, moveVertical);
        rigidBody.AddForce(movementVector * MovementForce);
    }
}
