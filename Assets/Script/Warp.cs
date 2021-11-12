using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Warp : MonoBehaviour
{
    Transform player;

    private void Start()
    {
        player = GameObject.Find("Player").transform;
    }

    private void OnTriggerEnter(Collider _col)
    {
        if (_col.CompareTag("Player"))
        {
            //Destroy(player);
            SceneManager.LoadScene(3);
        }
    }
}
