using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameSystem1 : MonoBehaviour
{

	//　スタートボタンを押したら実行する
	public void StartGame()
	{
		//Stage1を読み込む
		SceneManager.LoadScene("Stage1");
	}

}