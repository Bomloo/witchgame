using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody2D rb;
    public BoxCollider2D bc;

    public bool crouch_state = false;
    public bool move_state = false;

    // key down on crouch, key up no crouch
    // crouch only active behind cover, needs detection
    // player controller does the actual work
    // player movement triggers controller functions to move
    void Start()
    {
        
    }

    public void move(float x, float y)
    {
        move_state = true;
        Vector2 target_velocity = new Vector2(x, y);
        rb.velocity = target_velocity;
    }

    public void attack()
    {

    }

    public void crouch()
    {
        //crouch_state = state;
        Debug.Log("crouching");
    }
}
