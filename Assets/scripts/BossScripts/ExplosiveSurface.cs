﻿using UnityEngine;
using System.Collections;

public class ExplosiveSurface : MonoBehaviour 
{
	public GameObject ExplosionFX;
	public bool ExplosionEnabled;

	private int HP = 10;

	public void TriggerExplosion(Vector3 position)
	{
		if (ExplosionEnabled)
		{
            GameObject FX = Instantiate<GameObject>(ExplosionFX);
            FX.transform.position = position;
            
            HP--;
			if (HP < 0)
			{
				ExplosionEnabled = false;
				GetComponent<MeshRenderer>().material = GameObject.FindObjectOfType<BossFightManager>().RedEyeMaterial;
				GameObject.FindObjectOfType<BossFightManager>().EyesBrokenStage1 ++;
			}
		}
	}
}