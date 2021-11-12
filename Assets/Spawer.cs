﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawer : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;

    private List<Transform> _spawnPoints;

    private void Awake()
    {
        _spawnPoints = new List<Transform>();
        foreach (Transform item in transform)
            _spawnPoints.Add(item);
        StartCoroutine(SpawnEnemy());
    }

    private IEnumerator SpawnEnemy()
    {
        Transform spawnPoint = _spawnPoints[Random.Range(0, _spawnPoints.Count)];
        Instantiate(_enemy, spawnPoint.position, Quaternion.identity);
        yield return new WaitForSeconds(2);
        StartCoroutine(SpawnEnemy());
    }
}
