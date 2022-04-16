using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Coin : MonoBehaviour
{
    private Object thisCoin;
    public int points = 10;
    public PlayerMovement player;

    void Awake()
    {
        thisCoin = GetComponent<Object>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
            player.AddPoints(points);
        }
    }

    
}
