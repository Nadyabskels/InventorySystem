using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public class Player_movement1 : MonoBehaviour
{

    Rigidbody2D myRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update() { }
    void FixedUpdate()
    {
        int X = 10;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            myRigidbody.AddForce(new Vector2((-X), 0));

        }
        //Lägger till en
        if (Input.GetKey(KeyCode.RightArrow))
        {
            myRigidbody.AddForce(new Vector2(X, 0));
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            myRigidbody.AddForce(new Vector2(0, 0));
        }


        //---------------------------------------
        if (Input.GetKey(KeyCode.A))
        {
            myRigidbody.AddForce(new Vector2((-X), 0));

        }

        if (Input.GetKey(KeyCode.D))
        {
            myRigidbody.AddForce(new Vector2(X, 0));
        }

        if (Input.GetKey(KeyCode.W))
        {
            myRigidbody.AddForce(new Vector2(0, 0));
        }
    }
}
