using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
	public GameObject pauseMenuUI;
	public GameObject GameOver;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
		{
			if (GameIsPaused)
			{
				Resume();
			} else
			{
				Pause();
			}
		}
    }
	public void Resume ()
	{
		pauseMenuUI.SetActive(false);
		Time.timeScale = 1f;
		GameIsPaused = false;
	}
	void Pause ()
	{
		pauseMenuUI.SetActive(true);
		Time.timeScale = 0f;
		GameIsPaused = true;
	}
	public void LoadMenu()
	{	Time.timeScale = 1f;
		SceneManager.LoadScene("Menu");
	}
	public void QuitGame()
	{
		Application.Quit();
	}
	public void Restart()
	{
		SceneManager.LoadScene("Level1");
		LevelController.health = 3;
		Score.MyScoreText += 0;
		Time.timeScale = 1f;
	}
}
