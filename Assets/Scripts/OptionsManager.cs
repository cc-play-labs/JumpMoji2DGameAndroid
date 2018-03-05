using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class OptionsManager : MonoBehaviour {

   
    private int soundState;
   
	public Text textField;

	public GameObject AccPanelOn;
	public GameObject AccPanelOff;

	public GameObject SoundPanelOn;
	public GameObject SoundPanelOff;


	private int accState;

    void Start()
    {
		//PlayerPrefs.SetInt ("soundState", 1);
		soundState = PlayerPrefs.GetInt ("soundState");
		if (soundState == 0) {
			SoundPanelOn.SetActive (false);
			AudioListener.volume = 0;
			SoundPanelOff.SetActive (true);
		}

		if (soundState == 1) {
			SoundPanelOn.SetActive (true);
			AudioListener.volume = 1;
			SoundPanelOff.SetActive (false);
		}
		PlayerPrefs.Save ();
		textField.text = " ";
    }


    public void Update()
    {
		
    }

    

	public void SoundOFF()
	{
		soundState = PlayerPrefs.GetInt ("soundState");
		AudioListener.volume = 0;
		Debug.Log ("SoundOFF" + soundState);
		if (soundState == 1) {
			SoundPanelOn.SetActive (false);
			SoundPanelOff.SetActive (true);
			PlayerPrefs.SetInt ("soundState", 0);
			textField.text = "Sound OFF ";
			PlayerPrefs.Save ();
		}
	}

	public void SoundON()
	{
		soundState = PlayerPrefs.GetInt ("soundState");
		AudioListener.volume = 1;
		Debug.Log ("SoundON" + soundState);
		if(soundState == 0)
		{
			SoundPanelOff.SetActive (false);
			SoundPanelOn.SetActive(true);
			PlayerPrefs.SetInt ("soundState", 1);
			textField.text = "Sound is ON";
			PlayerPrefs.Save ();
		}
	}

	public void ToMenu()
	{
		SceneManager.LoadScene ("Menu");
	}
}
