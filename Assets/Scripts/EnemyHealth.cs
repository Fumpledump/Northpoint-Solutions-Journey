using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public PlayerMovement player;

    public int totalHP;
    public int points = 25;
    private int currentHP;
    

    // Start is called before the first frame update
    void Start()
    {
        currentHP = totalHP;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentHP <= 0)
        {
            Destroy(gameObject);
            player.AddPoints(points);
        }
    }

    public void TakeDamage(int damage)
    {
        currentHP -= damage;
    }
}
