using UnityEngine;
using System.Collections;


public class SimpleER_Controller : MonoBehaviour {

	public float speed = 6.0F;
	public float jumpSpeed = 8.0F;
	public float gravity = 20.0F;
	Vector3 moveDirection = Vector3.zero;
	public float ftimeScale; //hidastus
	//public gameManager.gameState g;

	//public Vector3 moveDirection;

	void Start()
	{
		//speed = 10.0f;
	
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
				
				if (Input.GetButton ("Fire1") && !Input.GetButton ("Jump"))  //kun painaa CTRL, vauhti hidastuu
					moveDirection.x = moveDirection.x /10f;
				
				if (Input.GetButton ("Jump")&& !Input.GetButton ("Fire1"))
				{
					moveDirection.y = jumpSpeed;
					
				}	
				
//				if (Input.GetButton ("Jump") && Input.GetButton ("Fire1"))
//				{
//					moveDirection.y = jumpSpeed * 1.3f;
//					moveDirection.x *= 1.4f; 
//				}
				
			}

			if(Input.GetKey(KeyCode.LeftShift))
			Time.timeScale = ftimeScale*0.1F;
			else
			Time.timeScale = ftimeScale;
			
			
			if (Input.GetButton ("Fire2"))  //kun painaa Alt, vauhti hidastuu ilmassakin; komento ei isGrounded -lohkon sisällä!
				moveDirection.x = moveDirection.x /1.5f;
			
			
			moveDirection.y -= gravity * Time.deltaTime;
			controller.Move (moveDirection * Time.deltaTime);

		
	}

	
}