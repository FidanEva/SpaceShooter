using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RocketMovement : MonoBehaviour
{
    private float _horizontal;
    [SerializeField] private float _speed;
    void Start()
    {
        
    }

    void Update()
    {
        _horizontal = Input.GetAxis("Horizontal");
        //_horizontal = Mathf.Clamp(_horizontal, -2, 2);
        transform.position += new Vector3(_horizontal, 0, 0) * _speed * Time.deltaTime;
        float xPos = Mathf.Clamp(transform.position.x, -2, 2);
        transform.position = new Vector3(xPos, transform.position.y, transform.position.z);

        //if (transform.position.x < -2 || transform.position.x > 2)
        //{
        //    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //}
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            //Debug.Log("Died");
        }
    }
}
