using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

	public int totalCoins;
	public int val;

	void Awake()
	{
		//PlayerPrefs.SetInt ("val", 1);
	}
	void Start () {
		//PlayerPrefs.SetInt ("val", 1);
		val = PlayerPrefs.GetInt ("val");
		if (val == 1) {
			PlayerPrefs.SetInt("bankCoins", 400);
			PlayerPrefs.SetInt ("val", 0);
			PlayerPrefs.Save();
		} 


	}
	
	public void Play()
    {
        SceneManager.LoadScene("MilestoneSelect");
    }

    public void Options()
    {
        SceneManager.LoadScene("Options");
        
    }

    public void Quit()
    {
        Application.Quit();
    }

	public void Shop()
	{
		SceneManager.LoadScene ("Shop1");
	}

}
