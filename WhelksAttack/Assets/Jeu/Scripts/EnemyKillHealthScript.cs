using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKillHealthScript : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D col){
		HealthPerso1Script.health1 -= 1;
	}
}
