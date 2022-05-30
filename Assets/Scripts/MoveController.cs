using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    Rigidbody2D _rb;
    [SerializeField] float _speed;
    GameObject _background;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _background = GameObject.FindGameObjectWithTag("Background");
    }

    private void FixedUpdate()
    {
        OnClick();
    }

    void Move()
    {
        _rb.velocity = new Vector2(0, 1 * Time.deltaTime * _speed);
    }

    void OnClick()
    {
        Move();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Circle"))
        {
            transform.SetParent(collision.transform);
            _speed = 0;
        }

        if (collision.gameObject.CompareTag("Rod"))
        {
            _background.GetComponent<SpriteRenderer>().color = Color.red;
        }
    }

}
