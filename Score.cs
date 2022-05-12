using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
		public static int MyScoreText = 0;
		Text ScoreNum;
		
    void Start()
    {	
		ScoreNum = GetComponent<Text> ();
        
    }
	void Update() 
	{	
		ScoreNum.text = "Score: " + MyScoreText;
		if(MyScoreText> PlayerPrefs.GetInt("highestscore"))
		{
		PlayerPrefs.SetInt("highestscore", MyScoreText);
		}
	}
}
