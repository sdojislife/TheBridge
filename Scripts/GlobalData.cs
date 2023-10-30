using UnityEngine;

public class GlobalData : MonoBehaviour
{
    public static Score Score;
    public static GameOver GameOver;
    private void Start()
    {
        Score = FindObjectOfType<Score>();
        GameOver = FindObjectOfType<GameOver>();
    }
}
