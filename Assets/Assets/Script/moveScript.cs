using UnityEngine;
using System.Collections;

public class moveScript : MonoBehaviour {

	public float moveSpeed;
	public float jumpHeight;
	public Rigidbody2D rb;
	public float speed = 0.1F;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	// this will let the ball moved horizontally
	void Update () {

		float h = Input.GetAxis ("Horizontal") * moveSpeed;
		rb.AddForce (Vector2.right * h);

		//If sphere will fall, then it will call GameOver function
		if (transform.position.y < -5) {
			GameOver();
		}

		if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Moved) {
			// Get movement of the finger since last frame
			Vector2 touchDeltaPosition = Input.GetTouch (0).deltaPosition;
			
			// Move object across XY plane
			transform.Translate (-touchDeltaPosition.x * speed, -touchDeltaPosition.y * speed, 0);
		}
		
	}
	
	void OnCollisionEnter2D (Collision2D coll)
	{
		if (coll.gameObject.tag == "tile") 
		Application.LoadLevel ("SceneThankYou");
	}

	//To show the Game Over Scene
	void GameOver ()
	{
		Application.LoadLevel ("SceneThankYou");
	}


}


