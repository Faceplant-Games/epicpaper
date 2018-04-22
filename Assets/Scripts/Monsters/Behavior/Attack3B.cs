﻿using UnityEngine;
using System.Collections;

/**
 * Bearbot / dragon 
 */
public class Attack3B : MonoBehaviour 
{
	public GameObject BulletPrefab;
	public Transform FireInitialPos;
    public int damage = 5;

	public void Attack(GameObject target)
	{
		FireBullet(target);
	}

	private void FireBullet(GameObject target)
	{
		GameObject bullet = Instantiate<GameObject>(BulletPrefab);
		bullet.transform.position = FireInitialPos.position;
		bullet.transform.LookAt(target.transform.position);
        bullet.GetComponent<Ennemi3BulletB>().damage = damage;
	}
}
