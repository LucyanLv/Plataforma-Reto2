//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

//public class ScoreManager : MonoBehaviour
//{
//    public static int[] scoreList = new int[5];
//	private Text scoreText = "X 0";
//	private static int currentIndex;
	
//    public void SumScore()
//    {
//        scoreList[currentIndex] += 1;
//    }
	
//	public void resetScore()
//	{
//		for(int u = 0; u < scoreList.Length; u++)
//			scoreList[u] = 0;
//	}
	
//	public void getFinalScore()
//	{
//		int total = 0;
//		for(int u = 0; u < scoreList.Length; u++)
//			total += scoreList[u];
//	}
	
//	public void Update()
//	{
//		currentIndex = SceneManager.GetActiveScene().buildIndex;
//		scoreText = "X " + scoreList[currentIndex];
//	}
//}