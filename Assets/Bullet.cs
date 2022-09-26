using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour 
{
    public float Speed;

    private Rigidbody2D Rigidbody2D;
    private Vector2 Direction;

    // Start is called before the first frame update
    void Start()
    {
        Speed = 2.0f;
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Rigidbody2D.velocity = Direction * Speed;
    }

    public void SetDirection(Vector2 NewDirection) {
        Direction = NewDirection;
    }

    public void DestroyBullet() {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}