using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI _textMeshPro;
    public static float lifeTimer = 30f;
    float gameTime;
    
    void Update()
    {
        if (lifeTimer >= 0)
        {
            _textMeshPro.text = "Дождитесь конца таймера " + lifeTimer;
            gameTime += 1 * Time.deltaTime;
            if (gameTime >= 1)
            {
                lifeTimer--;
                gameTime = 0;
            }
        }
    }
}
