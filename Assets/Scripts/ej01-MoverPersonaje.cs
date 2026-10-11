/**
 * Universidad de La Laguna
 * Escuela Superior de Ingeniería y Tecnología
 * Grado en Ingeniería Informática
 * Interfaces Inteligentes 2026-2027
 * 4º Año de Carrera
 * Práctica: Introducción a Físicas 3D - Ejercicio 1
 *
 * @author Bruno Morales Hernandez alu0101664309@ull.edu.es
 * @brief Script para controlar el movimiento de un personaje mediante
 *        las teclas WASD o flechas usando Rigidbody en FixedUpdate.
 * @date Oct 11 2026
 * @version 1.0
 */

using UnityEngine;

public class MoverPersonaje : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    private float valorHorizontal;
    private float valorVertical;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        valorHorizontal = Input.GetAxisRaw("Horizontal");
        valorVertical = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        Vector3 direccion = new Vector3(valorHorizontal, 0f, valorVertical).normalized;
        rb.MovePosition(rb.position + direccion * speed * Time.fixedDeltaTime);
    }
}
