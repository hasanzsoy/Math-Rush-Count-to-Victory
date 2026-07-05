using UnityEngine;

public class LevelManager : GenericSingelton<LevelManager>
{
    public void LoadLevel(int levelIndex) 
    {       
        Debug.Log($"Loading Level {levelIndex}");
    }
}
