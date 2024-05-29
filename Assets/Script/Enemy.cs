using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health = 50f;
    public int points = 10;

    public void GetDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            GameMan.instance.UpdateScore(points);
            Destroy(this.gameObject);
        }
    }
}
