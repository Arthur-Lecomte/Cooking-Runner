using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerMouvement : MonoBehaviour {
    public Rigidbody2D rb;
    public int position = 1;
    public float moveDistance = 25f;
    
    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    public void MoveRight() {
        Debug.Log("MoveRight");
        rb.MovePosition(new Vector2(1.5f, -3.5f));
    }
    
    public void MoveMidle() {
        Debug.Log("MoveMidle");
        rb.MovePosition(new Vector2(0f, -3.5f));
    }

    public void MoveLeft() {
        Debug.Log("MoveLeft");
        rb.MovePosition(new Vector2(-1.5f, -3.5f));
    }
}