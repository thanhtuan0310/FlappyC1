using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour
{
    public static Managers instance;

    private GameObject playertoPlay;
     void Awake()
    {
        /*if(instance == null)
        {
            instance = this;
        } else if(instance != this){
            Destroy(gameObject);
        }*/
        if (instance != null)
        {
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
    }
    // Start is called before the first frame update
   
    public void SetplayerToPlay(GameObject player)
    {
        playertoPlay = player;
    }
    public GameObject GetplayerToPlay()
    {
        return playertoPlay;
    }
}
