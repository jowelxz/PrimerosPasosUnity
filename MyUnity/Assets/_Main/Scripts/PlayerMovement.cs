using System.Collections;
using System.Collections.Generic;
using UnityEditor.XR;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Variables
    [SerializeField] private int edad = 18;
    private float velocidad = 15.5f;
    private string nombre = "Joel";
    private bool IsJumping = false;

    public float fuerza = 500f;

    [SerializeField] private Rigidbody2D _rigidbody2D;


    // Start is called before the first frame update
    void Start()
    {
     
        _rigidbody2D.AddForce(Vector2.right * fuerza);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
