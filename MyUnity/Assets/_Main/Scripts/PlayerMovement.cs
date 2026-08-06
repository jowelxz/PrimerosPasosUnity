using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.XR;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _force = 5f;
    [SerializeField] private float _speed = 5f;
    [SerializeField] private Rigidbody2D _rigidbody2D;
    

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();

    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            _rigidbody2D.AddForce(Vector2.up * _force);
            
        }
        _rigidbody2D.velocity = Vector2.right * _speed;

    }

}