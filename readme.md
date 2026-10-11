# Práctica: Introducción a Físicas 3D en Unity

**Asignatura:** Interfaces Inteligentes  
**Titulación:** Grado en Ingeniería Informática — Universidad de La Laguna (ULL)
**Autor:** Bruno Morales Hernández 

---

## 📁 Estructura de Entrega



```text
.
├── Assets/
│   ├── Scenes/
│   │   └── SampleScene.unity      # Escena principal con la batería de pruebas
│   ├── Scripts/                   # Scripts en C# desarrollados para las prácticas
│   └── Settings/                  # Configuraciones URP y perfiles de volumen
├── Gifs/                          # Capturas y animaciones demostrativas de cada situación
├── Packages/                      # Manifiesto de paquetes de Unity
├── ProjectSettings/               # Configuración del motor (Input Manager, Physics, etc.)
└── README.md                      # Documentación y justificación técnica
```

---

## Parte 1: Experimentos con Rigidbody y Colliders

En este bloque se analiza el comportamiento físico y la respuesta de colisiones al modificar las propiedades `Rigidbody` y `Collider` en una escena compuesta por un **Plano**, un **Cubo** y una **Esfera**.

---

### Situación 1
* **Configuración:**
  * **Plano:** `Collider` estático (sin `Rigidbody`).
  * **Cubo:** `Collider` + `Rigidbody` dinámico (`Use Gravity = true`, `Is Kinematic = false`). Posición inicial: $Y = 0.5$.
  * **Esfera:** `Collider` estático (sin `Rigidbody`). Posición elevada.
* **Comportamiento observado:**
  * El cubo cae afectado por la gravedad ($9.81\ \text{m/s}^2$) hasta que su `BoxCollider` hace contacto con el `MeshCollider` del plano, deteniéndose. Si parte de $Y = 0.5$, ya se encuentra apoyado sobre el plano.
  * La esfera permanece suspendida indefinidamente en el aire.
* **Justificación teórica:**
  * Un objeto sin `Rigidbody` se considera un *Static Collider*. No se ve afecto por la gravedad ni fuerzas externas.
  * El plano actúa como superficie estática inamovible frente a objetos dinámicos.
* **Demostración:**  
  ![Situación 1](Gifs/situacion-01.gif)

---