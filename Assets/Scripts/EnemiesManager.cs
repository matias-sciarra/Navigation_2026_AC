using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemiesManager : MonoBehaviour
{
    public Enemy[] enemies;


    void Start()
    {
        enemies = FindObjectsOfType<Enemy>();
        Debug.Log("Damage points del ultimo enemigo: " + enemies[enemies.Length - 1].damagePoints);
        setalenemiesdamagepointsto(10);
    }

    void setalenemiesdamagepointsto(int value)
    {
        for(int i = 0; i < enemies.Length; i++)
        {
            enemies[i].damagePoints = value;
        }
    }
}

