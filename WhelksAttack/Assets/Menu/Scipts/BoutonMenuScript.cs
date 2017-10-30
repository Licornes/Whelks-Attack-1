using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoutonMenuScript : MonoBehaviour {

    public void START_THE_GAME()
    {
        SceneManager.LoadScene("gameduel");
    }

    public void QUIT_THE_GAME()
    {
        Application.Quit();
    }
}
