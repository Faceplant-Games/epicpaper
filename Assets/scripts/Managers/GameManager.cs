﻿using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	private int previousStage = 0;
	public int stage = 0;
	public bool change = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (change) {
			change = false;
			if (stage > previousStage)
				print ("on monte de niveau");
			else if (stage < previousStage)
				print ("on baisse de niveau");
			previousStage = stage;
		}
	}

	//catch events change of stage



}