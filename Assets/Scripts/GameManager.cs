using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [Header("Configuración de Recolección")]
    [SerializeField] private TMP_Text counterText;
    [SerializeField] private GameObject victoryMessage;
    [SerializeField] private int totalCollectibles = 5;

    [Header("Efectos de Sonido")]
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip collectSound; // Asigna aquí también tu .wav por seguridad

    private int currentCollectibles = 0;

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
        UpdateUI();
        
        if (victoryMessage != null)
        {
            victoryMessage.SetActive(false);
        }

        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }
    }

    public void AddCollectible()
    {
        currentCollectibles++;
        UpdateUI();

        // Reproduce el sonido de recolección
        if (audioSource != null)
        {
            if (collectSound != null)
            {
                audioSource.PlayOneShot(collectSound);
            }
            else
            {
                audioSource.Play();
            }
        }

        if (currentCollectibles >= totalCollectibles)
        {
            ShowVictory();
        }
    }

    private void UpdateUI()
    {
        if (counterText != null)
        {
            counterText.text = $"Tesoros: {currentCollectibles} / {totalCollectibles}";
        }
    }

    private void ShowVictory()
    {
        Debug.Log("¡Excelente! Has recolectado todos los elementos del patrimonio.");
        
        if (victoryMessage != null)
        {
            victoryMessage.SetActive(true);
        }
    }
}