using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {


    public float screenWidth;
    public float screenHeight;
    public Camera mainCamera;

    public GameObject character;
    public GameObject GameWonPanel;
	public GameObject GameOverPanel;
	public GameObject returnButton;

    public AudioSource jumpSound;

    public Text scoreText;
    public Text timeText;
    public Text time;
    public Text liveScoreText;
    public Text liveTimeText;
    public Text coinsText;

    public Transform target;

    public int totalCoins;
    public int bankCoins;
	public int accState;
	public float speed;
    public float jumpSpeed;
    public float score;
    public float scoreValue;
    public float timer;
	public float movingSpeed;

    public float currentPosition;
    public float previousPosition;
    public float distancePosition;

    public bool canJump;
    public Rigidbody2D rb;


    bool rightButtonDown;
    bool leftButtonDown;

	UnityAdsScript ad = new UnityAdsScript();

    void Start() {
		
		accState = PlayerPrefs.GetInt ("accState");
		Debug.Log (accState);
        rb = character.GetComponent<Rigidbody2D>();
        GameWonPanel.SetActive(false);
		returnButton.SetActive (true);
        totalCoins = 0;
        Time.timeScale = 1;
		screenHeight = Screen.height;
		screenWidth = Screen.width;
		rb.mass = 4;
		changeStats ();
		//jumpSpeed = 0.15f * screenHeight;
		//movingSpeed = 0.75f * screenWidth;
    }


    void Update() {
		//if (accState == 1) {	
			transform.Translate (Input.acceleration.x * 0.75f,0, 0); 
		//}

		//if (accState == 0) {
			if (rightButtonDown) {
				float moveRight = (Time.deltaTime * speed);
				target.Translate (moveRight, 0, 0);
			}

			if (leftButtonDown) {
				float moveLeft = (Time.deltaTime * speed);
				target.Translate (-moveLeft, 0, 0);
			}
		//}


        timer = Time.timeSinceLevelLoad;
        liveTimeText.text = "Time: " + timer.ToString("F2");
        coinsText.text = totalCoins.ToString();
		// Accelerometer ();
#if (UNITY_EDITOR)
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
#endif

    }

    void FixedUpdate()
    {
        currentPosition = transform.position.y;
        distancePosition = currentPosition - previousPosition;
        previousPosition = currentPosition;
		if (distancePosition > 0) {
			canJump = false;
		}
		if (distancePosition == 0) {
			canJump = true;
		}

		if (distancePosition < 0)
        {
            canJump = true;

        }
        Time.timeScale = 1.3f;
    }

	public void OnRightButtonDown(bool down)
	{
		rightButtonDown = down;
	}

	public void OnLeftButtonDown(bool down)
	{
		leftButtonDown = down;
	}


    public void MoveLeft()
    {
		transform.position += Vector3.left * speed * Time.deltaTime;
    }

    public void MoveRight()
    {
		transform.position += Vector3.right * speed * Time.deltaTime;
    }

   
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "platform" && canJump == true)
        {
            Jump();
            Score();
        }

        if (other.gameObject.tag == "gamewon")
        {
            GameWon();
        }

		if (other.gameObject.tag == "LeftCollider") {
		
			//transform.position += Vector3.right * movingSpeed * Time.deltaTime;
		}

		if (other.gameObject.tag == "RightCollider") {
			//transform.position += Vector3.left * movingSpeed * Time.deltaTime;
		}

		if (other.gameObject.tag == "GameOver")
		{
			GameOverPanel.SetActive (true);
			Time.timeScale = 0;
			returnButton.SetActive(false);
			//ad.ShowAds2 ();
		}


        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bag")
        {
            totalCoins = totalCoins + 15;
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Candy")
        {
            totalCoins = totalCoins + 5;
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Poison")
        {
            totalCoins++;
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Prj")
        {
            totalCoins = totalCoins + 10;
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Coin")
        {
            totalCoins = totalCoins + 1;
            Destroy(other.gameObject);
        }

    }


    public void Jump()
    {
        jumpSound.Play();
        rb.AddForce(Vector2.up * jumpSpeed, ForceMode2D.Impulse);
        canJump = false;

    }

   


    public void GameWon()
    {
        Time.timeScale = 0;
        timeText.text = "Time: " + timer.ToString("F2");
        GameWonPanel.SetActive(true);
        bankCoins = PlayerPrefs.GetInt("bankCoins");
        bankCoins = bankCoins + totalCoins;
        PlayerPrefs.SetInt("bankCoins",bankCoins);
        Debug.Log(bankCoins);


    }

    public void Score()
    {
        score = score - scoreValue;
        liveScoreText.text = "Score: " + score.ToString();
        scoreText.text = "Score: " + score.ToString();

    }

    


    public void ToLevelSelect()
    {
        SceneManager.LoadScene("Milestone1");
    }

	public void changeStats()
	{
		if (Screen.height >= 600) {
			jumpSpeed = 0.15f * screenHeight;
			movingSpeed = 0.55f * screenWidth;
		
		}

		if (Screen.height >= 1280) {
			jumpSpeed = 0.12f * screenHeight;
			movingSpeed = 0.62f * screenWidth;

		}


		if (Screen.height >= 1920) {
			jumpSpeed = 0.10f * screenHeight;
			movingSpeed = 0.65f * screenWidth;


		}


		if (Screen.height >= 2560) {
			jumpSpeed = 0.10f * screenHeight;
			movingSpeed = 0.95f * screenWidth;
			rb.mass = 5;


		}


	}

	public void Accelerometer()
	{

		float x = Input.acceleration.x;
		Debug.Log (x);
		if (x > 0) {
			
		}

		if (x < 0) {
			
		}
	}

	public void Retry()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		GameOverPanel.SetActive (false);
	}



}
