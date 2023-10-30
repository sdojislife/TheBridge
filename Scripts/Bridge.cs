using UnityEngine;
public class Bridge : MonoBehaviour
{
    [SerializeField] private LayerMask _inputFieldLayer;
    private readonly int _rotationLimit = 10;
    public void TryToRotate(int rotation)
    {
        if(Mathf.Abs(transform.rotation.z * Mathf.Rad2Deg + rotation * Time.deltaTime) < _rotationLimit)
        {
            transform.Rotate(0, 0, rotation * Time.deltaTime);
        }
    }
    private void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Vector3 touchPosWorld = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            Vector2 touchPosWorld2D = new Vector2(touchPosWorld.x, touchPosWorld.y);
            RaycastHit2D hit = Physics2D.Raycast(touchPosWorld2D, Camera.main.transform.forward,Mathf.Infinity,_inputFieldLayer);
            if (hit.collider != null)
            {
                hit.transform.gameObject.TryGetComponent(out InputField inputField);
                TryToRotate(inputField.Rotation);
            }
        }
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Vector3 touchPosWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 touchPosWorld2D = new Vector2(touchPosWorld.x, touchPosWorld.y);
            RaycastHit2D hit = Physics2D.Raycast(touchPosWorld2D, Camera.main.transform.forward, Mathf.Infinity,_inputFieldLayer);
            if (hit.collider != null)
            {
                hit.transform.gameObject.TryGetComponent(out InputField inputField);
                Debug.Log(hit.collider.gameObject.name);
                TryToRotate(inputField.Rotation);
            }
        }
    }
}
