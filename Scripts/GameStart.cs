using UnityEngine.Events;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    [SerializeField] private UnityEvent _onGameStarted;
    private Animator _animator;
    private void Start()
    {
        _animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            _onGameStarted.Invoke();
            _animator.SetTrigger("Death");
            Destroy(gameObject, 0.5f);
            Destroy(this);
        }
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            _onGameStarted.Invoke();
            _animator.SetTrigger("Death");
            Destroy(gameObject, 0.5f);
            Destroy(this);
        }
    }
}
