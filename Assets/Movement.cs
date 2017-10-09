using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public KeyCode keyUp = new KeyCode();
    public KeyCode keyDown = new KeyCode();
    public KeyCode keyRight = new KeyCode();
    public KeyCode keyLeft = new KeyCode();

    private Rigidbody2D rb2;

    private void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetKey(keyUp))
        {
            rb2.velocity = new Vector2(0, 2f);
        }
        else if (Input.GetKey(keyDown))
        {
            rb2.velocity = new Vector2(0, -2f);
        }
        else if (Input.GetKey(keyRight))
        {
            rb2.velocity = new Vector2(2f, 0);
        }
        else if (Input.GetKey(keyLeft))
        {
            rb2.velocity = new Vector2(-2f, 0);
        }
        else
        {
            rb2.velocity = new Vector2(0, 0);
        }
    }
}
