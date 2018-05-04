using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drag : MonoBehaviour {
	public float moveSpeed;
	public float jumpPower;
	public Rigidbody rb;
	private bool isGrounded;
	// Use this for initialization
	void Start () {
		moveSpeed = 3f;
		jumpPower = 8f;
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space")  && isGrounded == true){
			rb.AddForce(transform.up * jumpPower,ForceMode.Impulse);
			isGrounded = false;
		}
		transform.Translate(moveSpeed*Input.GetAxis("Horizontal")*Time.deltaTime, 0f, 0f);
	}

	void OnCollisionEnter()
 {
     isGrounded = true;
 }

}
