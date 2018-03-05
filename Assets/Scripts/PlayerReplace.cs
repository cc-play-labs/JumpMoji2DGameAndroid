using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerReplace : MonoBehaviour {


	public int index;
	public GameObject[] Players;

	// Use this for initialization
	void Start () {
		
		ChangeCharacter ();
	}
	

	public void ChangeCharacter()
	{
		TurnOffAllChilds ();
		index = PlayerPrefs.GetInt ("player");
		if (index == 0) {
			Players [0].SetActive (true);

		}
		if (index == 1) {

			Players [1].SetActive (true);
		}

		if (index == 2) {

			Players [2].SetActive (true);
		}

		if (index == 3) {

			Players [3].SetActive (true);
		}

		if (index == 4) {

			Players [4].SetActive (true);
		}

		if (index == 5) {

			Players [5].SetActive (true);
		}

		if (index == 6) {

			Players [6].SetActive (true);
		}
		if (index == 7) {

			Players [7].SetActive (true);
		}

		if (index == 8) {

			Players [8].SetActive (true);
		}
		if (index == 9) {

			Players [9].SetActive (true);
		}

		if (index == 10) {

			Players [10].SetActive (true);
		}

		if (index == 11) {

			Players [11].SetActive (true);
		}

		if (index == 12) {

			Players [12].SetActive (true);
		}

		if (index == 13) {

			Players [13].SetActive (true);
		}

		if (index == 14) {

			Players [14].SetActive (true);
		}

		if (index == 15) {

			Players [15].SetActive (true);
		}
		if (index == 16) {

			Players [16].SetActive (true);
		}
		if (index == 17) {

			Players [17].SetActive (true);
		}

		if (index == 18) {

			Players [18].SetActive (true);
		}

		if (index == 19) {

			Players [19].SetActive (true);
		}
	}

	public void TurnOffAllChilds()
	{
		for (int i = 0; i < index; i++) {
			Players [i].SetActive (false);
		}
	}



}
