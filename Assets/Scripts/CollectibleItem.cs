using UnityEngine;

public class CollectibleItem : MonoBehaviour
{
    public enum TipoTesoro
    {
        Espada,
        Corona,
        Anillo,
        Caliz,
        Collar
    }

    [Header("Configuración del Ítem")]
    [SerializeField] private string itemName = "Objeto Histórico";
    [SerializeField] private TipoTesoro tipoTesoro;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Verifica si el objeto que colisiona es el jugador
        if (collision.CompareTag("Player"))
        {
            Debug.Log("¡Recogiste: " + itemName + "!");

            // 1. Enciende el ícono en la UI del inventario
            if (InventoryManager.Instance != null)
            {
                switch (tipoTesoro)
                {
                    case TipoTesoro.Espada:
                        InventoryManager.Instance.ActivarEspada();
                        break;
                    case TipoTesoro.Corona:
                        InventoryManager.Instance.ActivarCorona();
                        break;
                    case TipoTesoro.Anillo:
                        InventoryManager.Instance.ActivarAnillo();
                        break;
                    case TipoTesoro.Caliz:
                        InventoryManager.Instance.ActivarCaliz();
                        break;
                    case TipoTesoro.Collar:
                        InventoryManager.Instance.ActivarCollar();
                        break;
                }
            }

            // 2. Llama al GameManager para sumar el ítem al contador
            if (GameManager.Instance != null)
            {
                GameManager.Instance.AddCollectible();
            }

            // 3. Destruye el objeto en la escena
            Destroy(gameObject);
        }
    }
}