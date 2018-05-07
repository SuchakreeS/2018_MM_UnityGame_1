using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drag : MonoBehaviour {
	public float moveSpeed;
	public float jumpPower;
	public Rigidbody rb;
	private bool isGrounded;
	private bool right_direction;
	public GameObject pingu;
	// Use this for initialization
	void Start () {
		moveSpeed = 3f;
		jumpPower = 8f;
		right_direction = true;
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space")  && isGrounded == true){
			rb.AddForce(transform.up * jumpPower,ForceMode.Impulse);
			isGrounded = false;
		}
		if (Input.GetKey("left"))
			pingu.transform.Rotate(0, -20, 0);
            print("up arrow key is held left");
        
        if (Input.GetKey("right"))
			
			pingu.transform.Rotate(0, 20, 0);
            print("down arrow key is held right");
		
		transform.Translate(moveSpeed*Input.GetAxis("Horizontal")*Time.deltaTime, 0f, 0f);
	}

	void OnCollisionEnter()
 {
     isGrounded = true;
 }

}
