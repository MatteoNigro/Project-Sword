using UnityEngine;

public class KeyboardControls : MonoBehaviour, IControllable
{
    public float Horizontal { get; set; }
    public float Vertical { get; set; }

    [SerializeField] private float speed;

    private void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal") * speed;
        Vertical = Input.GetAxisRaw("Vertical") * speed;
    }
}
