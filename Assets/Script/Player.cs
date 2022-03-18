using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject tTuan;
    public GameObject dLong;
    public GameObject dtAnh;

    public AudioClip selectButton;

    private AudioSource ButtonAudio;
    Managers buildManager;
    // Start is called before the first frame update
    void Start()
    {
        ButtonAudio = GetComponent<AudioSource>();
        buildManager = Managers.instance;
    }

    public void SelectTuan()
    {
        ButtonAudio.PlayOneShot(selectButton,1.0f);
        buildManager.SetplayerToPlay(tTuan);
        SceneManager.LoadScene("Game");
    }

    public void SelectdLong()
    {
        ButtonAudio.PlayOneShot(selectButton,1.0f);
        buildManager.SetplayerToPlay(dLong);
        SceneManager.LoadScene("Game");
    }

    public void SelectdTuanAnh()
    {
        ButtonAudio.PlayOneShot(selectButton, 1.0f);
        buildManager.SetplayerToPlay(dtAnh);
        SceneManager.LoadScene("Game");
    }
}
