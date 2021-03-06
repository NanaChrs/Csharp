﻿using UnityEngine;
using System.Collections;

// This class is created for the example scene. There is no support for this script.
public class HintManagement : MonoBehaviour
{
	public string message = "";
	public string message2 = "";
	public KeyCode changeMessageKey;

	private GameObject player;
	private bool used = false;

	private ControlsTutorial manager;

	void Awake()
	{
		player = GameObject.FindGameObjectWithTag("Player");
		manager = GameObject.FindGameObjectWithTag("GameController").GetComponent<ControlsTutorial> ();
	}

	void OnTriggerEnter(Collider other)
	{
		if((other.gameObject == player) && !used)
		{

			used = true;
		}
	}


}
