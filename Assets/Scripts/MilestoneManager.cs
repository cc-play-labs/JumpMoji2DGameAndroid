using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MilestoneManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Milestone1()
	{
		SceneManager.LoadScene("Milestone1");
	}

	public void Milestone2()
	{
		SceneManager.LoadScene("Milestone2");
	}

	public void Milestone3()
	{
		SceneManager.LoadScene("Milestone3");
	}

	public void Milestone4()
	{
		SceneManager.LoadScene("Milestone4");
	}

	public void Milestone5()
	{
		SceneManager.LoadScene("Milestone5");
	}

	public void Milestone6()
	{
		SceneManager.LoadScene("Milestone6");
	}

	public void Milestone7()
	{
		SceneManager.LoadScene("Milestone7");
	}

	public void Milestone8()
	{
		SceneManager.LoadScene("Milestone8");
	}

	public void Milestone9()
	{
		SceneManager.LoadScene("Milestone9");
	}

	public void Back()
	{
		SceneManager.LoadScene ("Menu");
	}
}
