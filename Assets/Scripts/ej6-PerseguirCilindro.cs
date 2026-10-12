/**
 * Universidad de La Laguna
 * Escuela Superior de Ingeniería y Tecnología
 * Grado en Ingeniería Informática
 * Interfaces Inteligentes 2026-2027
 * 4º Año de Carrera
 * Práctica: Introducción a Físicas 3D - Ejercicio 6
 *
 * @author Bruno Morales Hernandez alu0101664309@ull.edu.es
 * @brief Desplaza la esfera hacia el cilindro objetivo y modifica el material
 *        del cubo obstáculo al entrar en contacto con él.
 * @date Oct 11 2026
 * @version 1.0
 */

using UnityEngine;

public class PerseguirCilindro : MonoBehaviour
{
    public float speed = 2f;
    public Transform cilindro;
    public Material nuevoMaterial;
    public GameObject cubo;

    private Collider colliderCubo;
    private Collider colliderEsfera;
    private bool alcanzado = false;
    void Start()
    {
        colliderEsfera = GetComponent<Collider>();
        if (cubo != null)
        {
            colliderCubo = cubo.GetComponent<Collider>();
        }
    }

    void Update()
    {
        if (cilindro == null)
        {
            return;
        }
        transform.position = Vector3.MoveTowards(transform.position ,cilindro.position, speed * Time.deltaTime);
        if (!alcanzado && colliderEsfera.bounds.Intersects(colliderCubo.bounds))
        {
            alcanzado = true;
            cubo.GetComponent<Renderer>().material = nuevoMaterial;
        }
    }
}