using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ThrowObject : MonoBehaviour
{
    public TextMeshProUGUI collectableText;
    public GameObject objectThrown;
    public Vector3 offset;
    public int ammo;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && ammo > 0)
        {
            ammo--;
            offset = transform.localScale.x * new Vector3(1, 0, 0);
            Vector3 throwablePosition = transform.position + offset;
            Instantiate(objectThrown, throwablePosition, transform.rotation);
        }
        collectableText.text = ammo.ToString();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Collectable"))
        {
            Destroy(collision.gameObject);
            ammo++;
        }
    }
}
