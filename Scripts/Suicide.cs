using UnityEngine;

public class Suicide : MonoBehaviour
{
    [SerializeField] private float _delay;
    private void Awake()
    {
        Destroy(gameObject, _delay);
    }
}
