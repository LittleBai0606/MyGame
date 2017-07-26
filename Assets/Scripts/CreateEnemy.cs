using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;
using UnityEngine;

public class CreateEnemy : MonoBehaviour
{
    public GameObject EnemyPrefabs;

    void Start()
    {
            for (int i = 0; i < 10; i++)
            {
                Vector3 pos = new Vector3(Random.Range(-2.594f, 2.594f), Random.Range(-4.78f, 4.78f), 0);
                Instantiate(EnemyPrefabs, pos, Quaternion.identity);
            }
    }
}
