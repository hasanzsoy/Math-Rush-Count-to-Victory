using DG.Tweening;
using UnityEngine;

public class SphereEnemy : MonoBehaviour, IDamageable
{
    public float health;
    private void OnMouseDown()
    {
        TakeDamage(10f);
        GetComponent<Renderer>().material.DOColor(Color.white, 0.2f).OnComplete(() =>
        {
            GetComponent<Renderer>().material.DOColor(Color.red, 0.2f);
        });
    }
    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
