using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerFinScript : MonoBehaviour {

    Image imgFin;
    public float maxTime = 0f;
    float timeLeft;
    public GameObject textFin1;
    public GameObject textFin2;

	void Start () {
        textFin1.SetActive(false);
        textFin2.SetActive(false);
        imgFin = GetComponent<Image>();
        timeLeft = maxTime;

	}
	
	void Update () {
		if (timeLeft > 0) {
			timeLeft -= Time.deltaTime;
			imgFin.fillAmount = timeLeft / maxTime;
		} else {
			textFin1.SetActive (true);
			textFin2.SetActive (true);
			Time.timeScale = 0;
			if (Input.GetKey (KeyCode.Escape)) {
				SceneManager.LoadScene ("Menu");
			}
		}

	}
}
