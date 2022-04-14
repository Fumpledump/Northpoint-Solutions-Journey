using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public float speed;

    private bool movingRight = true;
    private bool mustTurn = false;

    public Transform groundDetection;
    public Transform wallDetection;
    public LayerMask groundLayer; 

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);


        if (mustTurn)
        {
            if (movingRight)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;
            }
        }

    }

    void FixedUpdate()
    {
        if (!Physics2D.OverlapCircle(groundDetection.position, 0.1f, groundLayer) || Physics2D.OverlapCircle(wallDetection.position, 0.1f, groundLayer))
        {
            mustTurn = true;
        }
        else
        {
            mustTurn = false;
        }
    }
}
