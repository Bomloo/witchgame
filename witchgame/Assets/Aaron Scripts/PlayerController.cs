using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody2D rb;
    public BoxCollider2D bc;
    public GameObject origin;

    public bool crouch_state = false;
    public bool move_state = false;

    public int health = 100;

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
        crouch_state = false;
        bc.enabled = true;
        Vector2 target_velocity = new Vector2(x, y);
        rb.velocity = target_velocity;
        //Debug.Log("moving");
    }

    public void attack()
    {
        Debug.Log("attacking");
    }

    public void crouch()
    {
        crouch_state = true;
        move_state = false;
        bc.enabled = false;
        Debug.Log("crouching");
    }

    public void take_dmg(int dmg)
    {
        if (health > 0)
        {
            health -= dmg;
        }
    }
}
