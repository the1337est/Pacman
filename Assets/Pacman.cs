using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pacman : MonoBehaviour {

    Rigidbody2D rb;
    public float Speed = 3f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update ()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.rotation = Quaternion.Euler(Vector3.zero);
            rb.position += Vector2.right * Time.deltaTime * Speed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, -180f));
            rb.position += Vector2.left * Time.deltaTime * Speed;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, 90f));
            rb.position += Vector2.up * Time.deltaTime * Speed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, -90f));
            rb.position += Vector2.down * Time.deltaTime * Speed;
        }

        if (transform.position.x > 4.5f)
        {
            transform.position = new Vector3(-4.5f, transform.position.y, 0f);
        }
        if (transform.position.x < -4.5f)
        {
            transform.position = new Vector3(4.5f, transform.position.y, 0f);
        }

    }
}
