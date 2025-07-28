using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButtonUI : MonoBehaviour
{
    
    public GameObject startPanel; 
    void Start()
    {
        Time.timeScale = 0f; 
        if (startPanel != null)
            startPanel.SetActive(true); 
    }

    public void OnStartButtonClicked()
    {
        Time.timeScale = 1f; 
        if (startPanel != null)
            startPanel.SetActive(false); 
    }
}
