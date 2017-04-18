using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    void Start() {

    }

    void Update() {

    }

    public void GrajBTN()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(0);
    }

    public void WyjdzBTN()
    {
        Application.Quit();
    }
}
