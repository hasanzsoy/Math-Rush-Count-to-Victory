using UnityEngine;

public class GameManager : MonoBehaviour
{
    public SpawnerSystem spawner;
    public int dangerThreshold = 6;

    void Update()
    {
        if (spawner.GetEnemyCount() >= dangerThreshold)
        {
            Debug.Log("Overwhelmed");
        }
    }
}
