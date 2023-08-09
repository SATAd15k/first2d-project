// Enemy Movement based off capela: https://github.com/CapelaGames/First2DProjectafteroon2023.2

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 
[RequireComponent(typeof(Health))]

public class EnemyManager : MonoBehaviour
{
    private Health _health;

    public int Damage = 20;
    // Start is called before the first frame update
    void Start()
    {
        _health = GetComponent<Health>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Fireball fireball = collision.GetComponent<Fireball>();
        if (fireball != null)
        {
            _health.Dmg(fireball.Damage);
            Destroy(fireball.gameObject);
        }
    }
}
