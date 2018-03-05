using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTest : MonoBehaviour {


	public float colDepth = 4f;
	public float zPosition = 0f;
	public float value;
	public float mCamera;
	public float orto;
	public float screenWidth;
	public float screenHeight;
	public Camera mainCamera;
	private Vector2 screenSize;
	private Transform topCollider;
	private Transform bottomCollider;
	private Transform leftCollider;
	private Transform rightCollider;
	private Vector3 cameraPos;

	// Use this for initialization
	void Start () {
		screenWidth = Screen.width;
		screenHeight = Screen.height;


		if ((screenWidth > 0 && screenWidth <= 480) && (screenHeight > 0 && screenHeight <= 800)) {
			mainCamera.orthographicSize = 12.0f;
			value = 0.5f;
		}
		if ((screenWidth > 480 && screenWidth <= 640) && (screenHeight > 800 && screenHeight <= 960)) {
			mainCamera.orthographicSize = 16.0f;
			value = 0.5f;
		}

		if ((screenWidth > 640 && screenWidth <= 720) && (screenHeight > 960 && screenHeight <= 1280)) {
			mainCamera.orthographicSize = 18.0f;
			value = 0.5f;
		}

		if ((screenWidth > 720 && screenWidth <= 1080) && (screenHeight > 1280 && screenHeight <= 1920)) {
			mainCamera.orthographicSize = 26.0f;
			value = 0.5f;
		}

		if ((screenWidth > 1080 && screenWidth <= 1440) && (screenHeight > 1920 && screenHeight <= 2560)) {
			mainCamera.orthographicSize = 31.0f;
			value = 0.5f;
		}

		if((screenWidth >=600  && screenWidth <= 800) && (screenHeight >= 900&& screenHeight <= 1300))
		{
			mainCamera.orthographicSize = 24.0f;
			value = 0.5f;
		}


		//Generate our empty objects
		topCollider = new GameObject().transform;
		bottomCollider = new GameObject().transform;
		rightCollider = new GameObject().transform;
		leftCollider = new GameObject().transform;

		//Name our objects 
		topCollider.name = "TopCollider";
		bottomCollider.name = "BottomCollider";
		rightCollider.name = "RightCollider";
		leftCollider.name = "LeftCollider";

		rightCollider.tag = "RightCollider";
		leftCollider.tag = "LeftCollider";
		topCollider.tag = "TopCollider";
		bottomCollider.tag = "BottomCollider";

		//Add the colliders
		topCollider.gameObject.AddComponent<BoxCollider2D>();
		bottomCollider.gameObject.AddComponent<BoxCollider2D>();
		rightCollider.gameObject.AddComponent<BoxCollider2D>();
		leftCollider.gameObject.AddComponent<BoxCollider2D>();

		//Make them the child of whatever object this script is on, preferably on the Camera so the objects move with the camera without extra scripting
		topCollider.parent = transform;
		bottomCollider.parent = transform;
		rightCollider.parent = transform;
		leftCollider.parent = transform;

		//Generate world space point information for position and scale calculations
		cameraPos = Camera.main.transform.position;
		screenSize.x = Vector2.Distance (Camera.main.ScreenToWorldPoint(new Vector2(0,0)),Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0))) * 0.5f;
		screenSize.y = Vector2.Distance (Camera.main.ScreenToWorldPoint(new Vector2(0,0)),Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height))) * 0.5f;

		//Change our scale and positions to match the edges of the screen...   
		rightCollider.localScale = new Vector3(colDepth, screenSize.y * 9, colDepth);
		rightCollider.position = new Vector3(cameraPos.x + screenSize.x + (rightCollider.localScale.x * value), cameraPos.y, zPosition);
		leftCollider.localScale = new Vector3(colDepth, screenSize.y * 9, colDepth);
		leftCollider.position = new Vector3(cameraPos.x - screenSize.x - (leftCollider.localScale.x * value), cameraPos.y, zPosition);
		topCollider.localScale = new Vector3(screenSize.x * 2, colDepth, colDepth);
		topCollider.position = new Vector3(cameraPos.x, cameraPos.y + screenSize.y + (topCollider.localScale.y * value), zPosition);
		bottomCollider.localScale = new Vector3(screenSize.x * 2, colDepth, colDepth);
		bottomCollider.position = new Vector3(cameraPos.x, cameraPos.y - screenSize.y - (bottomCollider.localScale.y * value *2.5f), zPosition);
	}

	void Update()
	{
		orto = GetComponent<Camera>().orthographicSize;

	}
}