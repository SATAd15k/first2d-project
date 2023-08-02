using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //Text meshpro import library

public class Health : MonoBehaviour
{
    TMP_Text healthText;


    private int _health =100;
    private int _maxHealth = 100;

    public void ODisplayHealth()
    {
        if (healthText != null)
        {
            healthText.text = "Health: " + _health;
        }
    }

    public void Dmg(int damage)
    {
        _health -= damage;

        if ( _health <= 0 )
        {
            // _health = 0;
            Destroy(gameObject);
        }
    }

    public void HP(int heal)
    {
        _health = Mathf.Min(_maxHealth, _health + heal);
    }
}
