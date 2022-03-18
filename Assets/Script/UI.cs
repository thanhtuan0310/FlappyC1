using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public GameObject GameOver;
    private PlayerController playScript;
   
   
    void Update()
    {
        playScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        if (playScript.GameOver)
        {
            GameOver.SetActive(true);
        }
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
