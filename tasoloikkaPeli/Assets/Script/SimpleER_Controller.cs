using UnityEngine;
using System.Collections;


public class SimpleER_Controller : MonoBehaviour {

	public float speed = 6.0F;
	public float jumpSpeed = 8.0F;
	public float gravity = 20.0F;
	public float zPull = 1;
	Vector3 moveDirection = Vector3.zero;
	private float zPosition;

	void Start()
	{
		zPosition = transform.position.z;
	}
	
	void Update() 
	{
		// Animator animator = GetComponentInChildren<Animator>();

		if(Input.GetKey(KeyCode.R))
		{
			Application.LoadLevel(0);
		}

		CharacterController controller = GetComponent<CharacterController> ();

		if (!controller.isGrounded)
		{
			
//			animator.SetBool("run", false);
			
		}

		if (controller.isGrounded) 
		{
//			animator.SetBool("run", true);

			moveDirection = new Vector3 (-1f, 0f, 0f);
			
			moveDirection = transform.TransformDirection (moveDirection);
			
			moveDirection *= speed;
			//sama kuin moveDirection = moveDirection * speed;
			
			if (Input.GetButton ("Jump"))
			{
				moveDirection.y = jumpSpeed;
				
			}	

		}

		if(transform.position.z != zPosition)
		{
			moveDirection.z = (zPosition - transform.position.z) * zPull;
		}
		
		moveDirection.y -= gravity * Time.deltaTime;
		controller.Move (moveDirection * Time.deltaTime);
		//transform.position = new Vector3 (transform.position.x, transform.position.y, positionZ);

	}
	
}