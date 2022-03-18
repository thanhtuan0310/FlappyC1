using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
    Managers buidManager;

    void Start()
    {
        buidManager = Managers.instance;
        CreatPlayer(buidManager.GetplayerToPlay());
    }

    void CreatPlayer(GameObject player)
    {
        Instantiate(player, transform.position, Quaternion.identity);
    }
}
