using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _goblin;
    [SerializeField] private GameObject[] _spawnPoses;
    [SerializeField] private float _startSpawnTimer;

    private float spawnTimer;

    private void Update()
    {
        if (spawnTimer <= 0)
        {
            Instantiate(_goblin, _spawnPoses[Random.Range(0,_spawnPoses.Length)].transform.position, Quaternion.identity);
            spawnTimer = _startSpawnTimer;
        }
        else
        {
            spawnTimer -= Time.deltaTime;
        }
    }
}
