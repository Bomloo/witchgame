using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public PlayerController controller;


    float horizontal_move = 0f;
    public float run_speed = 40f;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //gets horizontal axis, at base, a = -1, d = 1, still = 0
        horizontal_move = Input.GetAxisRaw("Horizontal") * run_speed;

        //hold c 
        controller.crouch_state = Input.GetKeyDown(KeyCode.C);
    }

    private void FixedUpdate()
    {
        controller.move(horizontal_move);
    }
}
