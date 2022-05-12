using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HighScore : MonoBehaviour
{
    public Text HighestScore;
    void Start()
    {
		HighestScore.text = "HighScore :" + PlayerPrefs.GetInt("highestscore").ToString();
		
    }

    void Update()
    { 
		}
}
 