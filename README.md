# Guardianes del Patrimonio

Videojuego educativo en 2D desarrollado en **Unity** enfocado en la exploración museística y la recuperación de patrimonio histórico.

## 📌 Descripción del Proyecto
"Guardianes del Patrimonio" es un *Serious Game* donde el personaje principal (Sara) debe recorrer un escenario en dos dimensiones, interactuar con personajes no jugables (NPCs) y recolectar cinco piezas de tesoros históricos clave, fomentando el aprendizaje cultural a través de mecánicas interactivas y dinámicas de HUD en tiempo real.

## 🛠️ Arquitectura Técnica y Componentes
- **Motor de Juego:** Unity (Versión LTS recomendada).
- **Lenguaje de Programación:** C#.
- **Patrones de Diseño:** Patrón *Singleton* implementado en los gestores globales (`GameManager`, `InventoryManager`).
- **Físicas:** Uso de componentes `Rigidbody2D` y `BoxCollider2D` configurados en modo *Trigger* para la detección de proximidad e interacciones.
- **Interfaz de Usuario (UI):** Canvas adaptativo (`Scale With Screen Size`) con paneles dinámicos de inventario, contadores en tiempo real y diálogos interactivos.

## 📂 Estructura del Repositorio
- `Assets/`: Contiene los scripts en C#, escenas, recursos gráficos, prefabs y elementos del entorno.
- `Packages/`: Dependencias y paquetes del proyecto gestionados por Unity.
- `ProjectSettings/`: Configuraciones globales del motor y físicas.
- `.gitignore`: Configuración estándar para excluir carpetas temporales y pesadas (como `Library/` o `Temp/`).

## 🚀 Cómo Ejecutar el Proyecto
1. Clonar o descargar este repositorio.
2. Abrir **Unity Hub**.
3. Seleccionar la opción *Add project from disk* y elegir la carpeta principal de este repositorio.
4. Abrir la escena principal dentro de la carpeta `Assets/Scenes` y presionar el botón de reproducción (*Play*).
