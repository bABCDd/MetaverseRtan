using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartText : MonoBehaviour
{
    public TextMeshProUGUI startText;

    public void SetStart()
    {
        startText.gameObject.SetActive(true);
    }
}
