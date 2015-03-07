using UnityEngine;
using System.Collections;


public class SimpleER_Controller : MonoBehaviour {

	public float speed = 6.0F;
	public float jumpSpeed = 8.0F;
	public float gravity = 20.0F;
	Vector3 moveDirection = Vector3.zero;

	void Start()
	{

	}
	
	void Update() 
	{

		if(Input.GetKey(KeyCode.R))
		{
			Application.LoadLevel(0);
		}

		CharacterController controller = GetComponent<CharacterController> ();
		
			if (controller.isGrounded) 
			{

				moveDirection = new Vector3 (-1f, 0f, 0f);
				
				moveDirection = transform.TransformDirection (moveDirection);
				
				moveDirection *= speed;
				//sama kuin moveDirection = moveDirection * speed;
				
				if (Input.GetButton ("Jump"))
				{
					moveDirection.y = jumpSpeed;
					
				}	

			}
			
			moveDirection.y -= gravity * Time.deltaTime;
			controller.Move (moveDirection * Time.deltaTime);

	}
	
}