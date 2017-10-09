using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class borderBounds : MonoBehaviour {

    private Rigidbody2D rb2 = new Rigidbody2D();
    
    public Rigidbody2D Rb2
    {
        get
        {
            return rb2;
        }

        set
        {
            rb2 = value;
        }
    }
    
    // Use this for initialization
    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource aso = new AudioSource();
        aso.Play();
    }

}
