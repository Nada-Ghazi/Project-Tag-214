using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    public GameObject winPanel;

    public void WinGame()
    {
        winPanel.SetActive(true);
    }
}