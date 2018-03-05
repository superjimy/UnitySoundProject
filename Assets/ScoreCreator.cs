using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCreator : MonoBehaviour {

	//プレハブ格納変数//
	public GameObject scorePrefab;

	//タイマー変数//
	private float timer;

	// Use this for initialization
	void Start () {

		//タイマー初期化//
		timer = TimeManager.time + 1f;
		
	}
	
	// Update is called once per frame
	void Update () {

		//１秒ごとに実行//
		if (timer < TimeManager.time) {

			//譜面作成//
			Instantiate (scorePrefab);

			//タイマー更新//
			timer = TimeManager.time + 1f;
		}
	}
}
