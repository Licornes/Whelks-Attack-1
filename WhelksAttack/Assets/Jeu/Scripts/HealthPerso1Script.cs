using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPerso1Script : MonoBehaviour {

	public GameObject lifeP1, lifeP2, lifeP3, lifeP4, fin1, fin2;
	public static int health1;

	void Start () {
		health1 = 4;
		lifeP1.gameObject.SetActive (true);
		lifeP2.gameObject.SetActive (true);
		lifeP3.gameObject.SetActive (true);
		lifeP4.gameObject.SetActive (true);
		fin1.gameObject.SetActive (false);
		fin2.gameObject.SetActive (false);
		
	}

	void Update () {
		if (health1 > 4)
			health1 = 3;

		switch (health1) {
		case 4:
			lifeP1.gameObject.SetActive (true);
			lifeP2.gameObject.SetActive (true);
			lifeP3.gameObject.SetActive (true);
			lifeP4.gameObject.SetActive (true);
			break;
		case 3:
			lifeP1.gameObject.SetActive (true);
			lifeP2.gameObject.SetActive (true);
			lifeP3.gameObject.SetActive (true);
			lifeP4.gameObject.SetActive (false);
			break;
		case 2:
			lifeP1.gameObject.SetActive (true);
			lifeP2.gameObject.SetActive (true);
			lifeP3.gameObject.SetActive (false);
			lifeP4.gameObject.SetActive (false);
			break;
		case 1:
			lifeP1.gameObject.SetActive (true);
			lifeP2.gameObject.SetActive (false);
			lifeP3.gameObject.SetActive (false);
			lifeP4.gameObject.SetActive (false);
			break;
		case 0:
			lifeP1.gameObject.SetActive (false);
			lifeP2.gameObject.SetActive (false);
			lifeP3.gameObject.SetActive (false);
			lifeP4.gameObject.SetActive (false);
			fin1.gameObject.SetActive (true);
			fin2.gameObject.SetActive (true);
			Time.timeScale = 0;
			break;
		}
	}
}
