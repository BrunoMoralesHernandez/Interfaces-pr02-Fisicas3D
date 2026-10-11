/**
 * Universidad de La Laguna
 * Escuela Superior de Ingeniería y Tecnología
 * Grado en Ingeniería Informática
 * Interfaces Inteligentes 2026-2027
 * 4º Año de Carrera
 * Práctica: Introducción a Físicas 3D - Ejercicio 2
 *
 * @author Bruno Morales Hernandez alu0101664309@ull.edu.es
 * @brief Script para detectar colisiones en objetos con Rigidbody,
 *        imprimir el nombre del objeto colisionado y modificar su color.
 * @date Oct 11 2026
 * @version 1.0
 */

using UnityEngine;

public class ColisionCubos : MonoBehaviour
{
    private bool huboColision = false;
    private Renderer render;
    private Rigidbody rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        render = GetComponent<Renderer>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (!huboColision && collision.gameObject.name == "Personaje")
        {
            Debug.Log("El personaje " + collision.gameObject.name + " choco con " + gameObject.name);
            render.material.color = Color.red;
            huboColision = true;
        }
    }
}
