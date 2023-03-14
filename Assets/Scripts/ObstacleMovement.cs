using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 4;
    [SerializeField] private float _rotateSpeed = 30;

    void Update()
    {
        transform.Translate(-Vector3.up * _moveSpeed * Time.deltaTime, Space.World);
        transform.Rotate(Vector3.forward * _rotateSpeed * Time.deltaTime, Space.Self);
        Destroy(gameObject, 3);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            Destroy(gameObject);
            //Debug.Log("Crushed");
        }
    }
}
