using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;

    private Transform[] _spawnPoints;

    private void Awake()
    {
        _spawnPoints = new Transform[transform.childCount];

        for (int i = 0; i < transform.childCount; i++)
            _spawnPoints[i] = transform.GetChild(i);

        StartCoroutine(SpawnEnemy());
    }

    private IEnumerator SpawnEnemy()
    {
        Transform spawnPoint;
        var waitTime = new WaitForSeconds(2);

        while (true)
        { 
               spawnPoint = _spawnPoints[Random.Range(0, _spawnPoints.Length)];
            Instantiate(_enemy, spawnPoint.position, Quaternion.identity);
            yield return waitTime;
        }
        
    }
}
