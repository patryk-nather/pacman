using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setup : MonoBehaviour {
    private Camera MainCam = new Camera();
    private BoxCollider2D TopWall = new BoxCollider2D();

    
    // Update is called once per frame
    void Update () {
        TopWall.size = new Vector2(MainCam.ScreenToWorldPoint(new  Vector3(15f, 0f, 0f)).x, 1f);
        TopWall.offset = new Vector2(0f, MainCam.ScreenToWorldPoint(new Vector3(0f, 12f, 0f)).y + 0.5f);
	}
}