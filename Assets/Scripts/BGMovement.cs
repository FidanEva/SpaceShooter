using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMovement : MonoBehaviour
{
    private Rigidbody2D _rb2d;
    private BoxCollider2D _bc2d;
    private float _width;
    [SerializeField] private float _bgSpeed;
    void Start()
    {
        _rb2d = GetComponent<Rigidbody2D>();
        _bc2d = GetComponent<BoxCollider2D>();
        _width = _bc2d.size.y * 0.24f;
        _rb2d.velocity= new Vector2(0, _bgSpeed);
    }

    void Update()
    {
        if (transform.position.y < -_width)
        {
            Reposition();
        }
    }
    void Reposition()
    {
        Vector2 newPos = new Vector2(0, _width * 2);
        transform.position = (Vector2)transform.position + newPos;
    }
}
