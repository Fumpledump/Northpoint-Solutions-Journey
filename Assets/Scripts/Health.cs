using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations;

public class Health : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth = 4;

    public Animator animator;

    private void Start()
    {
        currentHealth = maxHealth;
        animator.SetInteger("Health", currentHealth);
    }

    private void Update()
    {
        animator.SetInteger("Health", currentHealth);
    }


}
