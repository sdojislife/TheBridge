using UnityEngine;
using TMPro;
public class Score : MonoBehaviour
{
    private TextMeshProUGUI _text;
    private int _score;
    private void Start()
    {
        _text = GetComponent<TextMeshProUGUI>();
        InvokeRepeating("UpdateScore", 1f, 1f);
    }
    public void UpdateScore()
    {
        _score++;
        _text.text = _score.ToString();
    }
}
