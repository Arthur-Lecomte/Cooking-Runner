using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerMouvement : MonoBehaviour {
    public Rigidbody2D rb;
    
    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }
    
    // Des boutons invisible permettent de déplacer le joueur
    public void MoveRight() {
        rb.MovePosition(new Vector2(1.5f, -3.5f));
    }
    
    public void MoveMidle() {
        rb.MovePosition(new Vector2(0f, -3.5f));
    }

    public void MoveLeft() {
        rb.MovePosition(new Vector2(-1.5f, -3.5f));
    }
}