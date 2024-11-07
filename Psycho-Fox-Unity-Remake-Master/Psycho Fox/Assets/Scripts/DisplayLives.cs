using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class DisplayLives : MonoBehaviour {

    public GameObject text;
    private int lives = PlayerManager.Instance.lives;

    void Start() {
        PlayerManager.Instance.alive = true;
        PlayerManager.Instance.lives -= 1;
        // text.GetComponent<TextMeshProUGUI>().text = "X" + (lives);
        text.GetComponent<TextMeshProUGUI>().text = "X" + (lives - 1);
    }

    public void LoadGameScene() {
        // if (lives == 0)
        if (lives == 1) {
            SceneManager.LoadScene("Boot Screen");
        } else {
            SceneManager.LoadScene("Main Scene");
        }
    }
}
