﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardMove : MonoBehaviour {


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		transform.localPosition = new Vector3 (0, - TimeManager.time * 100, 0);
	}
}
