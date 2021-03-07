using UnityEngine;

public class Shooter : MonoBehaviour
{
    Camera _camera;

   void Start() => _camera = Camera.main;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = Input.mousePosition;
            Ray shootingRay = _camera.ScreenPointToRay(mousePosition);
            RaycastHit2D hit2D = Physics2D.Raycast(shootingRay.origin, shootingRay.direction);

            Collider2D collider = hit2D.collider;
            if (collider != null && collider.TryGetComponent(out Target target))
                target.Hit();

        }
    }
}
