﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

	void OnBecameInvisible(){
		Destroy (gameObject);
	}

	void OnCollisionEnter(){
		Destroy (gameObject);
	}
}
