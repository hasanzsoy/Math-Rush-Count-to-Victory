using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform player;
    public SpawnerSystem spawner;

    public float speed = 2f;

    float life = 0;

    void Update()
    {
        if (player == null) return;

        life += Time.deltaTime;

        
        Vector3 dir = (player.position - transform.position).normalized;
        transform.position += dir * speed * Time.deltaTime;

        float dist = Vector3.Distance(transform.position, player.position);

       
        if (dist < 1.5f)
        {
            DestroyMe();
        }

       
        if (life > 6f)
        {
            DestroyMe();
        }
    }

    void DestroyMe()
    {
        spawner.EnemyDied();
        Destroy(gameObject);
    }
}
