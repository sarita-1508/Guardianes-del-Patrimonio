using UnityEngine;
using TMPro;

public class InteractableObject : MonoBehaviour
{
    [Header("Contenido Educativo")]
    [SerializeField] private string objectTitle = "Artefacto Histórico";
    [TextArea(3, 6)]
    [SerializeField] private string educationalContent = "Escribe aquí la información sobre este patrimonio...";

    [Header("Referencias UI")]
    [SerializeField] private GameObject infoPanel;
    [SerializeField] private TMP_Text titleText;
    [SerializeField] private TMP_Text contentText;
    [SerializeField] private GameObject interactionPrompt; // Icono flotante "E"

    private bool isPlayerInRange = false;
    private bool isPanelOpen = false;

    private void Start()
    {
        if (infoPanel != null) infoPanel.SetActive(false);
        if (interactionPrompt != null) interactionPrompt.SetActive(false);
    }

    private void Update()
    {
        if (isPlayerInRange && Input.GetKeyDown(KeyCode.E))
        {
            if (!isPanelOpen)
            {
                OpenInfo();
            }
            else
            {
                CloseInfo();
            }
        }
    }

    private void OpenInfo()
    {
        isPanelOpen = true;
        if (infoPanel != null) infoPanel.SetActive(true);
        if (interactionPrompt != null) interactionPrompt.SetActive(false);

        if (titleText != null) titleText.text = objectTitle;
        if (contentText != null) contentText.text = educationalContent;
    }

    private void CloseInfo()
    {
        isPanelOpen = false;
        if (infoPanel != null) infoPanel.SetActive(false);
        if (isPlayerInRange && interactionPrompt != null) interactionPrompt.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isPlayerInRange = true;
            if (!isPanelOpen && interactionPrompt != null)
                interactionPrompt.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isPlayerInRange = false;
            CloseInfo();
            if (interactionPrompt != null)
                interactionPrompt.SetActive(false);
        }
    }
}