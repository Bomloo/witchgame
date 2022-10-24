using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card 
{
    #region Name_Vars
    public string suit;
    public int number;
    #endregion

    public bool isActive;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    #region Name_funcs
    //universal so we can set the suit and number and acess them later
    void SetSuitandNumber(string s, int n)
    {
        suit = s;
        number = n;
    }

    #endregion

    #region Card_Funcs
    //will be overided
    void Active() { }


    //will be overided
    void StartPassive() { }
    #endregion

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.CompareTag("Player"))
        {

        }
    }
}
