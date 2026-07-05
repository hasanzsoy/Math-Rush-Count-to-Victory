using UnityEngine;

public class UIManager2 : MonoBehaviour
{
    public static UIManager2 Instance;

    private void Awake()
    {
        Instance = this;
    }
    public void ShowPauseMenu() 
    {     
        Debug.Log("Pause menu shown");
    }
}
