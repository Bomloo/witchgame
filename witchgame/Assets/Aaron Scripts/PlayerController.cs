using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody2D rb;
    public BoxCollider2D bc;
    public GameObject shootpt;

    public bool crouch_state = false;
    public bool move_state = false;

    public int health = 100;
    public int max_health = 100;
    public int shield = 0;
    public int max_shield = 0;

    public int range = 10;
    public float dmg = 20;
    public float crit_rate = 0.1f;
    public float crit_dmg = 1.2f;
    public int ammo = 2;
    public int max_ammo = 2;
    
    //add hp max
    //add shields max
    //heal hp
    //shield refresh
    //critrate
    //ammo

    

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
        RaycastHit2D hit = Physics2D.Raycast(shootpt.transform.position, shootpt.transform.up, range);
        if (hit.collider == null)
        {
            Debug.Log("missed");
        }
        else
        {
            Debug.Log("attacking" + hit.transform.name);
        }
        
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
