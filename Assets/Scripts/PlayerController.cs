using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;
    public float rotationSpeed;
    //CharacterController controller;

    void Start()
    {
        //controller = GetComponent<CharacterController>();
    }

    
    void Update()
    {
		/*
		transform.Rotate (new Vector3(0, Input.GetAxis ("Horizontal") * rotationSpeed, 0));
        Vector3 forward = Input.GetAxis ("Vertical") * transform.forward * moveSpeed;

        controller.Move (forward);
        controller.SimpleMove (Physics.gravity);
		transform.Rotate (new Vector3 (-xRotation, 0, 0));

		*/
		float movementHorizontal = Input.GetAxis("Horizontal");
		float movementVertical = Input.GetAxis("Vertical");

		Vector3 movementVector = new Vector3(movementHorizontal, 0.0f, movementVertical);

		GetComponent<Rigidbody>().AddForce(movementVector * moveSpeed * Time.deltaTime);

    }

	void FixedUpdate()
	{

	}

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
        }
    }
}
