using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _obstaclePrefab;

    void Start()
    {
        InvokeRepeating("InstantObstacle", 0, 1);
    }
    void InstantObstacle()
    {
        int posX = Random.Range(-2, 3);
        Instantiate(_obstaclePrefab, transform.position + new Vector3(posX, 0, 0), Quaternion.identity);
    }
}
