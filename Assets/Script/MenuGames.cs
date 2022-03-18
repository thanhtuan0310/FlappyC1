using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuGames : MonoBehaviour
{
    public GameObject selectPlayer;
    public GameObject Menu;

    public AudioClip backButton;
    public AudioClip downButton;

    private AudioSource ButtonAudio;

    void Start()
    {
        ButtonAudio = GetComponent<AudioSource>();    
    }
    public void Play()
    {
        ButtonAudio.PlayOneShot(downButton, 1.0f);
        selectPlayer.SetActive(true);
        Menu.SetActive(false);
    }

    public void Quitt()
    {
        ButtonAudio.PlayOneShot(backButton, 1.0f);
        Application.Quit();
    }

    public void Back()
    {
        ButtonAudio.PlayOneShot(backButton, 1.0f);
        selectPlayer.SetActive(false);
        Menu.SetActive(true);
    }
}
