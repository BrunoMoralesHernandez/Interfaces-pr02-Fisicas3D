/**
 * Universidad de La Laguna
 * Escuela Superior de Ingeniería y Tecnología
 * Grado en Ingeniería Informática
 * Interfaces Inteligentes 2026-2027
 * 4º Año de Carrera
 * Práctica: Introducción a Físicas 3D - Ejercicio 4
 *
 * @author Bruno Morales Hernandez alu0101664309@ull.edu.es
 * @brief Script para verificar la detección por trigger de los objetos recolectables.
 * @date Oct 11 2026
 * @version 1.0
 */

using UnityEngine;

public class Recolectable : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"[Recolectable] Trigger activado por: {other.gameObject.name} (Capa: {LayerMask.LayerToName(other.gameObject.layer)})");
    }
}