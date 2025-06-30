using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class projectile : MonoBehaviour
{
    public GameObject player;
    public Vector3 direction;
    public int speed;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        // Set movement direction based on local scale (left or right)
        direction = player.transform.localScale.x * new Vector3(1, 0, 0);

        // Start the self-destruct timer
        Invoke("DestroyShuriken", 1f);
    }
    void Update()
    {
    }
    void FixedUpdate()
    {
        transform.position += direction * Time.deltaTime * speed;
    }

    private void DestroyShuriken()
    {
        Destroy(gameObject);
    }
}
