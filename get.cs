using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;


public class get : MonoBehaviour
{
    [SerializeField]
    private bool pickUpAllowed;

    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        if(pickUpAllowed && Input.GetKeyDown(KeyCode.Space))// CODE WHEN PICKING UP THE PARCEL WITH CERTAIN KEY
            pickUp();
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.gameObject.name.Equals("car3"))
        {
            pickUpAllowed = true;
        }
    }

  

    private void pickUp()
    {
        Destroy(gameObject);// TO DESTROY THE GAME OBJECT
    }
}
