using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameTimer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    static float elapsedTime;

    void Update()
    {
        elapsedTime += Time.deltaTime;
        int minutes = Mathf.FloorToInt(elapsedTime / 60);
        int seconds = Mathf.FloorToInt(elapsedTime % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        Debug.Log("Elapsed Time: " + GetFormattedTime());
        
    }

    public static string GetFormattedTime()
    {
        int minutes = Mathf.FloorToInt((float) elapsedTime / 60);
        int seconds = Mathf.FloorToInt((float) elapsedTime % 60);
        return $"{minutes:D2}:{seconds:D2}";
    }


}
