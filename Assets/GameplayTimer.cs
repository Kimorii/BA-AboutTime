using UnityEngine;

public class GameplayTimer : MonoBehaviour
{
    
    private static double StartTime;
    private static double StopTime;
    public static double ElapsedTime = 0;


    public static void StartTimer() 
    {
        StartTime = Time.fixedUnscaledTimeAsDouble;
        Debug.Log("Timer started:" + ElapsedTime);
    } 
    public static void StopTimer()
    {
        StopTime = Time.fixedUnscaledTimeAsDouble;
        ElapsedTime += StopTime - StartTime;
        StartTime = StopTime;
        Debug.Log("Timer stopped at:" + ElapsedTime);
    }

    public static double GetTime() => ElapsedTime;

    public static string GetFormattedTime()
    {
        int minutes = Mathf.FloorToInt((float) ElapsedTime / 60);
        int seconds = Mathf.FloorToInt((float) ElapsedTime % 60);
        return $"{minutes:D2}:{seconds:D2}";
    }
}
