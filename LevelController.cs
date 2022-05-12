using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    private static int _nextLevelIndex = 1;
    private Enemy[] _enemies;
	public GameObject heart1, heart2, heart3, GameOver;
	public static int health = 3;
    private void OnEnable()
    {
        _enemies = FindObjectsOfType<Enemy>();
    }
	void Start()
	{ 	
		heart1.gameObject.SetActive (true);
		heart2.gameObject.SetActive (true);
		heart3.gameObject.SetActive (true);
	
	}


    void Update()
    {	switch (health) {
		case 3:
		GameOver.SetActive(false);
		heart1.gameObject.SetActive (true);
		heart2.gameObject.SetActive (true);
		heart3.gameObject.SetActive (true);
		break;
		case 2:
		heart1.gameObject.SetActive (true);
		heart2.gameObject.SetActive (true);
		heart3.gameObject.SetActive (false);
		break;
		case 1:
		heart1.gameObject.SetActive (true);
		heart2.gameObject.SetActive (false);
		heart3.gameObject.SetActive (false);
		break;
		case 0:
		heart1.gameObject.SetActive (false);
		heart2.gameObject.SetActive (false);
		heart3.gameObject.SetActive (false);
		GameOver.SetActive(true);
		Time.timeScale = 0f;
		Score.MyScoreText = 0;
		break;
	
				}
				
        foreach(Enemy enemy in _enemies)
        {	
            if (enemy != null)
            return;
        }

        Debug.Log("You killed all enemies");
		string scenaCurenta = SceneManager.GetActiveScene().name;
	if (scenaCurenta == "Level1")
	{
			_nextLevelIndex = 1;
		}
		
        _nextLevelIndex++;
        string nextLevelName = "Level" + _nextLevelIndex;
        SceneManager.LoadScene(nextLevelName);
		
		
	
	
   
	}
}