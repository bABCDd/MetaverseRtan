using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneChange : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("potal"))
        {
            // Load the next scene
            SceneManager.LoadScene("MiniGameScene");
        }
    }
}
