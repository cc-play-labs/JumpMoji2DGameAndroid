using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour {

    public GameObject pausePanel;

    void Start()
    {
        pausePanel.SetActive(false);
    }

    public void GamePause()
    {
        Time.timeScale = 0;
        pausePanel.SetActive(true);

    }

    public void UnpauseGame()
    {
        Time.timeScale = 1;
        pausePanel.SetActive(false);
    }

    public void BackToMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }



}
