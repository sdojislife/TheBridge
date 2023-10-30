using UnityEngine;

public class Player : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Obstacle obstacle))
        {
            Destroy(GlobalData.Score);
            GlobalData.GameOver.enabled = true;
            GlobalData.GameOver.ShowUI();
        }
    }
}
