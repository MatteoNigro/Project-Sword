using UnityEngine;

public class MouseControls : MonoBehaviour, IControllable
{
    private Camera mainCamera;
    public float Horizontal { get; set; }
    public float Vertical { get; set; }

    private void Awake()
    {
        mainCamera = Camera.main;
    }

    private void Update()
    {
        Vector3 mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);

        Horizontal = mousePosition.x;
        Vertical = mousePosition.y;
    }

}
