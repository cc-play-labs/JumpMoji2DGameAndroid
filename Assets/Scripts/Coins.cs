using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour {

    public int totalCoins;
    public Text coinsText;
    public int nrTouch;
    public GameObject Coin;
    public Rigidbody2D rb;
    public float jumpSpeed;
    public float stdrForce;
    private int stdr;


    void Start()
    {
        totalCoins = 0;
        nrTouch = 0;
        rb = Coin.GetComponent<Rigidbody2D>();
    }

   
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
            Destroy(this.gameObject);
        }

        if (collision.gameObject.tag == "Ground")
        {
            nrTouch++;
            if (nrTouch == 2)
            {
                Destroy(this.gameObject);

            }
            CoinJump();
        }
    }

    public void CoinJump()
    {
        rb.AddForce(Vector2.up * jumpSpeed, ForceMode2D.Impulse);
        stdr = Random.Range(1, 3);
        if(stdr == 1)
        {
            rb.AddForce(Vector2.left * stdrForce, ForceMode2D.Impulse);
        }

        if(stdr == 2)
        {
            rb.AddForce(Vector2.right * stdrForce, ForceMode2D.Impulse);
        }
    }
}
