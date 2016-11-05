﻿using UnityEngine;
using System.Collections;

[RequireComponent(typeof(FlyingMovingB), typeof(Attack3B))]
public class Monster3B : AbstractMonster 
{
	private GameObject player;
	public float AttackRange = 2;
	private FlyingMovingB _flyingMovingB;
	private Attack3B _attack3B;
	public float RateOfFire = 4;
	private float t = 0;

	void Start()
	{
		player = Camera.main.gameObject;
		_flyingMovingB = GetComponent<FlyingMovingB>();
		_attack3B = GetComponent<Attack3B>();
	}

	public void Move(Vector3 position)
	{
		_flyingMovingB.MoveTo(position);		
	}

	void Update()
	{
		if (_flyingMovingB.mooving == false)
		{
			if (Vector3.Distance(player.transform.position, transform.position) < AttackRange)
			{
				t += Time.deltaTime;
				if (t > RateOfFire)
				{
					Debug.Log("Fire");
					t = 0;
					_flyingMovingB.FaceObject(player.transform, 0.5f);
					Attack(player);
				}

			}
			else
			{
				Debug.Log("Move");
				Move(player.transform.position - (player.transform.position - transform.position) * 0.2f);
			}
		}

	}

	public void Attack(GameObject target)
	{
		_attack3B.Attack(target);
	}

	public override int  Experience()
	{
		return 0;
	}

	public override void Spawn(){

	}

	public override void Die(){
		PlayerB player = GameObject.FindObjectOfType(typeof(PlayerB)) as PlayerB ;
		if ( player != null){
			player.levelUp (1);
		}
		Destroy(this.gameObject);
		//FIXME AJOUT sac de gold?
	}
}
