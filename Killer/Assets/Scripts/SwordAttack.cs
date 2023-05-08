using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : MonoBehaviour
{

    public float damage = 3;

    public Collider2D swordCollider;

    Vector2 rightAttackOffset;

    void Start()
    {
        rightAttackOffset = transform.position;
    }

    public void attackRight()
    {
        swordCollider.enabled = true;
        //transform.position = rightAttackOffset;
    }

    public void attackLeft()
    {
        swordCollider.enabled = true;
        //transform.position = new Vector3(transform.position.x*-1, transform.position.y);  // 怎么取反方向啊?? 攻击左边有问题

    }

    public void stopAttack()
    {
        swordCollider.enabled = false;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            Enemy enemy = collision.GetComponent<Enemy>();
            if (enemy == null) { return; }
            enemy.health -= damage;
        }
    }

}
