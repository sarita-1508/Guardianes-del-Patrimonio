using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance { get; private set; }

    [Header("Slots del Inventario (Imágenes UI)")]
    [SerializeField] private Image slotEspada;
    [SerializeField] private Image slotCorona;
    [SerializeField] private Image slotAnillo;
    [SerializeField] private Image slotCaliz;
    [SerializeField] private Image slotCollar;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        // Al iniciar el juego, dejamos todos los slots en gris oscuro (apagados)
        ApagarSlot(slotEspada);
        ApagarSlot(slotCorona);
        ApagarSlot(slotAnillo);
        ApagarSlot(slotCaliz);
        ApagarSlot(slotCollar);
    }

    private void ApagarSlot(Image slot)
    {
        if (slot != null)
        {
            // Color gris oscuro y opacidad baja para indicar que no ha sido recolectado
            slot.color = new Color(0.2f, 0.2f, 0.2f, 0.4f);
        }
    }

    private void EncenderSlot(Image slot)
    {
        if (slot != null)
        {
            // Color blanco original (a todo color) y opacidad completa
            slot.color = new Color(1f, 1f, 1f, 1f);
        }
    }

    // Métodos públicos para encender cada ícono al recolectarlo
    public void ActivarEspada() => EncenderSlot(slotEspada);
    public void ActivarCorona() => EncenderSlot(slotCorona);
    public void ActivarAnillo() => EncenderSlot(slotAnillo);
    public void ActivarCaliz()  => EncenderSlot(slotCaliz);
    public void ActivarCollar() => EncenderSlot(slotCollar);
}