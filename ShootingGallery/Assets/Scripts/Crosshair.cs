using UnityEngine;

public class Crosshair : MonoBehaviour
{
    Camera _camera;

    void Start() => _camera = Camera.main;

    void Update()
    {
        Vector3 crosshairPosition = _camera.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(crosshairPosition.x, crosshairPosition.y, transform.position.z);
    }
}
