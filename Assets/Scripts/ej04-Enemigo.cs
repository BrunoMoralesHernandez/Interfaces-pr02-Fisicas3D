/**
 * Universidad de La Laguna
 * Escuela Superior de Ingeniería y Tecnología
 * Grado en Ingeniería Informática
 * Interfaces Inteligentes 2026-2027
 * 4º Año de Carrera
 * Práctica: Introducción a Físicas 3D - Ejercicio 4
 *
 * @author Bruno Morales Hernandez alu0101664309@ull.edu.es
 * @brief Script para verificar la colisión física del enemigo con el jugador.
 * @date Oct 11 2026
 * @version 1.0
 */

using UnityEngine;

public class Enemigo : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // Se ignora el suelo para no saturar la consola
        if (collision.gameObject.name != "Plane")
        {
            Debug.Log($"[Enemigo] Colision fisica detectada con: {collision.gameObject.name} (Capa: {LayerMask.LayerToName(collision.gameObject.layer)})");
        }
    }
}