using UnityEngine;

public class SetRandomPosition : MonoBehaviour
{
    [SerializeField] private int _x1, _x2, _y1, _y2;
    private void Start()
    {
        transform.position = new Vector2(Random.Range(_x1, _x2), Random.Range(_y1, _y2));
    }
}
