using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float movementSpeed = 0.001F;
    public KeyCode keyUp = new KeyCode();
    public KeyCode keyDown = new KeyCode();
    public KeyCode keyRight = new KeyCode();
    public KeyCode keyLeft = new KeyCode();

    void Update()
    {
        if(Input.GetKey(keyUp))
            transform.Translate(Vector3.up * movementSpeed * 0.005F);
        else if (Input.GetKey(keyDown))
            transform.Translate(Vector3.down * movementSpeed * 0.005F);
        else if (Input.GetKey(keyRight))
            transform.Translate(Vector3.right * movementSpeed * 0.005F);
        else if (Input.GetKey(keyLeft))
            transform.Translate(Vector3.left * movementSpeed * 0.005F);
    }
}
