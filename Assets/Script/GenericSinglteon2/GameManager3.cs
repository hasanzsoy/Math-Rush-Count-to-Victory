using UnityEngine;

public class GameManager3 : MonoBehaviour
{
    public void PauseGame()
    {
        UIManager2.Instance.ShowPauseMenu(); // Show the pause menu
    }

    public void StartGame() 
    {
        LevelManager.Instance.LoadLevel(1); // Load level 1
    }
}
