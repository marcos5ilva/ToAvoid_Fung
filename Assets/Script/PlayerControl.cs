using UnityEngine;
using System.Collections;
//using UnityStandardAssets.CrossPlatformInput ;


public class PlayerControl : MonoBehaviour {

	private Transform thisTransform = null;
	private Rigidbody2D thisBody = null;
	public float walkSpeed = 1f;
	bool facingRight = true;

	Animator anim;


	// Use this for initialization
	void Start () {
		thisTransform = GetComponent<Transform> ();
		thisBody = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();

		//thisTransform.Rotate(0,180,0,Space.World);
	
	}
	
	// Update is called once per frame

	void FixedUpdate () {


		
		float moveX = Input.GetAxis ("Horizontal");


		thisBody.velocity = new Vector2 (moveX * walkSpeed, thisBody.velocity.y);

		anim.SetFloat ("Speed", Mathf.Abs (moveX));

		Debug.Log (moveX);
		Debug.Log (thisBody.velocity);

		if (moveX > 0 && !facingRight)
			Flip ();
		else if (moveX < 0 && facingRight)
			Flip ();
	}

	void Update () {
	
	}

	void Flip(){
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		//anim.SetFloat ("Angle", 180);
		theScale.x *= -1;
		transform.localScale = theScale;

	}


}
