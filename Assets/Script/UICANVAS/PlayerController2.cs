using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController2 : MonoBehaviour
{
    [Header("Health Settings")]
    public float health;

    [Header("UI Components")]
    public Slider healthBarSlider;
    public TMP_Text healthText;
    public Image bloodHitEffect;

    [Header("Effects & Audio")]
    public AudioSource audioSource;
    public AudioClip hitClip;
    public Transform cameraTransform; // Kamera sarsıntısı için
    public float fadeDuration = 0.5f;

    private Tween bloodTween;

    private void Start()
    {
        InitializeHealth();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(5);
        }
    }

    private void InitializeHealth()
    {
        healthBarSlider.maxValue = health;
        healthBarSlider.value = health;
        // Başlangıçta kan efektini tamamen şeffaf yap
        bloodHitEffect.color = new Color(1, 1, 1, 0);
    }

    public void TakeDamage(float damageAmount)
    {
        UpdateHealth(damageAmount);
        PlayHitEffects();
    }

    private void UpdateHealth(float amount)
    {
        health = Mathf.Clamp(health - amount, 0, healthBarSlider.maxValue);
        healthBarSlider.value = health;
        healthText.text = health.ToString("F0");
    }

    private void PlayHitEffects()
    {
        // 1. Ses Çal
        if (audioSource && hitClip) audioSource.PlayOneShot(hitClip);

        // 2. Kan Efekti (DOTween)
        TriggerBloodEffect();

        // 3. Kamera Sarsıntısı (DOTween)
        if (cameraTransform)
        {
            cameraTransform.DOComplete(); // Varsa önceki sarsıntıyı bitir
            cameraTransform.DOShakePosition(0.3f, 0.2f, 10, 90f);
        }
    }

    private void TriggerBloodEffect()
    {
        if (bloodTween != null)
            bloodTween.Kill();

        // Alpha'yı 1'e çek
        bloodHitEffect.color = new Color(bloodHitEffect.color.r, bloodHitEffect.color.g, bloodHitEffect.color.b, 1f);

        // 0'a doğru fade et
        bloodTween = bloodHitEffect.DOFade(0f, fadeDuration);
    }
}
