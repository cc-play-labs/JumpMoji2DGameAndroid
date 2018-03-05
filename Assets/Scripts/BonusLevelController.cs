using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BonusLevelController : MonoBehaviour {

    public GameObject deathPanel;

    public Transform target;


    public Text coinsText;
    public Text timerText;

    public int totalCoins;
    public int bankCoins;

    public float timeLeft;
    public float speed;


    private bool rightButtonDown;
    private bool leftButtonDown;


    private void Start()
    {
        deathPanel.SetActive(false);
        Time.timeScale = 1;
        bankCoins = PlayerPrefs.GetInt("coins");
        Debug.Log("Total coins in bank: " + bankCoins);

    }

    void Update()
    {


        if (rightButtonDown)
        {
            float moveRight = (Time.deltaTime * speed);
            target.Translate(moveRight, 0, 0);
        }

        if (leftButtonDown)
        {
            float moveLeft = (Time.deltaTime * speed);
            target.Translate(-moveLeft, 0, 0);
        }


        coinsText.text = "Coins: " + totalCoins.ToString();

        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            timeLeft = 0;
            GameOver();
        }

        timerText.text = timeLeft.ToString("F2");


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




    public void MoveLeft()
    {
        Debug.Log("It's me LEFT button!");
    }

    public void MoveRight()
    {
        Debug.Log("It's me RIGHT button!");
    }

    public void OnRightButtonDown(bool down)
    {
        rightButtonDown = down;
    }

    public void OnLeftButtonDown(bool down)
    {
        leftButtonDown = down;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "platform")
        {
            totalCoins++;
        }

        if (collision.gameObject.tag == "Bag")
        {
            totalCoins = totalCoins + 15;
        }

        if (collision.gameObject.tag == "Candy")
        {
            totalCoins = totalCoins + 5;
        }

        if (collision.gameObject.tag == "Poison")
        {
            totalCoins++;
            Debug.Log("It's working!");
        }

        if (collision.gameObject.tag == "Prj")
        {
            totalCoins = totalCoins + 10;
        }



    }


    public void GameOver()
    {
        Time.timeScale = 0;
        deathPanel.SetActive(true);
        SaveCalcCoins();
    }

    public void OkButton()
    {
        Time.timeScale = 1;
        deathPanel.SetActive(false);
        SceneManager.LoadScene("Menu");
    }

    void SaveCalcCoins()
    {
        bankCoins = bankCoins + totalCoins;
        PlayerPrefs.SetInt("coins",bankCoins);
        Debug.Log("Total nr. of Coins save in bank!");
    }
    
}
