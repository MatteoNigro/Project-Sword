using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    private IControllable playerControls;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();

        if (GetComponent<MouseControls>() != null && GetComponent<MouseControls>().isActiveAndEnabled)
        {
            playerControls = GetComponent<MouseControls>();
        }
        else if (GetComponent<KeyboardControls>() != null && GetComponent<KeyboardControls>().isActiveAndEnabled)
        {
            playerControls = GetComponent<KeyboardControls>();
        }
    }

    private void FixedUpdate()
    {
        Vector2 movement = new Vector2(playerControls.Horizontal, playerControls.Vertical);
        rigidbody.velocity = movement * Time.fixedDeltaTime;
    }
}
