using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlatformMover : MonoBehaviour
{
    public GameObject target;
	public float screenWidth;
    public float movingSpeed;
    public bool direction;
	public bool canMove;

     void Start()
    {
		

		screenWidth = Screen.width;
		movingSpeed = 0.01f * screenWidth;
		direction = true;
		canMove = false;
	
    }
    void FixedUpdate()
	{
		
		if (canMove) {	
			if (direction == true) {
				transform.position += Vector3.left * movingSpeed * Time.deltaTime;

			}
			if (direction == false) {
				transform.position += Vector3.right * movingSpeed * Time.deltaTime;
			}
		}
	}
	public void OnCollisionEnter2D(Collision2D collision)
	{
		//if (collision.gameObject.GetComponent<Collider2D>().tag == "LeftCollider") {
		if (collision.gameObject.tag == "LeftCollider") {
			direction = false;
			Debug.Log ("yay");
		}
		if (collision.gameObject.tag == "RightCollider") {
			direction = true;
		}
		if (collision.gameObject.tag == "TopCollider") {
			canMove = true;
		}

		if (collision.gameObject.tag == "BottomCollider") {
			canMove = true;
		}
	}
                
}
