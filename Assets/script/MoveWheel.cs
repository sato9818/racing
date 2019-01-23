using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWheel : MonoBehaviour {

    Rigidbody rb;
    float speed = 0f;
    float movePower = 0.2f;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey("up"))
        {
            Accel(); //アクセル
        }
        if (Input.GetKey("right"))
        {
            Right(); //右移動
        }
        if (Input.GetKey("left"))
        {
            Left(); //左移動
        }
        if (Input.GetKey("down"))
        {
            Brake();
        }
        /*
        //減速
        speed -= 2f;
        //最低速度

        if (speed < 0) {
            speed = 0f;
        } 
        */

    }

    void Accel()
    {
        speed += 0.1f;
        rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, speed);
    }

    void Right()
    {
        //if (transform.position.x <= 5f) {
        Vector3 temp = new Vector3(transform.position.x + movePower, transform.position.y, transform.position.z);
        transform.position = temp;
        //}
    }

    public void Left()
    {
        // if (transform.position.x >= -5f) {
        Vector3 temp = new Vector3(transform.position.x - movePower, transform.position.y, transform.position.z);
        transform.position = temp;
        //}
    }
    void Brake()
    {
        speed -= 0.1f;
        rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, speed);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
