using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.XR;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Variables
 
    public float altura = 1.68f;
    public int edad = 18;
    public string nombre = "Joel";
    public bool puedeVotar = true;

    public GameObject gameObject;
    public Rigidbody2D rigidbody2D;
    public Collider2D collider2D;
    public SpriteRenderer spriteRenderer;

    //Crear una variable de tipo transform para almacenar la posición del jugador

    public Transform transform;


    private void Start()
 {
        Debug.Log("Hola: " + nombre + " Tu edad es: " + edad + " Tu altura es: " + altura);
        rigidbody2D.simulated = false;
        spriteRenderer.color = Color.red;

        //Llamo la variable de tipo transform y le asigno un valor en  x de 10

        transform.position = new Vector3(10, 0, 0);
    }

 private void update()
 {

 }

}