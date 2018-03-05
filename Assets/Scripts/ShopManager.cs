using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ShopManager : MonoBehaviour {


	public Text totalCoinsText;
	public Text[] prices;
	public GameObject[] coinIco;
	public int totalCoins;
	public int[] sold;
	public GameObject coinPanel;
	public GameObject charPanel;

	// Use this for initialization
	void Start () {
		//Erase ();
		//PlayerPrefs.SetInt("bankCoins", 100000);
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



		if (sold [0] == 1) {
			prices [0].text = "Unlocked!";
			charPanel.SetActive (true);
			PlayerPrefs.SetInt ("player" ,0);
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
				sold [0] = 1;
				PlayerPrefs.SetInt ("player" ,0);

			}
		}

	}

	public void BuyPump2()
	{
		
		if (sold [1] == 1) {
			prices [1].text = "Unlocked!";
			charPanel.SetActive (true);
			PlayerPrefs.SetInt ("player" ,1);
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
				sold [1] = 1;
				PlayerPrefs.SetInt ("player" ,1);

			}
		}
	}

	public void BuyPump3()
	{


		if (sold [2] == 1) {
			prices [2].text = "Unlocked!";
			charPanel.SetActive (true);
			PlayerPrefs.SetInt ("player" ,2);
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
				sold [2] = 1;
				PlayerPrefs.SetInt ("player" ,2);

			}
		}
	}

	public void BuyPump4()
	{


		if (sold [3] == 1) {
			prices [3].text = "Unlocked!";
			charPanel.SetActive (true);
			PlayerPrefs.SetInt ("player" ,3);
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
				sold [3] = 1;
				PlayerPrefs.SetInt ("player" ,3);

			}
		}
	}

	public void BuyPump5()
	{


		if (sold [4] == 1) {
			prices [4].text = "Unlocked!";
			charPanel.SetActive (true);
			PlayerPrefs.SetInt ("player" ,4);
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
				sold [4] = 1;
				PlayerPrefs.SetInt ("player" ,4);

			}
		}
	}

	public void BuyPump6()
	{

	
		if (sold [5] == 1) {
			prices [5].text = "Unlocked!";
			charPanel.SetActive (true);
			PlayerPrefs.SetInt ("player" ,5);
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
				sold [5] = 1;
				PlayerPrefs.SetInt ("player" ,5);
			}
		}
	}

	public void BuyPump7()
	{

	
		if (sold [6] == 1) {
			prices [6].text = "Unlocked!";
			charPanel.SetActive (true);
			PlayerPrefs.SetInt ("player" ,7);
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
				sold [6] = 1;
				PlayerPrefs.SetInt ("player" ,7);

			}
		}
	}

	public void BuyPump8()
	{


		if (sold [7] == 1) {
			prices [7].text = "Unlocked!";
			charPanel.SetActive (true);
			PlayerPrefs.SetInt ("player" ,8);
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
				sold [7] = 1;
				PlayerPrefs.SetInt ("player" ,8);

			}
		}
	}

	public void BuyPump9()
	{


		if (sold [8] == 1) {
			prices [8].text = "Unlocked!";
			charPanel.SetActive (true);
			PlayerPrefs.SetInt ("player" ,9);
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
				sold [8] = 1;
				PlayerPrefs.SetInt ("player" ,9);

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
		for(int i = 0; i<10;i++)
		{
			if(sold[i] ==1)
			{
				PlayerPrefs.SetInt ("sold" + i, 1);
			}
		}

	}

	public void Load()
	{
		for (int i = 0; i < 10; i++) {
			sold [i] = PlayerPrefs.GetInt ("sold" + i);
			Debug.Log (sold[i]);
			if (sold [i] == 1) {

				coinIco[i].SetActive (false);
				prices [i].text = "Unlocked!";
			}

		}
	}

	public void Erase()
	{
		for (int i = 0; i < 10; i++) {
			PlayerPrefs.SetInt("sold"+i, 0); 
		}
	}

}
