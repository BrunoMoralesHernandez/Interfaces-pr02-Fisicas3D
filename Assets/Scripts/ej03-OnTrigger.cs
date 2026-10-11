/**
 * Universidad de La Laguna
 * Escuela Superior de Ingeniería y Tecnología
 * Grado en Ingeniería Informática
 * Interfaces Inteligentes 2026-2027
 * 4º Año de Carrera
 * Práctica: Introducción a Físicas 3D - Ejercicio 3
 *
 * @author Bruno Morales Hernandez alu0101664309@ull.edu.es
 * @brief Script que detecta la entrada y salida del personaje en una zona Trigger,
 *        activando la emisión de luz del cubo y alterando temporalmente el color del jugador.
 * @date Oct 11 2026
 * @version 1.0
 */

using UnityEngine;

public class OnTriggerCubo : MonoBehaviour
{
    public float brillo;
    private Renderer renderCubo;

  void Start()
  {
    renderCubo = GetComponent<Renderer>();
    renderCubo.material.EnableKeyword("_EMISSION");
  }

  void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Personaje")
        {
            renderCubo.material.SetColor("_EmissionColor", Color.softYellow * brillo);
            other.gameObject.GetComponent<Renderer>().material.color = Color.blue;     
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Personaje")
        {
            renderCubo.material.SetColor("_EmissionColor", Color.black);
            other.gameObject.GetComponent<Renderer>().material.color = Color.grey;
        }
    }
}
