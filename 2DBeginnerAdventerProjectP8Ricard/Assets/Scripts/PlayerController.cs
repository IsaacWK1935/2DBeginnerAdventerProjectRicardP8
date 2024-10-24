using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    float horizontal;
    float vertical;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }    

    void FixedUpdate()
    {
        Vector2 position = transform.position;
        position.x = position.x + 7.0f * horizontal * Time.deltaTime;
        position.y = position.y + 7.0f * vertical * Time.deltaTime;
        
        rigidbody2d.MovePosition(position);
    }
}