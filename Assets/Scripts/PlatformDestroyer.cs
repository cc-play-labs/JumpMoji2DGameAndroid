using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlatformDestroyer : MonoBehaviour {
    
	string scene;

	void Start()
	{
		scene = SceneManager.GetActiveScene().name;


	}


    public void OnCollisionEnter2D(Collision2D collision)
	{
        

		if ((scene == "Level21") || (scene == "Level22") || (scene == "Level23") || (scene == "Level24") || (scene == "Level25") || (scene == "Level26") || (scene == "Level27") || (scene == "Level28") || (scene == "Level29")) {
		} else {

			if (collision.gameObject.tag == "BottomCollider") {
				Destroy (this.gameObject);
				this.gameObject.SetActive (false);
			}
		}
		
	}
}
