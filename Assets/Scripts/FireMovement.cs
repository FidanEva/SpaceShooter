using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireMovement : MonoBehaviour
{
    [SerializeField] private float _bulletSpeed = 10;

    void Update()
    {
        transform.Translate(Vector3.up * _bulletSpeed * Time.deltaTime);
        Destroy(gameObject, 2);
    }

}
