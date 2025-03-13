using UnityEngine;

public class CameraDrag : MonoBehaviour
{
    public float DragSpeed = 0.1f;
    private Vector3 _lastMousePosition;

    void Update()
    {
        if (Input.GetMouseButtonDown(2)) // Middle mouse button
        {
            _lastMousePosition = Input.mousePosition;
        }

        if (Input.GetMouseButton(2))
        {
            Vector3 delta = Input.mousePosition - _lastMousePosition;
            Vector3 move = new Vector3(-delta.x * DragSpeed, 0, -delta.y * DragSpeed);
            transform.Translate(move, Space.World);
            _lastMousePosition = Input.mousePosition;
        }
    }
}
