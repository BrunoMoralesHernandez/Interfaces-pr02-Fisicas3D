/**
 * Universidad de La Laguna
 * Escuela Superior de Ingeniería y Tecnología
 * Grado en Ingeniería Informática
 * Interfaces Inteligentes 2026-2027
 * 4º Año de Carrera
 * Práctica: Introducción a Físicas 3D - Ejercicio 5
 *
 * @author Bruno Morales Hernandez alu0101664309@ull.edu.es
 * @brief Aplica un impulso instantáneo al Rigidbody al pulsar la tecla X
 *        para evaluar la respuesta según el Physic Material configurado.
 * @date Oct 11 2026
 * @version 1.0
 */

using UnityEngine;

public class LanzarObjeto : MonoBehaviour
{
    public Vector3 direccionFuerza = new Vector3(0, 0.5f, -4f);
    public float multiplicadorFuerza = 2f;

    private Rigidbody rb;
    private bool aplicarImpulso = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            aplicarImpulso = true;
        }
    }

    void FixedUpdate()
    {
        if (aplicarImpulso)
        {
            rb.AddForce(direccionFuerza * multiplicadorFuerza, ForceMode.Impulse);
            aplicarImpulso = false;
        }
    }
}