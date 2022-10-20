using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salamander_move : MonoBehaviour
{
    #region Health_vars
    [SerializeField]
    [Tooltip("Changes what the starting health for salamnder will be ")]
    private float maxhealth;
    private float curhealth;
    #endregion

    #region Movment_vars
    [SerializeField]
    [Tooltip("Changes what the normal move speed is")]
    private float movespeed;
    private Rigidbody2D salRB;
    #endregion

    #region Attack_vars
    [SerializeField]
    [Tooltip("The ammount of damage salamander does on hit")]
    private float dmg;
    [SerializeField]
    [Tooltip("Amount of time between attacks")]
    private float attTimer;
    #endregion


    #region Unity_funcitons
    // Start is called before the first frame update
    void Start()
    {
        curhealth = maxhealth;
        salRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    #endregion

    #region Movement_funcitons
    // private void Move()
    //{

    //    Vector2 direction = new Vector2(x, y);
    //    salRB.velocity = direction;
    //}
    #endregion

    #region Health_functions
    public void TakeDamage(float d)
    {
        curhealth -= d;
        if(curhealth <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    #endregion
}
