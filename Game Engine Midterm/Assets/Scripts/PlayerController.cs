using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector3 movement;
    private float speed = 0.025f;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            movement.x -= speed;
            rb.MovePosition(movement);
        }
        if (Input.GetKey(KeyCode.D))
        {
            movement.x += speed;
            rb.MovePosition(movement);
        }
    }
}
