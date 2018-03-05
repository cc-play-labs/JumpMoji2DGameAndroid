using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ShopManager2 : MonoBehaviour {


	public Text totalCoinsText;
	public Text[] prices;
	public GameObject[] coinIco;
	public int totalCoins;
	public int[] soldd;
	public GameObject coinPanel;
	public GameObject charPanel;

	// Use this for initialization
	void Start () {
		//Erase ();
		//PlayerPrefs.SetInt("bankCoins", 0);
		coinPanel.SetActive (false);
		charPanel.SetActive (false);
		Load ();
	}

	// Update is called once per frame
	void Update () {
		totalCoins = PlayerPrefs.GetInt ("bankCoins");
		totalCoinsText.text = totalCoins.ToString ();
		Save ();
	}



	public void Back()
	{
		SceneManager.LoadScene ("Shop1");

	}

	public void Next()
	{
		SceneManager.LoadScene ("Shop2");

	}

	public void Menu()
	{
		SceneManager.LoadScene ("Menu");

	}

	public void BuyPump1()
	{



		if (soldd [0] == 1) {
			prices [0].text = "Unlocked!";
			charPanel.SetActive (true);
			PlayerPrefs.SetInt ("player" ,10);
		} else {
			if (totalCoins < 400) {
				coinPanel.SetActive (true);
			}
			else
			{	
				totalCoins = totalCoins - 400;
				PlayerPrefs.SetInt ("bankCoins", totalCoins);
				coinIco [0].SetActive (false);
				prices [0].text = "Unlocked!";
				soldd [0] = 1;
				PlayerPrefs.SetInt ("player" ,10);

			}
		}

	}

	public void BuyPump2()
	{

		if (soldd [1] == 1) {
			prices [1].text = "Unlocked!";
			charPanel.SetActive (true);
			PlayerPrefs.SetInt ("player" ,11);
		} else {
			if (totalCoins < 400) {
				coinPanel.SetActive (true);
			}
			else
			{	
				totalCoins = totalCoins - 400;
				PlayerPrefs.SetInt ("bankCoins", totalCoins);
				coinIco [1].SetActive (false);
				prices [1].text = "Unlocked!";
				soldd [1] = 1;
				PlayerPrefs.SetInt ("player" ,11);

			}
		}
	}

	public void BuyPump3()
	{


		if (soldd [2] == 1) {
			prices [2].text = "Unlocked!";
			charPanel.SetActive (true);
			PlayerPrefs.SetInt ("player" ,12);
		} else {
			if (totalCoins < 400) {
				coinPanel.SetActive (true);
			}
			else
			{	
				totalCoins = totalCoins - 400;
				PlayerPrefs.SetInt ("bankCoins", totalCoins);
				coinIco [2].SetActive (false);
				prices [2].text = "Unlocked!";
				soldd [2] = 1;
				PlayerPrefs.SetInt ("player" ,12);

			}
		}
	}

	public void BuyPump4()
	{


		if (soldd [3] == 1) {
			prices [3].text = "Unlocked!";
			charPanel.SetActive (true);
			PlayerPrefs.SetInt ("player" ,13);
		} else {
			if (totalCoins < 400) {
				coinPanel.SetActive (true);
			}
			else
			{	
				totalCoins = totalCoins - 400;
				PlayerPrefs.SetInt ("bankCoins", totalCoins);
				coinIco [3].SetActive (false);
				prices [3].text = "Unlocked!";
				soldd [3] = 1;
				PlayerPrefs.SetInt ("player" ,13);

			}
		}
	}

	public void BuyPump5()
	{


		if (soldd [4] == 1) {
			prices [4].text = "Unlocked!";
			charPanel.SetActive (true);
			PlayerPrefs.SetInt ("player" ,14);
		} else {
			if (totalCoins < 400) {
				coinPanel.SetActive (true);
			}
			else
			{	
				totalCoins = totalCoins - 400;
				PlayerPrefs.SetInt ("bankCoins", totalCoins);
				coinIco [4].SetActive (false);
				prices [4].text = "Unlocked!";
				soldd [4] = 1;
				PlayerPrefs.SetInt ("player" ,14);

			}
		}
	}

	public void BuyPump6()
	{


		if (soldd [5] == 1) {
			prices [5].text = "Unlocked!";
			charPanel.SetActive (true);
			PlayerPrefs.SetInt ("player" ,15);
		} else {
			if (totalCoins < 400) {
				coinPanel.SetActive (true);
			}
			else
			{	
				totalCoins = totalCoins - 400;
				PlayerPrefs.SetInt ("bankCoins", totalCoins);
				coinIco [5].SetActive (false);
				prices [5].text = "Unlocked!";
				soldd [5] = 1;
				PlayerPrefs.SetInt ("player" ,15);

			}
		}
	}

	public void BuyPump7()
	{

		PlayerPrefs.SetInt ("player" ,17);
		if (soldd [6] == 1) {
			prices [6].text = "Unlocked!";
			charPanel.SetActive (true);
			PlayerPrefs.SetInt ("player" ,17);
		} else {
			if (totalCoins < 400) {
				coinPanel.SetActive (true);
			}
			else
			{	
				totalCoins = totalCoins - 400;
				PlayerPrefs.SetInt ("bankCoins", totalCoins);
				coinIco [6].SetActive (false);
				prices [6].text = "Unlocked!";
				soldd [6] = 1;
				PlayerPrefs.SetInt ("player" ,17);

			}
		}
	}

	public void BuyPump8()
	{

	
		if (soldd [7] == 1) {
			prices [7].text = "Unlocked!";
			charPanel.SetActive (true);
			PlayerPrefs.SetInt ("player" ,18);
		} else {
			if (totalCoins < 400) {
				coinPanel.SetActive (true);
			}
			else
			{	
				totalCoins = totalCoins - 400;
				PlayerPrefs.SetInt ("bankCoins", totalCoins);
				coinIco [7].SetActive (false);
				prices [7].text = "Unlocked!";
				soldd [7] = 1;
				PlayerPrefs.SetInt ("player" ,18);

			}
		}
	}

	public void BuyPump9()
	{

		if (soldd [8] == 1) {
			prices [8].text = "Unlocked!";
			charPanel.SetActive (true);

			PlayerPrefs.SetInt ("player" ,19);
		} else {
			if (totalCoins < 400) {
				coinPanel.SetActive (true);
			}
			else
			{	
				totalCoins = totalCoins - 400;
				PlayerPrefs.SetInt ("bankCoins", totalCoins);
				coinIco [8].SetActive (false);
				prices [8].text = "Unlocked!";
				soldd [8] = 1;

				PlayerPrefs.SetInt ("player" ,19);

			}
		}
	}


	public void xCoinPanel()
	{
		coinPanel.SetActive (false);
	}

	public void xCharPanel()
	{
		charPanel.SetActive (false);
	}


	public void Save()
	{
		for(int i = 0; i<9;i++)
		{
			if(soldd[i] ==1)
			{
				Debug.Log ("val" + soldd[i]);
				PlayerPrefs.SetInt ("soldd" + i, 1);
			}
		}
		PlayerPrefs.Save ();
	}

	public void Load()
	{
		for (int i = 0; i < 9; i++) {
			soldd [i] = PlayerPrefs.GetInt ("soldd" + i);
			Debug.Log ("loaded" + soldd[i]);
			if (soldd [i] == 1) {

				coinIco[i].SetActive (false);
				prices [i].text = "Unlocked!";
			}

		}
	}

	public void Erase()
	{
		for (int i = 0; i < 9; i++) {
			PlayerPrefs.SetInt("soldd"+i, 0); 
		}
	}

}
