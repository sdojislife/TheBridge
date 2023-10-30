using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private Vector2 _speed;
    private void Update()
    {
        transform.Translate(_speed * Time.deltaTime);
    }
}