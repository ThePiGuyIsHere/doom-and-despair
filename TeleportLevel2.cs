using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportLevel2 : MonoBehaviour
{
    public int enemies;
    public int coins;
    // Start is called before the first frame update
    void Start()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy").Length;
        coins = GameObject.FindGameObjectsWithTag("Escaper").Length;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && enemies == 0 && coins == 0)
        {
            SceneManager.LoadScene(2);
        }
    }
}
