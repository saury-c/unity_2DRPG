using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    Animator animator;

    public float health {
        set {
            _health = value;

            if (_health <= 0) { defeated(); }
        }

        get { return _health; }
    }

    public float _health = 1f;


    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void takeDamage(float damage)
    {
        health -= damage;
    }


    void removeEnemy()
    {
        Destroy(gameObject);
    }

    public void defeated()
    {
        animator.SetTrigger("death");
    }

}
