using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speedright = 10;
    public Rigidbody2D rb;
    public float speedleft = -10;
    public float jumpheight = 50;

    void Update()
    {

        if (Input.GetKey("d"))
        {
            rb.velocity = new Vector2(speedright, 0 * Time.deltaTime);
        }

        if (Input.GetKey("a"))
        {
            rb.velocity = new Vector2(speedleft, 0 * Time.deltaTime);
        }
    }
}
