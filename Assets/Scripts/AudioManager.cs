using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour {

	public static AudioManager Instance {get;set;}
	public AudioSource source; // sursa audio pusa pe public pentru a putea fi folosita in inspector
	public AudioClip[] allSounds; // array pentru sunete


	private void Start()
	{
		Instance = this;
		DontDestroyOnLoad(gameObject); // folosim asta ca obiectul care detine sunetele sa nu fie distrus cand se trece in alt scene, asa putem asigura sunetele si pentru restul scene-urilor
		SceneManager.LoadScene("Menu"); // schimba scene-ul catre Menu
	}

	public void PlaySound(int SoundIndex)
	{

		AudioSource.PlayClipAtPoint(allSounds[SoundIndex],transform.position); // da play la sunete intr-o anumita pozitie in world
	}



}
