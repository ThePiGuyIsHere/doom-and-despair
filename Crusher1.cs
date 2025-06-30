using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crusher1 : MonoBehaviour
{
    public Teleport thing;
    public float speed;
    public int minimumX;
    public int maximumX;
    void Start()
    {
        thing = GameObject.FindGameObjectWithTag("Exit").GetComponent<Teleport>();
    }
    private void Update()
    {
        float newXPosition = transform.position.x + speed * Time.deltaTime;
        float newYPosition = transform.position.y;
        Vector2 newPosition = new Vector2(newXPosition, newYPosition);
        transform.position = newPosition;
        if(transform.position.x > maximumX || minimumX > transform.position.x)
        {
            speed *= -1;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ThrowingObject"))
        {
            thing.enemies--;
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
